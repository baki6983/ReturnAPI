using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressAPI.Models
{
    public class Line
    {
        public string Id { get; set; }
        public string ItemId { get; set; }
        public int Quantity { get; set; }
        public string ReasonCode { get; set; }
        public string SubReasonCode { get; set; }
    }
}
