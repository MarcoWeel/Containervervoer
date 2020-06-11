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
        public ContainerVariant Variant { get; private set; }

        public Container(int weight, ContainerVariant variant)
        {
            Weight = weight;
            Variant = variant;
        }

        public override string ToString()
        {
            return $"Variant: {Variant}, Weight: {Weight}";
        }
    }
}
