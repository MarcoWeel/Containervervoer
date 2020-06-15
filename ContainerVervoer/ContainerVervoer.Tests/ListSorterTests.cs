using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContainerVervoer.Tests
{
    [TestClass]
    public class ListSorterTests
    {
        private List<Container> containers;
        private List<Container> sortedcontainers;
        [TestInitialize]
        public void Setup()
        {
            containers = new List<Container>();
            sortedcontainers = new List<Container>();
            for (int i = 0; i < 4; i++)
            {
                containers.Add(new Container(4000, ContainerVariant.Coolable));
                containers.Add(new Container(5000, ContainerVariant.Normal));
                containers.Add(new Container(6000, ContainerVariant.Normal));
                containers.Add(new Container(7000, ContainerVariant.CoolableAndValuable));
                containers.Add(new Container(8000, ContainerVariant.Valuable));
            }
        }


        [TestMethod]
        public void Check_If_List_Only_Contains_Coolable()
        {
            bool allCorrectType = true;

            sortedcontainers = ListSorter.GetCoolableContainers(containers);
            foreach (var container in sortedcontainers)
            {
                if (container.Variant != ContainerVariant.Coolable)
                {
                    allCorrectType = false;
                }
            }

            Assert.AreEqual(4, sortedcontainers.Count);
            Assert.AreEqual(true, allCorrectType);
        }

        [TestMethod]
        public void Check_If_List_Only_Contains_Normal()
        {
            bool allCorrectType = true;

            sortedcontainers = ListSorter.GetNormalContainers(containers);
            foreach (var container in sortedcontainers)
            {
                if (container.Variant != ContainerVariant.Normal)
                {
                    allCorrectType = false;
                }
            }

            Assert.AreEqual(8, sortedcontainers.Count);
            Assert.AreEqual(true, allCorrectType);
        }

        [TestMethod]
        public void Check_If_List_Only_Contains_Valuable()
        {
            bool allCorrectType = true;

            sortedcontainers = ListSorter.GetValuableContainers(containers);
            foreach (var container in sortedcontainers)
            {
                if (container.Variant != ContainerVariant.Valuable)
                {
                    allCorrectType = false;
                }
            }

            Assert.AreEqual(4, sortedcontainers.Count);
            Assert.AreEqual(true, allCorrectType);
        }

        [TestMethod]
        public void Check_If_List_Only_Contains_Valuable_And_Coolable()
        {
            bool allCorrectType = true;

            sortedcontainers = ListSorter.GetCoolableAndValuableContainers(containers);
            foreach (var container in sortedcontainers)
            {
                if (container.Variant != ContainerVariant.CoolableAndValuable)
                {
                    allCorrectType = false;
                }
            }

            Assert.AreEqual(4, sortedcontainers.Count);
            Assert.AreEqual(true, allCorrectType);
        }
    }
}
