using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartDocDeliveryLibrary.Interfaces
{
    public interface IDocDeliveryTransaction
    {
        string DeliveryNo { get; set; }
        string SequenceNo { get; set; }
        string AccountNo { get; set; }
        string FileName { get; set; }
        string SubscriberName { get; set; }
        string Address { get; set; }
        string MINSRN { get; set; }
        string Brand { get; set; }
        string ZipCode { get; set; }
        string Remarks { get; set; }
        string DeliveryStatus { get; set; }
        DateTime? DeliveryStatusDate { get; set; }
        string ReceivedBy { get; set; }
        string Relationship { get; set; }
        string RTSNewAddress  { get; set; }
        string RTSReason { get; set; }
        string DCCode { get; set; }
        string DCName { get; set; }
        string Messenger { get; set; }
        string CycleFilename { get; set; }
        bool IsMerged { get; set; }
    }
}
