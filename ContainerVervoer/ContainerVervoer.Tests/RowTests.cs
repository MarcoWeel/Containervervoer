using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ContainerVervoer;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ContainerVervoer.Tests
{
    [TestClass]
    public class RowTests
    {
        private Row row;

        [TestInitialize]
        public void Setup()
        {
            row = new Row();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Can_Only_Add_Empty_Stacks()
        {
            Stack stack = new Stack();
            stack.TryToPlaceContainer(new Container(4000, ContainerVariant.Normal));

            row.AddEmptyStackToRow(stack);

            Assert.ThrowsException<ArgumentException>(() => row.AddEmptyStackToRow(stack));
        }

        [TestMethod]
        public void Can_Place_Containers_In_Empty_Stack_In_Row_With_Multiple_Stacks()
        {
            row.AddEmptyStackToRow(new Stack());
            row.AddEmptyStackToRow(new Stack());
            row.AddEmptyStackToRow(new Stack());

            row.TryToPlaceContainerInStackList(new Container(4000, ContainerVariant.Normal), 0);
            row.TryToPlaceContainerInStackList(new Container(4000, ContainerVariant.Normal), 0);
            row.TryToPlaceContainerInStackList(new Container(4000, ContainerVariant.Valuable), 0);

            row.TryToPlaceContainerInStackList(new Container(4000, ContainerVariant.Normal), 1);
            row.TryToPlaceContainerInStackList(new Container(4000, ContainerVariant.Normal), 1);
            row.TryToPlaceContainerInStackList(new Container(4000, ContainerVariant.Valuable), 1);

            row.TryToPlaceContainerInStackList(new Container(4000, ContainerVariant.Normal), 2);
            row.TryToPlaceContainerInStackList(new Container(4000, ContainerVariant.Normal), 2);
            row.TryToPlaceContainerInStackList(new Container(4000, ContainerVariant.Valuable), 2);

            Assert.AreEqual(3, row.Stacks.First().Containers.Count);
            Assert.AreEqual(2, row.Stacks.ElementAt(1).Containers.Count);
            Assert.AreEqual(3, row.Stacks.ElementAt(2).Containers.Count);
            Assert.AreEqual(ContainerVariant.Valuable, row.Stacks.First().Containers.Last().Variant);
            Assert.AreEqual(ContainerVariant.Normal, row.Stacks.ElementAt(1).Containers.Last().Variant);
            Assert.AreEqual(ContainerVariant.Valuable, row.Stacks.ElementAt(2).Containers.Last().Variant);
        }

        [TestMethod]
        public void Get_Correct_Minimal_Row_Height()
        {
            row.AddEmptyStackToRow(new Stack());
            row.AddEmptyStackToRow(new Stack());
            row.TryToPlaceContainerInStackList(new Container(4000, ContainerVariant.Normal), 0);
            row.TryToPlaceContainerInStackList(new Container(4000, ContainerVariant.Normal), 0);
            row.TryToPlaceContainerInStackList(new Container(4000, ContainerVariant.Normal), 1);
            int expectedHeight = 1;

            int height = row.GetMinRowHeight();

            Assert.AreEqual(expectedHeight, height);
        }

        [TestMethod]
        public void Get_Correct_Row_Weight()
        {
            row.AddEmptyStackToRow(new Stack());
            row.TryToPlaceContainerInStackList(new Container(30000, ContainerVariant.Normal), 0);
            row.TryToPlaceContainerInStackList(new Container(15000, ContainerVariant.Normal), 0);
            int expectedWeight = 45000;

            int weight = row.GetRowWeight();

            Assert.AreEqual(expectedWeight, weight);
        }

        [TestMethod]
        public void Try_And_Sort_Containers_By_Height_Without_Coolable_Containers()
        {
            row.AddEmptyStackToRow(new Stack());
            row.AddEmptyStackToRow(new Stack());
            row.TryToPlaceContainerInStackList(new Container(30000, ContainerVariant.Normal), 0);
            row.TryToPlaceContainerInStackList(new Container(15000, ContainerVariant.Normal), 0);
            row.TryToPlaceContainerInStackList(new Container(30000, ContainerVariant.Normal), 1);

            row.SortStacksByHeight();

            Assert.AreEqual(2, row.Stacks.ElementAt(0).Height);
            Assert.AreEqual(1, row.Stacks.ElementAt(1).Height);
        }

        [TestMethod]
        public void Try_And_Sort_Containers_By_Height_With_Coolable_Containers()
        {
            row.AddEmptyStackToRow(new Stack());
            row.AddEmptyStackToRow(new Stack());
            row.TryToPlaceContainerInStackList(new Container(30000, ContainerVariant.Normal), 0);
            row.TryToPlaceContainerInStackList(new Container(15000, ContainerVariant.Normal), 0);
            row.TryToPlaceContainerInStackList(new Container(30000, ContainerVariant.Coolable), 1);

            row.SortStacksByHeight();

            Assert.AreEqual(1, row.Stacks.ElementAt(0).Height);
            Assert.AreEqual(2, row.Stacks.ElementAt(1).Height);
        }
    }
}
