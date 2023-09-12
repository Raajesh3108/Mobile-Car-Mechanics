using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicLayer
{
   public class ServiceRequest
    {
        public int ServiceRequestID;
        public int VehicleID;
        public int MechanicServiceID;
        public DateTime RequestTime;
        public DateTime CreateTime;
        public string ServiceRequestDetails;
        public string Status;
        public string Reply;
        public DateTime CompletionTime;
        public string Feedback;
        public int Rating;
    }
}
