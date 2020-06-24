using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContainerVervoer.websocket;

namespace ContainerVervoer
{
    public partial class Form1 : Form
    {
        private Ship ship;
        private List<Container> containers;
        private int weight = 0;
        private int normalContainers = 0;
        private int valuableContainers = 0;
        private int coolableContainers = 0;
        private int coolableAndValuableContainers = 0;
        FleckWebSocketServer webSocketServer; 
        public Form1()
        {
            InitializeComponent();
            CBType.DataSource = Enum.GetValues(typeof(ContainerVariant));
            containers = new List<Container>();
            webSocketServer = new FleckWebSocketServer("127.0.0.1", "8181");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Convert.ToInt32(NumericContainerAmount.Value); i++)
            {
                LBContainers.Items.Add(new Container(Convert.ToInt32(NumericWeight.Value), (ContainerVariant)CBType.SelectedItem));
                containers.Add(new Container((int)NumericWeight.Value, (ContainerVariant)CBType.SelectedItem));
                weight += Convert.ToInt32(NumericWeight.Value);
                if ((ContainerVariant)CBType.SelectedItem == ContainerVariant.Normal)
                {
                    normalContainers++;
                    LBLNormalContainers.Text = "Normal: " + normalContainers;
                }
                else if ((ContainerVariant)CBType.SelectedItem == ContainerVariant.Coolable)
                {
                    coolableContainers++;
                    LBLCoolableContainers.Text = "Coolable: " + coolableContainers;
                }
                else if ((ContainerVariant)CBType.SelectedItem == ContainerVariant.Valuable)
                {
                    valuableContainers++;
                    LBLValuableContainer.Text = "Valuable: " + valuableContainers;
                }
                else
                {
                    coolableAndValuableContainers++;
                    LBLCoolableAndValuableContainers.Text = "Coolable and valuable: " + coolableAndValuableContainers;
                }

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

            if (ship != null)
            {
                ship = new Ship(ship.Width, ship.Length);
                bool success = ship.CheckWeightOfRowsAndAddToShip(ContainerSorter.SortContainersIntoRows(ship.Width, ship.Length, containers));
                var output = ShipToURL.ShipToUrl(ship);
                TBURL.Text = output;
                double balance = ContainerBalancer.GetBalanceDifference(ship.Rows.ToList());
                LBLBalance.Text = "Ship Balance difference: " + balance;
                if (webSocketServer.Sockets.Any())
                {
                    foreach (var socket in webSocketServer.Sockets)
                    {
                        socket.Send(TBURL.Text);
                    }
                    return;
                }
                var confirmResult = MessageBox.Show("Open ship visualizer in new browser tab?",
                    "Open visualizer!",
                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(output);
                }
                foreach (var socket in webSocketServer.Sockets)
                {
                    socket.Send(TBURL.Text);
                }
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
            LBLContainerWeight.Text = "Container gewicht: 0";
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
