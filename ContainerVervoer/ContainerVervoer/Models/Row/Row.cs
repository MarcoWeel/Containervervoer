using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public void AddEmptyStackToRow(Stack stack)
        {
            if (stack.Containers.Count != 0)
            {
                throw new ArgumentException("Cannot place stack with containers");
            }
            stacks.Add(stack);
        }

        public bool TryToPlaceContainerInStackList(Container container, int index)
        {
            if (container.Variant == ContainerVariant.Valuable)
            {
                if (CheckIfReachable(index, stacks[index].Height))
                {
                    if (CheckIfOtherStillReachable(index))
                    {
                        return stacks[index].TryToPlaceContainer(container);
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return stacks[index].TryToPlaceContainer(container);
            }

        }

        public bool TryToPlaceContainerInStackList(Container container, int index, bool isAlreadyChecking)
        {
            if (isAlreadyChecking)
            {
                if (CheckIfReachable(index, stacks[index].Height))
                {
                    return stacks[index].TryToPlaceContainer(container);
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        public int GetRowWeight()
        {
            int weight = 0;
            foreach (var stack in stacks)
            {
                weight += stack.Weight;
            }

            return weight;
        }

        public int GetMinRowHeight()
        {
            int minHeight = 100;
            foreach (var stack in stacks)
            {
                if (stack.Height < minHeight)
                {
                    minHeight = stack.Height;
                }
            }

            return minHeight;
        }

        private bool CheckIfReachable(int index, int height)
        {
            int maxStackHeightFront = 0;
            int maxStackHeightBehind = 0;
            if (index == stacks.Count - 1)
            {
                return true;
            }
            else if (index == 0)
            {
                return true;
            }
            else
            {
                for (int i = 0; i < index + 1; i++)
                {
                    if (stacks[i].Height > maxStackHeightFront)
                    {
                        maxStackHeightFront = stacks[i].Height;
                    }
                }

                if (index != stacks.Count)
                {
                    for (int i = stacks.Count - 1; i >= index; i--)
                    {
                        if (stacks[i].Height > maxStackHeightBehind)
                        {
                            maxStackHeightBehind = stacks[i].Height;
                        }
                    }
                }

                if (maxStackHeightBehind <= height || maxStackHeightFront <= height)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private bool CheckIfOtherStillReachable(int index)
        {
            bool hasValuable = false;
            foreach (var stack in stacks)
            {
                foreach (var container in stack.Containers)
                {
                    if (container.Variant == ContainerVariant.CoolableAndValuable || container.Variant == ContainerVariant.Valuable)
                    {
                        hasValuable = true;
                    }
                }
            }

            if (hasValuable)
            {
                bool isStillReachable = true;
                Row tempRow = new Row();

                foreach (var stack in stacks)
                {
                    tempRow.AddEmptyStackToRow(new Stack());
                    foreach (var container in stack.Containers)
                    {
                        tempRow.Stacks.Last().TryToPlaceContainer(new Container(container.Weight, container.Variant));
                    }

                }
                List<int> stackIndexes = new List<int>();
                List<int> stackHeights = new List<int>();
                for (int i = 0; i < stacks.Count; i++)
                {
                    for (int j = 0; j < stacks[i].Containers.Count; j++)
                    {
                        if (stacks[i].Containers.ElementAt(j).Variant == ContainerVariant.Valuable || stacks[i].Containers.ElementAt(j).Variant == ContainerVariant.CoolableAndValuable)
                        {
                            stackIndexes.Add(i);
                            stackHeights.Add(stacks[i].Height);
                        }
                    }
                }

                for (int i = 0; i < stackIndexes.Count; i++)
                {
                    tempRow.Stacks.ElementAt(stackIndexes[i]).RemoveLastContainer();
                }

                tempRow.Stacks.ElementAt(index).TryToPlaceContainer(new Container(4000, ContainerVariant.Valuable));
                for (int i = 0; i < stackIndexes.Count; i++)
                {
                    bool isplaced = tempRow.TryToPlaceContainerInStackList(new Container(4000, ContainerVariant.Valuable), stackIndexes[i], true);
                    if (isplaced == false)
                    {
                        isStillReachable = false;
                    }
                }


                return isStillReachable;
            }
            else
            {
                return true;
            }
        }

        public void SortStacksByHeight()
        {
            bool hasCoolable = false;
            foreach (var stack in Stacks)
            {
                foreach (var container in stack.Containers)
                {
                    if (container.Variant == ContainerVariant.Coolable || container.Variant == ContainerVariant.CoolableAndValuable)
                    {
                        hasCoolable = true;
                    }
                }
            }

            if (hasCoolable)
            {
                stacks = stacks.Take(1).Concat(stacks.Skip(1).OrderByDescending(x => x.Height)).ToList();
            }
            else
            {
                stacks = stacks.OrderByDescending(x => x.Height).ToList();
            }
        }
    }
}
