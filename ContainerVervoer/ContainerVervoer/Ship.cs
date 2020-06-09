using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer
{
    class Ship
    {
        private List<Row> rows;
        public IReadOnlyCollection<Row> Rows
        {
            get
            { return rows.AsReadOnly(); }
        }
        public int Width { get; private set; }
        public int Length { get; private set; }
        public int MaxWeight => Length * Width * 150000;
        public double MinWeight  => 0.5 * MaxWeight;


        public Ship(int width, int length)
        {
            Width = width;
            Length = length;
            rows = new List<Row>(Length);                       
        }
    }

}
