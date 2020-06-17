using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContainerVervoer
{
    public partial class Form1 : Form
    {
        private Ship ship;
        private List<Container> containers;
        private int weight = 0;
        public Form1()
        {
            InitializeComponent();
            CBType.DataSource = Enum.GetValues(typeof(ContainerVariant));
            containers = new List<Container>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Convert.ToInt32(NumericContainerAmount.Value); i++)
            {
                LBContainers.Items.Add(new Container(Convert.ToInt32(NumericWeight.Value), (ContainerVariant)CBType.SelectedItem));
                containers.Add(new Container((int)NumericWeight.Value, (ContainerVariant)CBType.SelectedItem));
                weight += Convert.ToInt32(NumericWeight.Value);
            }
            LBLContainerWeight.Text = "Container gewicht: " + weight;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (containers.Count == 0)
            {
                MessageBox.Show("Voeg eerst containers toe");
                return;
            }

            if (ship.Width != 0)
            {
                bool success = ship.CheckWeightOfRowsAndAddToShip(ContainerSorter.SortContainersIntoRows(ship.Width, ship.Length, containers));
                TBURL.Text = ShipToURL.ShipToUrl(ship);
                double balance = ContainerBalancer.GetBalanceDifference(ship.Rows.ToList());
                LBLBalance.Text = "Ship Balance difference: " + balance;
                if (success == false)
                {
                    throw new ArgumentException("Weight is too high or too low");
                }
            }
            else
            {
                MessageBox.Show("Creëer eerst een ship");
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            LBContainers.Items.Clear();
            containers.Clear();
            ship = new Ship((int)NumericWidth.Value, (int)NumericLength.Value);
        }

        private void BtnCreateShip_Click(object sender, EventArgs e)
        {
            ship = new Ship((int)NumericWidth.Value, (int)NumericLength.Value);
            LBLShipMinWeight.Text = "Ship Min gewicht: " + ship.MinWeight.ToString();
            LBLShipMaxWeight.Text = "Ship Max gewicht: " + ship.MaxWeight.ToString();
        }
    }
}
