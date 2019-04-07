using System.Collections.Generic;
using OCP_Filters.Specifications;

namespace OCP_Filters.Filters
{
    public class FilterService : IFilter<Product>
    {        
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            foreach (var i in items)
                if (spec.IsSatisfied(i))
                    yield return i;
        }
    }
}