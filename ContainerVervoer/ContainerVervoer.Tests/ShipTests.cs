using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContainerVervoer.Tests
{
    [TestClass]
    public class ShipTests
    {
        private Ship ship;
        private List<Row> rows;

        [TestInitialize]
        public void Setup()
        {
            ship = new Ship(1, 1);
            rows = new List<Row>();
            rows.Add(new Row());
            rows.First().AddEmptyStackToRow(new Stack());
        }

        [TestMethod]
        public void Check_If_Weight_Isnt_Too_High()
        {
            bool succes;
            for (int i = 0; i < 5; i++)
            {
                rows.First().Stacks.First().TryToPlaceContainer(new Container(30000, ContainerVariant.Normal));
            }

            succes = ship.CheckWeightOfRowsAndAddToShip(rows);

            Assert.AreEqual(succes, true);
        }
    }
}
