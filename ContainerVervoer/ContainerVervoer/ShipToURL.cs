using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer
{
    public class ShipToURL
    {
        public static string ShipToUrl(Ship ship)
        {
            string stackString = "";
            string weightString = "";
            string standardString = "https://i872272core.venus.fhict.nl/ContainerVisualizer/index.html?";
            int rowIndex = 0;
            int stackIndex = 0;

            foreach (var row in ship.Rows)
            {
                foreach (var stack in row.Stacks)
                {
                    for (int i = 0; i < stack.Containers.Count; i++)
                    {
                        stackString += ((int)stack.Containers.ElementAt(i).Variant + 1).ToString();
                        weightString += Math.Round(Convert.ToDouble(stack.Containers.ElementAt(i).Weight / 1000)).ToString();
                        if (i + 1 < stack.Containers.Count)
                        {
                            weightString += "-";
                            stackString += "-";
                        }
                    }
                    if (stackIndex + 1 < ship.Length)
                    {
                        stackString += ",";
                        weightString += ",";
                    }
                    stackIndex++;
                }
                if (rowIndex + 1 < ship.Width)
                {
                    stackString += "/";
                    weightString += "/";
                }
                rowIndex++;
                stackIndex = 0;
            }
            return $"{standardString}length={ship.Length}&width={ship.Width}&stacks={stackString}&weights={weightString}";
        }
    }
}
