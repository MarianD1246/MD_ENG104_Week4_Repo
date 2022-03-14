using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    public class Adress
    {
        
        public int HouseNo { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }

        public Adress(int houseNo, string street, string town)
        {
            HouseNo = houseNo;
            Street = street;
            Town = town;
        }

        public string GetAdress()
        {
            return $"{HouseNo} {Street}, {Town}";
        }
    }
}
