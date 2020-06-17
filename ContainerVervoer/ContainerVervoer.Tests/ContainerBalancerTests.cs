using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContainerVervoer.Tests
{
    [TestClass]
    public class ContainerBalancerTests
    {
        private List<Row> rows;
        private List<Container> containers;
        [TestInitialize]
        public void Setup()
        {
            rows = new List<Row>();
            containers = new List<Container>();
        }

        [TestMethod]
        public void Check_If_Correct_Balance_Difference()
        {
            rows.Add(new Row());
            rows.Add(new Row());
            rows[0].AddEmptyStackToRow(new Stack());
            rows[1].AddEmptyStackToRow(new Stack());

            rows[0].TryToPlaceContainerInStackList(new Container(30000, ContainerVariant.Normal), 0);
            rows[0].TryToPlaceContainerInStackList(new Container(30000, ContainerVariant.Normal), 0);
            rows[1].TryToPlaceContainerInStackList(new Container(20000, ContainerVariant.Normal), 0);
            rows[1].TryToPlaceContainerInStackList(new Container(20000, ContainerVariant.Normal), 0);


            double balance = ContainerBalancer.GetBalanceDifference(rows);

            Assert.AreEqual(20, balance);
        }


        [TestMethod]
        public void Check_If_Correctly_Balanced_Even_Rows()
        {
            int containerCount = 0;
            int count = 0;
            for (int i = 0; i < 4; i++)
            {
                rows.Add(new Row());
            }

            foreach (var row in rows)
            {
                row.AddEmptyStackToRow(new Stack());
                foreach (var stack in row.Stacks)
                {
                    if (count < 2)
                    {
                        stack.TryToPlaceContainer(new Container(30000, ContainerVariant.Normal));
                        stack.TryToPlaceContainer(new Container(30000, ContainerVariant.Normal));
                        containers.Add(new Container(30000, ContainerVariant.Normal));
                        containers.Add(new Container(30000, ContainerVariant.Normal));
                        count++;
                    }
                    else
                    {
                        stack.TryToPlaceContainer(new Container(4000, ContainerVariant.Normal));
                        containers.Add(new Container(4000, ContainerVariant.Normal));
                        count++;
                    }
                }
            }


            rows = ContainerBalancer.BalanceRows(rows);
            double difference = ContainerBalancer.GetBalanceDifference(rows);

            foreach (var row in rows)
            {
                foreach (var stack in row.Stacks)
                {
                    containerCount += stack.Containers.Count;
                }
            }
            Assert.AreEqual(containers.Count, containerCount);
            Assert.AreEqual(0, difference);
        }

        [TestMethod]
        public void Check_If_Correctly_Balanced_Uneven_Rows()
        {
            int containerCount = 0;
            int count = 0;
            for (int i = 0; i < 5; i++)
            {
                rows.Add(new Row());
            }
            foreach (var row in rows)
            {
                row.AddEmptyStackToRow(new Stack());
                foreach (var stack in row.Stacks)
                {
                    if (count < 3)
                    {
                        stack.TryToPlaceContainer(new Container(30000, ContainerVariant.Normal));
                        stack.TryToPlaceContainer(new Container(30000, ContainerVariant.Normal));
                        containers.Add(new Container(30000, ContainerVariant.Normal));
                        containers.Add(new Container(30000, ContainerVariant.Normal));
                        count++;
                    }
                    else
                    {
                        stack.TryToPlaceContainer(new Container(4000, ContainerVariant.Normal));
                        stack.TryToPlaceContainer(new Container(4000, ContainerVariant.Normal));
                        containers.Add(new Container(4000, ContainerVariant.Normal));
                        containers.Add(new Container(4000, ContainerVariant.Normal));
                    }
                }
            }

            


            rows = ContainerBalancer.BalanceRows(rows);
            double difference = ContainerBalancer.GetBalanceDifference(rows);


            foreach (var row in rows)
            {
                foreach (var stack in row.Stacks)
                {
                    containerCount += stack.Containers.Count;
                }
            }
            Assert.AreEqual(containers.Count, containerCount);
            Assert.AreEqual(0, difference);
        }
    }
}
