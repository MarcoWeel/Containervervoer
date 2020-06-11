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

        public void AddStackToRow(Stack stack)
        {
            this.stacks.Add(stack);
        }

        public bool PlaceContainerInStackList(Container container, int index)
        {
            return stacks[index].TryToPlaceContainer(container);
        }

        public int GetRowWeight()
        {
            int weight = 0;
            foreach (var stack in stacks)
            {
                weight += stack.StackWeight;
            }

            return weight;
        }
    }
}
