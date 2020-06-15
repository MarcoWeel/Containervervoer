using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContainerVervoer.Tests
{
    [TestClass]
    public class ContainerSorterTests
    {
        private Ship ship;
        private List<Row> rows;
        private List<Row> comparerRows;
        private List<Container> containers;
        [TestInitialize]
        public void Setup()
        {
            rows = new List<Row>();
            comparerRows = new List<Row>();
            containers = new List<Container>();
        }

        [TestMethod]
        public void Check_If_Sorting_Works_In_2X2()
        {
            ship = new Ship(2, 2);
            for (int i = 0; i < ship.Width; i++)
            {
                comparerRows.Add(new Row());
                for (int j = 0; j < ship.Length; j++)
                {
                    comparerRows[i].AddEmptyStackToRow(new Stack());
                }
            }
            comparerRows[1].TryToPlaceContainerInStackList(new Container(20000, ContainerVariant.Coolable), 0);
            comparerRows[1].TryToPlaceContainerInStackList(new Container(20000, ContainerVariant.CoolableAndValuable), 0);
            comparerRows[1].TryToPlaceContainerInStackList(new Container(20000, ContainerVariant.Normal), 1);
            comparerRows[1].TryToPlaceContainerInStackList(new Container(20000, ContainerVariant.Valuable), 1);

            comparerRows[0].TryToPlaceContainerInStackList(new Container(20000, ContainerVariant.Coolable), 0);
            comparerRows[0].TryToPlaceContainerInStackList(new Container(10000, ContainerVariant.Normal), 0);
            comparerRows[0].TryToPlaceContainerInStackList(new Container(20000, ContainerVariant.CoolableAndValuable), 0);
            comparerRows[0].TryToPlaceContainerInStackList(new Container(20000, ContainerVariant.Normal), 1);
            comparerRows[0].TryToPlaceContainerInStackList(new Container(10000, ContainerVariant.Normal), 1);
            comparerRows[0].TryToPlaceContainerInStackList(new Container(20000, ContainerVariant.Valuable), 1);

            foreach (var row in comparerRows)
            {
                foreach (var stack in row.Stacks)
                {
                    foreach (var container in stack.Containers)
                    {
                        containers.Add(container);
                    }
                }
            }

            rows = ContainerSorter.SortContainersIntoRows(ship.Width, ship.Length, containers);

            CollectionAssert.AreEqual(comparerRows, rows);
        }
    }
}
