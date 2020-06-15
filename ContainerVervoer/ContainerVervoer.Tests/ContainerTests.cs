using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContainerVervoer.Tests
{
    [TestClass]
    public class ContainerTests
    {

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Check_If_Unable_To_Create_Container_Smaller_Than_Min_Weight()
        {

            Container container = new Container(2000, ContainerVariant.Normal);

            Assert.ThrowsException<ArgumentException>(() => new Container(2000, ContainerVariant.Normal));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Check_If_Unable_To_Create_Container_Larger_Than_Max_Weight()
        {

            Container container = new Container(31000, ContainerVariant.Normal);

            Assert.ThrowsException<ArgumentException>(() => new Container(2000, ContainerVariant.Normal));
        }
    }
}
