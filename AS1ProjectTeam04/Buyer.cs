using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS1ProjectTeam04
{
    class Buyer
    {
        public int MaxPrice { set { MaxPrice = value; } get { return MaxPrice; } }
        public string HouseType { set { HouseType = value; } get { return HouseType; } }
        public int Bedrooms { set { Bedrooms = value; } get { return Bedrooms; } }

        public Buyer(int maxPrice, string houseType, int bedrooms)
        {
            MaxPrice = maxPrice;            
            HouseType = houseType;
            Bedrooms = bedrooms;
        }
    }

}
