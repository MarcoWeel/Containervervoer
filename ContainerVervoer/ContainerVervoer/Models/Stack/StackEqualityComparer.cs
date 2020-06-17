using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer.Models
{
    public class StackEqualityComparer : IEqualityComparer<Stack>
    {
        public bool Equals(Stack x, Stack y)
        {
            if (Object.ReferenceEquals(x, y)) return true;

            if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null))
                return false;

            return x.Containers.SequenceEqual(y.Containers, new ContainerEqualityComparer());
        }

        public int GetHashCode(Stack stack)
        {
            if (Object.ReferenceEquals(stack.Containers, null)) return 0;
            int hashStackMaxWeight = stack.MaxWeight.GetHashCode();
            int hashStackWeight = stack.Weight.GetHashCode();
            int hashStackHeight = stack.Height.GetHashCode();
            int hashStackContainers = stack.Containers.GetHashCode();
            return hashStackMaxWeight ^ hashStackHeight ^ hashStackWeight ^ hashStackContainers;
        }
    }
}
