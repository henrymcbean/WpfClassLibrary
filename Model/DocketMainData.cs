using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace WpfClassLibrary.Model
{
    public class DocketMainData : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }

        private Int32? docketNoIssued;
        public Int32? DocketNoIssued
        {
            get { return docketNoIssued; }
            set 
            {
                docketNoIssued = value;
                OnPropertyChanged("DocketNoIssued");  
            }
        }

        public Int32? DocketNoOutsd { get; set; }
        public Int32? DocketNoCompl { get; set; }

        private DateTime? issueDate;
        public DateTime? IssueDate
        {
            get { return issueDate; }
            set 
            {
                issueDate = value;
                OnPropertyChanged("IssueDate");   
            }
        }

        private DateTime? delivDateIssued;
        public DateTime? DelivDateIssued
        {
            get { return delivDateIssued; }
            set 
            {
                delivDateIssued = value;
                OnPropertyChanged("DelivDateIssued");   
            }
        }

        public DateTime? DelivDateOutsd { get; set; }
        public DateTime? DelivDateCompl { get; set; }
        public Int16? CustomerNoIssued { get; set; }
        public Int16? CustomerNoOutsd { get; set; }
        public Int16? CustomerNoCompl { get; set; }
        public Int16? OutWorkerIssued { get; set; }
        public Int16? OutWorkerOutsd { get; set; }
        public Int16? OutWorkerCompl { get; set; }

        private Int32? custOrderNoIssued;
        public Int32? CustOrderNoIssued
        {
            get { return custOrderNoIssued; }
            set 
            {
                custOrderNoIssued = value;
                OnPropertyChanged("CustOrderNoIssued");    
            }
        }

        public Int32? CustOrderNoOutsd { get; set; }
        public Int32? CustOrderNoCompl { get; set; }
        public Int16? CustOrderType { get; set; }


        private String custOrderDescr;
        public String CustOrderDescr
        {
            get { return custOrderDescr; }
            set 
            {
                custOrderDescr = value;
                OnPropertyChanged("CustOrderDescr");    
            }
        }


        private Int32? colnNo;
        public Int32? ColnNo
        {
            get { return colnNo; }
            set 
            {
                colnNo = value;
                OnPropertyChanged("ColnNo"); 
            }
        }

        public Int16? DeletionFlag { get; set; }
        public Int16? CancelationFlag { get; set; }
        public Int16? CompletionFlag { get; set; }
        public Int16? OutstandingFlag { get; set; }
        public double? CmtPrice { get; set; }
        public double? CurRateIssue { get; set; }
        public double? AdvancePayment { get; set; }
        #endregion Instance Properties

        public DocketMainData()
        {
            ID = 0;

            DocketNoIssued =
            DocketNoOutsd =
            DocketNoCompl = 0;

            CustomerNoIssued =
            CustomerNoOutsd =
            CustomerNoCompl = 0;

            OutWorkerOutsd =
            OutWorkerCompl = 0;

            CustOrderNoOutsd =
            CustOrderNoCompl = 0;

            CustOrderType = 0;
            CustOrderDescr = "";
            DeletionFlag =
            CancelationFlag =
            CompletionFlag =
            OutstandingFlag = 0;

            AdvancePayment = 0.0;
        }

        public void Clear()
        {
            DocketNoIssued =
            DocketNoOutsd =
            DocketNoCompl = 0;

            CustomerNoIssued =
            CustomerNoOutsd =
            CustomerNoCompl = 0;

            OutWorkerOutsd =
            OutWorkerCompl = 0;

            CustOrderNoOutsd =
            CustOrderNoCompl = 0;

            CustOrderType = 0;
            CustOrderDescr = "";
            DeletionFlag =
            CancelationFlag =
            CompletionFlag =
            OutstandingFlag = 0;

            CurRateIssue = 0.0;
            AdvancePayment = 0.0;
            OutWorkerIssued = null;
            CustOrderNoIssued = null;
        }
    }
}
