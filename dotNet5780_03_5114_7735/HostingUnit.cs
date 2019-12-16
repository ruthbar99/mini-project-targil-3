//Ruth Bar Dagan (Bardugo) ID:208317735
//Yael Suisa ID:318905114
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5780_03_5114_7735
{
    public class HostingUnit
    {
        public string UnitName { get; set; }
        public int Rooms { get; set; }
        public bool IsSwimmingPool { get; set; }
        public List<DateTime> AllOrders { get; set; }
        public List<string> Uris { get; set; }
    }
}
