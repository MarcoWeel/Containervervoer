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
        public Form1()
        {
            InitializeComponent();
            CBType.DataSource = Enum.GetValues(typeof(ContainerVariant));
            containers = new List<Container>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LBContainers.Items.Add(new Container(Convert.ToInt32(NumericWeight.Value), (ContainerVariant)CBType.SelectedItem));
            containers.Add(new Container((int)NumericWeight.Value, (ContainerVariant)CBType.SelectedItem));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (containers.Count == 0)
            {
                MessageBox.Show("Voeg eerst containers toe");
                return;
            }
            try
            {
                ship.AddLeftRowsToShip(ContainerSorter.SortContainersIntoRows(ship.Width, ship.Length, containers));
                TBURL.Text = ShipToURL.ShipToUrl(ship);
            }
            catch (Exception exception)
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
            LBLShipMinWeight.Text = "Ship Min Weight: " + ship.MinWeight.ToString();
            LBLShipMaxWeight.Text = "Ship Max Weight: " + ship.MaxWeight.ToString();
        }
    }
}
