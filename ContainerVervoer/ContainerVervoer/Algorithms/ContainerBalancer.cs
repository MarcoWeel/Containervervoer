using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer
{
    public class ContainerBalancer
    {
        public static double GetBalanceDifference(List<Row> rows)
        {
            int index = 0;
            int leftWeight = 0;
            int rightWeight = 0;
            int maxWeight = 0;
            double difference = 0;
            if (rows.Count % 2 == 0)
            {
                for (int i = rows.Count - 1; i >= rows.Count / 2; i--)
                {
                    rightWeight += rows[i].GetRowWeight();
                }

                for (int i = 0; i < (rows.Count / 2); i++)
                {
                    leftWeight += rows[i].GetRowWeight();
                }

                for (int i = 0; i < rows.Count; i++)
                {
                    maxWeight += rows[i].GetRowWeight();
                }
            }
            else
            {
                for (int i = 0; i < rows.Count / 2; i++)
                {
                    leftWeight += rows[i].GetRowWeight();
                }

                for (int i = rows.Count - 1; i >= rows.Count / 2 + 1; i--)
                {
                    rightWeight += rows[i].GetRowWeight();
                }

                for (int i = 0; i < rows.Count; i++)
                {
                    maxWeight += rows[i].GetRowWeight();
                }

                maxWeight -= rows[rows.Count / 2].GetRowWeight();
            }

            double leftWeightDouble = Convert.ToDouble(leftWeight);
            double rightWeightDouble = Convert.ToDouble(rightWeight);
            double maxWeightDouble = Convert.ToDouble(maxWeight);
            difference = (leftWeightDouble - rightWeightDouble) * 100 / maxWeightDouble;
            if (difference < 0)
            {
                difference = difference * -1;
            }

            return difference;
        }

        public static List<Row> BalanceRows(List<Row> rows)
        {
            Row[] newRowArray = new Row[rows.Count];
            int indexLeft = 0;
            int indexRight = 1;
            int count = 1;
            bool placeLeft = true;
            double difference = GetBalanceDifference(rows);
            while (difference > 20)
            {
                if (rows.Count % 2 == 0)
                {
                    rows.OrderBy(x => x.GetRowWeight());
                    foreach (var row in rows)
                    {
                        if (placeLeft)
                        {
                            newRowArray[indexLeft] = row;
                            placeLeft = false;
                            indexLeft++;
                        }
                        else
                        {
                            newRowArray[rows.Count - indexRight] = row;
                            placeLeft = true;
                            indexRight++;
                        }
                    }
                }
                else
                {
                    rows.OrderBy(x => x.GetRowWeight());
                    foreach (var row in rows)
                    {
                        int mid = rows.Count / 2;
                        if (newRowArray[mid] == null)
                        {
                            newRowArray[mid] = row;
                        }
                        else
                        {
                            if (placeLeft)
                            {
                                newRowArray[indexLeft] = row;
                                indexLeft++;
                                count++;
                                if (count == 2)
                                {
                                    placeLeft = false;
                                    count = 0;
                                }
                            }
                            else
                            {
                                newRowArray[rows.Count - indexRight] = row;
                                count++;
                                indexRight++;
                                if (count == 2)
                                {
                                    placeLeft = true;
                                    count = 0;
                                }
                            }
                        }
                    }
                }

                if (indexLeft > rows.Count / 2 + 1 || indexRight > rows.Count / 2 + 1)
                {
                    throw new ArgumentException("Can't balance containers");
                }

                difference = GetBalanceDifference(newRowArray.ToList());

                if (difference > 20)
                {
                    indexLeft = 0;
                    indexRight = 1;
                    rows.OrderBy(x => x.GetRowWeight());
                    foreach (var row in rows)
                    {
                        int mid = rows.Count / 2;
                        if (row == rows.Last())
                        {
                            newRowArray[mid] = row;
                        }
                        else
                        {
                            if (placeLeft)
                            {
                                newRowArray[indexLeft] = row;
                                indexLeft++;
                                count++;
                                if (count == 2)
                                {
                                    placeLeft = false;
                                    count = 0;
                                }
                            }
                            else
                            {
                                newRowArray[rows.Count - indexRight] = row;
                                count++;
                                indexRight++;
                                if (count == 2)
                                {
                                    placeLeft = true;
                                    count = 0;
                                }
                            }
                        }
                    }
                    difference = GetBalanceDifference(newRowArray.ToList());
                }
            }
            if (newRowArray[0] == null)
            {
                return rows;
            }
            return newRowArray.ToList();
        }
    }
}
