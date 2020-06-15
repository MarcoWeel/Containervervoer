using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer
{
    public class ContainerBalancer
    {
        public static int GetBalanceDifference(List<Row> rows)
        {
            int index = 0;
            int leftWeight = 0;
            int maxWeight = 0;
            int difference = 0;
            for (int i = 0; i < (rows[0].Stacks.Count / 2); i++)
            {
                leftWeight += rows[index].GetRowWeight();
            }
            for (int i = 0; i < rows.Count; i++)
            {
                maxWeight += rows[i].GetRowWeight();
            }

            difference = leftWeight / maxWeight * 100;

            return difference;
        }

        public static List<Row> BalanceRows(List<Row> rows)
        {
            Row[] newRowArray = new Row[rows.Count];
            int Index = 0;
            bool placeLeft = true;
            int difference = GetBalanceDifference(rows);
            while (difference > 40 && difference < 60)
            {

                if (rows.Count % 2 == 0)
                {
                    rows.OrderBy(x => x.GetRowWeight());
                    foreach (var row in rows)
                    {
                        if (placeLeft)
                        {
                            newRowArray[Index] = row;
                            placeLeft = false;
                        }

                        if (placeLeft == false)
                        {
                            newRowArray[rows.Count - Index - 1] = row;
                            placeLeft = true;
                        }

                    }
                }
                if (Index > rows.Count - 1)
                {
                    throw new ArgumentException("Can't balance containers");
                }
                difference = GetBalanceDifference(rows);
            }

            if (newRowArray[0] == null)
            {
                return rows;
            }
            return newRowArray.ToList();
        }
    }
}
