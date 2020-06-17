using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer.Models
{
    public class ContainerEqualityComparer : IEqualityComparer<Container>
    {
        public bool Equals(Container x, Container y)
        {
            if (Object.ReferenceEquals(x, y)) return true;

            if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null))
                return false;

            return x.Weight == y.Weight && x.Variant == y.Variant;
        }

        public int GetHashCode(Container container)
        {
            if (Object.ReferenceEquals(container, null)) return 0;
            int hashContainerWeight = container.Weight.GetHashCode();
            int hashContainerType = container.Variant.GetHashCode();
            return hashContainerWeight ^ hashContainerType;
        }
    }
}
