using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace ContainerVervoer
{
    public class Stack
    {
        private List<Container> containers;

        public IReadOnlyCollection<Container> Containers
        {
            get { return containers.AsReadOnly(); }
        }

        public int MaxWeight { get; } = 150000;
        public int Weight { get; private set; }
        public int Height { get; private set; }

        public Stack()
        {
            containers = new List<Container>();
        }

        public bool TryToPlaceContainer(Container container)
        {
            if (MaxWeight > Weight + container.Weight)
            {
                if (containers.Count != 0)
                {
                    if (CanFitOnTop())
                    {
                        if (120000 > containers.Skip(1).Sum(x => x.Weight) + container.Weight)
                        {
                            AddContainer(container);
                            return true;
                        }
                    }
                }
                else
                {
                    AddContainer(container);
                    return true;
                }
            }
            return false;
        }

        private bool CanFitOnTop()
        {
            if (containers.ToArray().Last().Variant == ContainerVariant.Valuable || containers.ToArray().Last().Variant == ContainerVariant.CoolableAndValuable)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void AddContainer(Container container)
        {
            containers.Add(container);
            Weight += container.Weight;
            Height += 1;
        }

    }
}
