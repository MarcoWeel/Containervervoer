using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer
{
    public class Container
    {
        public int Weight { get; private set; }
        public int MaxWeight { get; } = 30000;
        public int MinWeight { get; } = 4000;
        public ContainerVariants Variant { get; private set; }

        public Container(int weight, ContainerVariants variant)
        {
            Weight = weight;
            Variant = variant;
        }
    }
}
