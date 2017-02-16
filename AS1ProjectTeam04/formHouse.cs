using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS1ProjectTeam04
{
    public partial class formHouse : Form
    {
        List<House> houses = new List<House>();

        public formHouse()
        {
            InitializeComponent();

            OpenFileDialog openFileD = new OpenFileDialog();
            openFileD.InitialDirectory = ".";
            StreamReader readFile;

            if(openFileD.ShowDialog() == DialogResult.OK)
            {
                readFile = File.OpenText(openFileD.FileName);

                while (!readFile.EndOfStream)
                {
                    string[] house = readFile.ReadLine().Split(',');
                    for(int i=0; i < house.Length; i++)
                    {
                        house[i] = house[i].Trim();
                    }
                    houses.Add(new House(house));              
                }
            }else
            {
                return;
            }
        }

        private void btnGetListings_Click(object sender, EventArgs e)
        {
            IEnumerable<House> query = from house in houses
                        orderby house.Price
                        select house;

            //showToGrid(query, gridListings, lbCountListings, lbAvgListings);               
        }

        private void btnFindHouses_Click(object sender, EventArgs e)
        {
            string houseType;

            //if(rbCondo.checked){
            //    type = Condo;
            //}else if(rbTownhouse.checked){
            //    type = Townhouse;
            //}else if(rbHouse.checked){
            //    type = House;
            //}

            //int maxPrice = int.Parse(tbMaxPrice.Text);
            //int bedrooms = int.Parse(tbBedrooms.Text);
            //Buyer guest = new Buyer(maxPrice, houserType, bedrooms);

            //IEnumerable<House> query = from house in houses
            //                           where guest.MaxPrice <= house.Price
            //                           where guest.HouseType == house.Type
            //                           where guest.Bedrooms >= house.Bedrooms
            //                           orderby house.Price
            //                           select house;

            //showToGrid(query, gridResults, lbCoundResults, lbAvgResults);

        }

        private void showToGrid(IEnumerable<House> query, DataGridView grid, Label count, Label avg)
        {
            grid.Rows.Clear();
            grid.Refresh();
            count.Text = query.Count().ToString("C");
            avg.Text = query.Average(h => h.Price).ToString();

            foreach (House house in query)
            {
                house.AddToGridView(grid);
            }
        }
    }

}
