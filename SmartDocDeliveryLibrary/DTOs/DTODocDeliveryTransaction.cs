using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartDocDeliveryLibrary.Interfaces;

namespace SmartDocDeliveryLibrary.DTOs
{
    public class DTODocDeliveryTransaction : IDocDeliveryTransaction
    {
        public string DeliveryNo { get; set; }
        public string SequenceNo { get; set; }
        public string AccountNo { get; set; }
        public string FileName { get; set; }
        public string SubscriberName { get; set; }
        public string Address { get; set; }
        public string MINSRN { get; set; }
        public string Brand { get; set; }
        public string ZipCode { get; set; }
        public string Remarks { get; set; }
        public string DeliveryStatus { get; set; }
        public DateTime? DeliveryStatusDate { get; set; }
        public string ReceivedBy { get; set; }
        public string Relationship { get; set; }
        public string RTSNewAddress { get; set; }
        public string RTSReason { get; set; }
        public string DCCode { get; set; }
        public string DCName { get; set; }
        public string Messenger { get; set; }
        public string CycleFilename { get; set; }
        public bool IsMerged { get; set; }
    }

    public class DTODocDeliveryTransactionList : List<DTODocDeliveryTransaction>, IDisposable
    {
        public void Dispose()
        {
        }
    }
}
