namespace OCP_Filters.Specifications{
    public class ColorSpecification : ISpecification<Product>
    {
        private Color _Color;
        public ColorSpecification(Color color)
        {
            _Color = color;
        }
        public bool IsSatisfied(Product p)
        {
            return p.Color == _Color;
        }
    }
}