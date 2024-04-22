using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Domain.Entities
{
    public class FooterAddress
    {
        public int FooterAddressID { get; set; }
        public string FooterAddressDescription { get; set; }
        public string FooterAddressAddress { get; set; }
        public string FooterAddressPhone { get; set; }
        public string FooterAddressEmail { get; set; }
    }
}
