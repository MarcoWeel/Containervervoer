using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer
{
    public class ContainerSorter
    {
        //public List<Row> SortContainers(List<Container> containers, int shipLength, int shipWidth)
        //{
        //    List<Row> rows = PlaceCoolableContainers(containers, shipWidth, shipLength);





        //    return new List<Row>();
        //}


        //private List<Stack> getListOfStacksViaShipWidth(int shipWidth)
        //{
        //    List<Stack> stacks = new List<Stack>();
        //    for (int i = 0; i < shipWidth; i++)
        //    {
        //        stacks.Add(new Stack());
        //    }

        //    return stacks;
        //}

        //private List<Row> getListOfRowsViaShipWidthAndLength(int shipWidth, int shipLength)
        //{
        //    List<Row> rows = new List<Row>(shipLength);
        //    for (int i = 0; i < shipWidth; i++)
        //    {
        //        rows.Add(new Row());
        //    }
        //    return rows;
        //}

        //private List<Row> PlaceCoolableContainers(List<Container> containers, int shipWidth, int shipLength)
        //{
        //    int countPositive = 0;
        //    int countNegative = shipWidth - 1;
        //    bool Left = true;
        //    List<Container> coolableContainers = ListSorter.GetCoolableContainers(containers);
        //    List<Stack> stacks = getListOfStacksViaShipWidth(shipWidth);
        //    List<Row> rows = getListOfRowsViaShipWidthAndLength(shipWidth, shipLength);
        //    for (int i = 0; i < containers.Count; i++)
        //    {
        //        if (Left)
        //        {
        //            stacks[countPositive].TryToPlaceContainer(containers[i]);
        //            Left = false;
        //            countPositive++;
        //        }
        //        else
        //        {
        //            stacks[countNegative].TryToPlaceContainer(containers[i]);
        //            Left = true;
        //            countNegative--;
        //        }
        //    }

        //    int o = 0;
        //    foreach (var stack in stacks)
        //    {
        //        rows[o].AddStackToRow(stack);
        //    }

        //    return rows;
        //}

        //public List<Row> PlaceNormalContainers(List<Container> containers, int shipLength, int shipWidth)
        //{
        //    int count = 1;
        //    int count2 = 0;
        //    int count3 = 0;
        //    int countPositive = 0;
        //    int countNegative = shipWidth - 1;
        //    bool Left = true;
        //    List<Stack> stacks = getListOfStacksViaShipWidth(shipWidth);
        //    List<List<Stack>> HorizontalStackRow = new List<List<Stack>>();
        //    for (int i = 0; i < shipLength - 1; i++)
        //    {
        //        HorizontalStackRow.Add(stacks);
        //    }
        //    while (containers.Count != count2 + 1)
        //    {
        //        foreach (var stackList in HorizontalStackRow)
        //        {
        //            for (int i = 0; i < stackList.Count; i++)
        //            {
        //                if (Left)
        //                {
        //                    if (stackList[countPositive].TryToPlaceContainer(containers[count2]))
        //                    {
        //                        count2++;
        //                    }

        //                    countPositive++;
        //                    Left = false;
        //                }
        //                else
        //                {
        //                    if (stackList[countNegative].TryToPlaceContainer(containers[count2]))
        //                    {
        //                        count2++;
        //                    }

        //                    countNegative--;
        //                    Left = true;
        //                }

        //            }
        //        }
        //        count++;
        //    }
        //    return new List<Row>();
        //}

        //public List<Row> PlaceNormalContainersV2()
        //{



        //    return new List<Row>();
        //}

        //public List<Stack> PlaceCoolableAndValuableContainers(List<Stack> stacks, List<Container> containers)
        //{
        //    List<Container> coolableAndValuableContainers = ListSorter.GetCoolableAndValuableContainers(containers);
        //    int count = 0;
        //    foreach (var stack in stacks)
        //    {
        //        stack.TryToPlaceContainer(coolableAndValuableContainers[count]);
        //        count++;
        //    }

        //    return stacks;
        //}

        //public List<Stack> PlaceNormalContainersInStacks(List<Container> containers, int shipWidth, int shipLength)
        //{
        //    int countPositive = 0;
        //    int countNegative = shipWidth * (shipLength - 1) - 1;
        //    bool left = true;
        //    List<Container> normalContainers = ListSorter.GetNormalContainers(containers);
        //    List<Stack> stacks = getListOfStacksViaShipWidth(shipWidth * (shipLength - 1));
        //    for (int i = 0; i < containers.Count; i++)
        //    {
        //        if (left)
        //        {
        //            stacks[countPositive].TryToPlaceContainer(containers[i]);
        //            left = false;
        //            countPositive++;
        //        }
        //        else
        //        {
        //            stacks[countNegative].TryToPlaceContainer(containers[i]);
        //            left = true;
        //            countNegative--;
        //        }
        //    }

        //    return stacks;
    }
}
