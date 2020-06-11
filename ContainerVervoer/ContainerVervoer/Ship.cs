using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer
{
    public class Ship
    {
        private List<Row> rowsLeft;
        public IReadOnlyCollection<Row> RowsLeft
        {
            get
            { return rowsLeft.AsReadOnly(); }
        }
        private List<Row> rowsRight;
        public IReadOnlyCollection<Row> RowsRight
        {
            get
            { return rowsRight.AsReadOnly(); }
        }

        public Row rowMiddle { get; private set; }

        public int Width { get; private set; }
        public int Length { get; private set; }
        public int MaxWeight => Length * Width * 150000;
        public double MinWeight => 0.5 * MaxWeight;


        public Ship(int width, int length)
        {
            Width = width;
            Length = length;
            rowsLeft = new List<Row>();
            rowsRight = new List<Row>();
            if (width % 2 == 1)
            {
                rowMiddle = new Row();
            }

        }

        private void AddLeftRowsToShip(List<Row> rows)
        {
            rowsLeft.AddRange(rows);
        }

        private void AddRightRowsToShip(List<Row> rows)
        {
            rowsRight.AddRange(rows);
        }

        private void AddMiddleRowToShip(Row row)
        {
            rowMiddle = row;
        }

        public bool CheckWeightOfRowsAndAddToShip(List<Row> rowsLeft, List<Row> rowsRight)
        {
            int weight = 0;
            for (int i = 0; i < rowsLeft.Count; i++)
            {
                weight += rowsLeft[i].GetRowWeight();
                weight += rowsRight[i].GetRowWeight();
            }

            if (weight > MaxWeight)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool CheckWeightOfRowsAndAddToShip(List<Row> rowsLeft, List<Row> rowsRight, Row rowMiddle)
        {
            int weight = 0;
            for (int i = 0; i < rowsLeft.Count; i++)
            {
                weight += rowsLeft[i].GetRowWeight();
                weight += rowsRight[i].GetRowWeight();
            }

            weight += rowMiddle.GetRowWeight();
            if (weight > MaxWeight)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
