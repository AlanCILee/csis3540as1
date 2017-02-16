using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS1ProjectTeam04
{
    class House
    {
        private string[] houseData;
        public string HouseCode { get { return houseData[0]; } }
        public string Type { get { return houseData[1]; } }
        public string Neighborhood { get { return houseData[2]; } }
        public int Price { get { return int.Parse(houseData[3]); } }
        public int Bedrooms { get { return int.Parse(houseData[4]); } }

        public House(string[] houseArr)
        {
            houseData = houseArr;
        }

        public void AddToGridView(DataGridView d)
        {
            d.Rows.Add(houseData);
            //
        }
    }
}
