using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer
{
    public static class ListSorter
    {
        private static List<Container> SortContainersByWeight(List<Container> containers)
        {
           return new List<Container>(containers.OrderByDescending(x => x.Weight));
        }

        public static List<Container> GetCoolableContainers(List<Container> containers)
        {
            return new List<Container>(SortContainersByWeight(containers).Where(x=> x.Variant == ContainerVariant.Coolable));
        }

        public static List<Container> GetNormalContainers(List<Container> containers)
        {
            return new List<Container>(SortContainersByWeight(containers).Where(x => x.Variant == ContainerVariant.Normal));
        }

        public static List<Container> GetValuableContainers(List<Container> containers)
        {
            return new List<Container>(SortContainersByWeight(containers).Where(x => x.Variant == ContainerVariant.Valuable));
        }

        public static List<Container> GetCoolableAndValuableContainers(List<Container> containers)
        {
            return new List<Container>(SortContainersByWeight(containers).Where(x => x.Variant == ContainerVariant.CoolableAndValuable));
        }
    }
}
