using System;
using System.IO;
using System.Xml;
//using System.Xaml;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace WpfClassLibrary.Model
{
    abstract public class XmlConvertor
    {
        public static string Serialize(object dataToSerialize)
        {
            if (dataToSerialize == null) return null;

            using (StringWriter stringwriter = new System.IO.StringWriter())
            {
                var serializer = new XmlSerializer(dataToSerialize.GetType());
                serializer.Serialize(stringwriter, dataToSerialize);
                return stringwriter.ToString();
            }
        }

        public static T Deserialize<T>(string xmlText)
        {
            if (String.IsNullOrWhiteSpace(xmlText)) return default(T);

            using (StringReader stringReader = new System.IO.StringReader(xmlText))
            {
                var serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(stringReader);
            }
        }

        public static IEnumerable<XElement> GetElementEnum(string sXml)
        {
            IEnumerable<XElement> rows = null;
            XmlDocument doc = new XmlDocument();

            try
            { 
                doc.LoadXml(sXml);
                rows = from el in doc.ToXDocument().Root.Elements()
                                             select el;
            }
            catch(Exception ex)
            {
                Debug.Print(ex.Message);
            }

            return rows;
        }
    }

    public static class XmlDocumentExtensions
    {
        public static XDocument ToXDocument(this XmlDocument document)
        {
            return document.ToXDocument(LoadOptions.None);
        }

        public static XDocument ToXDocument(this XmlDocument document, LoadOptions options)
        {
            using (XmlNodeReader reader = new XmlNodeReader(document))
            {
                return XDocument.Load(reader, options);
            }
        }
    }
}
