using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressReturnAPI.Models
{
    public class ReturnHead
    {
        public string Id { get; set; }
        public string BuCode { get; set; }
        public string TillNumber { get; set; }
        public string TransactionNumber { get; set; }
        public string Date { get; set; }
        public string OrderNumber { get; set; }
        public Customer Customer { get; set; }
        public List<Line> Lines { get; set; }
    }
}
