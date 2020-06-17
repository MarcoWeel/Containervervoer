using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer.Models
{
    public class RowEqualityComparer : IEqualityComparer<Row>
    {
        public bool Equals(Row x, Row y)
        {
            bool isEqual = true;
            if (Object.ReferenceEquals(x, y)) return true;

            if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null))
                return false;
            return x.Stacks.SequenceEqual(y.Stacks, new StackEqualityComparer());


        }

        public int GetHashCode(ContainerVervoer.Row row)
        {
            if (Object.ReferenceEquals(row.Stacks, null)) return 0;
            int hashRowStacks = row.Stacks.GetHashCode();
            int hashRowWeight = row.GetRowWeight().GetHashCode();
            int hashRowMinHeight = row.GetMinRowHeight().GetHashCode();
            return hashRowStacks ^ hashRowMinHeight ^ hashRowWeight;
        }
    }
}
