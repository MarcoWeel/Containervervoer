using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer
{
    public class Stack
    {
        private List<Container> containers;
        public IReadOnlyCollection<Container> Containers
        {
            get
            { return containers.AsReadOnly(); }
        }

        public int MaxWeight { get; } = 150000;

        public Stack()
        {
            containers = new List<Container>();
        }
    }
}
