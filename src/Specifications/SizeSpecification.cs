namespace OCP_Filters.Specifications{
    public class SizeSpecification : ISpecification<Product>
    {
        private Size _Size;
        public SizeSpecification(Size size)
        {
            _Size = size;
        }
        public bool IsSatisfied(Product p)
        {
            return p.Size == _Size;
        }
    }
}