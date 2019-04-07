using System.Collections.Generic;
using OCP_Filters.Specifications;

namespace OCP_Filters.Filters
{

    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }
}