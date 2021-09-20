using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary.Model
{
    public class OrdersOrdMainData : ViewModelBase
    {
        #region Instance Properties
        public Int32? ID { get; set; }
        public Int32? OrdFlNoIssued { get; set; }
        public Int32? OrdFlNoOutsdUnDock { get; set; }
        public Int32? OrdFlNoComplDock { get; set; }
        public Int32? OrdFlNoOutsdUnDesp { get; set; }
        public Int32? OrdFlNoComplDesp { get; set; }
        public Int32? OrdFlNoCancl { get; set; }
        public Int16? OrdType { get; set; }
        public Int16? OrdCsNoIssued { get; set; }
        public Int16? OrdCsNoOutsdUnDock { get; set; }
        public Int16? OrdCsNoComplDock { get; set; }
        public Int16? OrdCsNoOutsdUnDesp { get; set; }
        public Int16? OrdCsNoComplDesp { get; set; }
        public Int16? OrdCsNoCancl { get; set; }
        public String OrdRef { get; set; }
        public Int16? OrdAgntNoIssd { get; set; }
        public Int16? OrdAgntNoUnDock { get; set; }
        public Int16? OrdAgntNoDock { get; set; }
        public Int16? OrdAgntNoUnDesp { get; set; }
        public Int16? OrdAgntNoDesp { get; set; }
        public Int16? OrdAgntNoCancl { get; set; }
        public double? OrdAgentComn { get; set; }
        public Int16? NoOfDays { get; set; }
        public DateTime? OrdIssueDate { get; set; }
        public Int16? OrdCurrNo { get; set; }
        public double? OrdSellingRate { get; set; }
        public double? OrdConfirmedRate { get; set; }
        public Int16? OrdDelFlag { get; set; }
        public Int16? OrdCanFlag { get; set; }
        public Int16? OrdOutUnDockFlag { get; set; }
        public Int16? OrdComDockFlag { get; set; }
        public Int16? OrdOutUnDespFlag { get; set; }
        public Int16? OrdComDespFlag { get; set; }
        #endregion Instance Properties

        public OrdersOrdMainData()
        {
            ID = 0;
            OrdFlNoOutsdUnDock = 0;
            OrdFlNoComplDock = 0;
            OrdFlNoOutsdUnDesp = 0;
            OrdFlNoComplDesp = 0;
            OrdFlNoCancl = 0;
            OrdType = 0;
            OrdCsNoOutsdUnDock = 0;
            OrdCsNoComplDock = 0;
            OrdCsNoComplDesp = 0;
            OrdCsNoCancl = 0;
            OrdAgntNoIssd = 0;
            OrdAgntNoUnDock = 0;
            OrdAgntNoDock = 0;
            OrdAgntNoUnDesp = 0;
            OrdAgntNoDesp = 0;
            OrdAgntNoCancl = 0;
            OrdAgentComn = 0;
            NoOfDays = 0;
            OrdIssueDate = DateTime.Now;
            OrdCurrNo = 1;
            OrdSellingRate = 1.0;
            OrdConfirmedRate = 0.0;
            OrdDelFlag = 0;
            OrdCanFlag = 0;
            OrdOutUnDockFlag = 0;
            OrdComDockFlag = 0;
            OrdOutUnDespFlag = 0;
            OrdComDespFlag = 0;
        }
    }
}
