using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer
{
    public class Row
    {
        private List<Stack> stacks;
        public IReadOnlyCollection<Stack> Stacks
        {
            get
            { return stacks.AsReadOnly(); }
        }

        public Row()
        {
            stacks = new List<Stack>();
        }
    }
}
