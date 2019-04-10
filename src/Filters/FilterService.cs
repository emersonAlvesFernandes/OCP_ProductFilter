using System.Collections.Generic;
using OCP_Filters.Specifications;

namespace OCP_Filters.Filters
{
    public class FilterService : IFilter<Product>
    {        
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            foreach (var item in items)
                if (spec.IsSatisfied(item))
                    yield return item;
        }
    }
}