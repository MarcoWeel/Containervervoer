using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ContainerVervoer.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContainerVervoer.Tests
{
    [TestClass]
    public class ContainerSorterTests
    {
        private Ship ship;
        private List<Row> rows;
        private List<Row> expectedRows;
        private List<Container> containers;
        [TestInitialize]
        public void Setup()
        {
            rows = new List<Row>();
            expectedRows = new List<Row>();
            containers = new List<Container>();
        }

        [TestMethod]
        public void Check_If_Sorting_Works_In_2X2()
        {
            ship = new Ship(2, 2);
            for (int i = 0; i < ship.Width; i++)
            {
                expectedRows.Add(new Row());
                for (int j = 0; j < ship.Length; j++)
                {
                    expectedRows[i].AddEmptyStackToRow(new Stack());
                }
            }
            expectedRows[0].TryToPlaceContainerInStackList(new Container(20000, ContainerVariant.Coolable), 0);
            expectedRows[0].TryToPlaceContainerInStackList(new Container(10000, ContainerVariant.Normal), 0);
            expectedRows[0].TryToPlaceContainerInStackList(new Container(20000, ContainerVariant.CoolableAndValuable), 0);
            expectedRows[0].TryToPlaceContainerInStackList(new Container(20000, ContainerVariant.Normal), 1);
            expectedRows[0].TryToPlaceContainerInStackList(new Container(10000, ContainerVariant.Normal), 1);
            expectedRows[0].TryToPlaceContainerInStackList(new Container(20000, ContainerVariant.Valuable), 1);

            expectedRows[1].TryToPlaceContainerInStackList(new Container(20000, ContainerVariant.Coolable), 0);
            expectedRows[1].TryToPlaceContainerInStackList(new Container(20000, ContainerVariant.CoolableAndValuable), 0);
            expectedRows[1].TryToPlaceContainerInStackList(new Container(20000, ContainerVariant.Normal), 1);
            expectedRows[1].TryToPlaceContainerInStackList(new Container(20000, ContainerVariant.Valuable), 1);

            foreach (var row in expectedRows)
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


            Assert.IsTrue(expectedRows.SequenceEqual(rows, new RowEqualityComparer()));
        }


        [TestMethod]
        public void Check_If_Sorting_Works_In_3X3()
        {
            ship = new Ship(3, 3);
            for (int i = 0; i < ship.Width; i++)
            {
                expectedRows.Add(new Row());
                for (int j = 0; j < ship.Length; j++)
                {
                    expectedRows[i].AddEmptyStackToRow(new Stack());
                }
            }
            expectedRows[0].TryToPlaceContainerInStackList(new Container(20000, ContainerVariant.Coolable), 0);
            expectedRows[0].TryToPlaceContainerInStackList(new Container(10000, ContainerVariant.Normal), 0);
            expectedRows[0].TryToPlaceContainerInStackList(new Container(20000, ContainerVariant.CoolableAndValuable), 0);
            expectedRows[0].TryToPlaceContainerInStackList(new Container(20000, ContainerVariant.Normal), 1);
            expectedRows[0].TryToPlaceContainerInStackList(new Container(10000, ContainerVariant.Normal), 1);
            expectedRows[0].TryToPlaceContainerInStackList(new Container(20000, ContainerVariant.Valuable), 1);
            expectedRows[0].TryToPlaceContainerInStackList(new Container(20000, ContainerVariant.Normal), 2);
            expectedRows[0].TryToPlaceContainerInStackList(new Container(20000, ContainerVariant.Valuable), 1);

            expectedRows[1].TryToPlaceContainerInStackList(new Container(20000, ContainerVariant.Coolable), 0);
            expectedRows[1].TryToPlaceContainerInStackList(new Container(20000, ContainerVariant.CoolableAndValuable), 0);
            expectedRows[1].TryToPlaceContainerInStackList(new Container(20000, ContainerVariant.Normal), 1);
            expectedRows[1].TryToPlaceContainerInStackList(new Container(10000, ContainerVariant.Normal), 2);

            expectedRows[2].TryToPlaceContainerInStackList(new Container(20000, ContainerVariant.Coolable), 0);
            expectedRows[2].TryToPlaceContainerInStackList(new Container(10000, ContainerVariant.Normal), 0);
            expectedRows[2].TryToPlaceContainerInStackList(new Container(20000, ContainerVariant.CoolableAndValuable), 0);
            expectedRows[2].TryToPlaceContainerInStackList(new Container(20000, ContainerVariant.Normal), 1);
            expectedRows[2].TryToPlaceContainerInStackList(new Container(10000, ContainerVariant.Normal), 1);
            expectedRows[2].TryToPlaceContainerInStackList(new Container(20000, ContainerVariant.Valuable), 1);
            expectedRows[2].TryToPlaceContainerInStackList(new Container(20000, ContainerVariant.Normal), 2);
            expectedRows[2].TryToPlaceContainerInStackList(new Container(10000, ContainerVariant.Normal), 2);
            foreach (var row in expectedRows)
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

            Row rowwa = new Row();

            Assert.IsTrue(expectedRows.SequenceEqual(rows, new RowEqualityComparer()));
        }
    }
}
