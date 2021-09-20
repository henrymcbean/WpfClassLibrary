using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WpfClassLibrary.TmpModel
{
    public interface ICloneable<T>
    {
        T Clone();
    }
}
