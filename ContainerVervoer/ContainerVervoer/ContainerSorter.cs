using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContainerVervoer
{
    public class ContainerSorter
    {
        public static List<Row> SortContainersIntoRows(int shipWidth, int shipLength, List<Container> containers)
        {
            List<Row> rows = GetRowsFromShipDimensions(shipWidth, shipLength);
            rows = SortCoolableContainers(ListSorter.GetCoolableContainers(containers), rows);
            rows = SortNormalContainers(ListSorter.GetNormalContainers(containers), rows);
            rows = SortValuableAndCoolableContainers(ListSorter.GetCoolableAndValuableContainers(containers), rows);
            rows = SortValuableContainers(ListSorter.GetValuableContainers(containers), rows);
            rows = ContainerBalancer.BalanceRows(rows);
            return rows;
        }

        private static List<Row> GetRowsFromShipDimensions(int shipWidth, int shipLength)
        {
            List<Row> rows = new List<Row>();
            for (int i = 0; i < shipWidth; i++)
            {
                rows.Add(new Row());
                for (int j = 0; j < shipLength; j++)
                {
                    rows[i].AddStackToRow(new Stack());
                }
            }
            return rows;
        }

        private static List<Row> SortCoolableContainers(List<Container> containers, List<Row> rows)
        {
            int index = 0;
            bool isPlaced = true;
            foreach (var container in containers)
            {
                rows[index].TryToPlaceContainerInStackList(container, 0);
                if (index < rows.Count - 1)
                {
                    index++;
                }
                else
                {
                    index = 0;
                }
            }

            return rows;
        }

        private static List<Row> SortNormalContainers(List<Container> containers, List<Row> rows)
        {
            foreach (var container in containers)
            {
                Row row = rows.OrderBy(x => x.GetMinRowHeight()).First();
                Stack stack = row.Stacks.OrderBy(x => x.Height).ThenBy(y => y.Weight).First();

                stack.TryToPlaceContainer(container);
            }

            foreach (var row in rows)
            {
                row.SortStacksByHeight();
            }

            return rows;
        }

        private static List<Row> SortValuableAndCoolableContainers(List<Container> containers, List<Row> rows)
        {
            int index = 0;
            bool CanPlace = true;
            int placed = 0;
            foreach (var container in containers)
            {
                CanPlace = rows[index].TryToPlaceContainerInStackList(container, 0);
                if (index < rows.Count - 1)
                {
                    index++;
                }
                else
                {
                    index = 0;
                }
                if (CanPlace)
                {
                    placed++;
                }
            }

            if (placed != containers.Count)
            {
                MessageBox.Show("Kan valuable en coolable containers niet plaatsen");
                throw new System.ArgumentException("Kan valuable en coolable containers niet plaatsen");
            }

            return rows;
        }

        private static List<Row> SortValuableContainers(List<Container> containers, List<Row> rows)
        {
            int rowIndex = 0;
            int stackIndex = 0;
            for (int i = 0; i < containers.Count;)
            {
                if (rows[rowIndex].TryToPlaceContainerInStackList(containers[i], stackIndex))
                {
                    i++;
                }
                if (stackIndex == rows[0].Stacks.Count - 1)
                {
                    rowIndex++;
                }

                if (stackIndex < rows[0].Stacks.Count - 1)
                {
                    stackIndex++;
                }
                else
                {
                    stackIndex = 0;
                }

                if (rowIndex > rows.Count - 1)
                {
                    MessageBox.Show("Kan valuable containers niet plaatsen");
                    throw new System.ArgumentException("Kan valuable containers niet plaatsen");
                }
            }
            return rows;
        }
    }
}
