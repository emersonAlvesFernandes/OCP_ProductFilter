namespace OCP_Filters.Specifications
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(Product p);
    }

}