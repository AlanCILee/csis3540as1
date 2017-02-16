using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS1ProjectTeam04
{
    class Buyer
    {
        public int MaxPrice { set; get; }
        public string HouseType { set; get; } 
        public int Bedrooms { set; get; }

        public Buyer(int maxPrice, string houseType, int bedrooms)
        {
            MaxPrice = maxPrice;
            HouseType = houseType;
            Bedrooms = bedrooms;
        }
    }

}
