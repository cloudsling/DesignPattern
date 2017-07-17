namespace BuilderPattern
{
    internal class ConcreteBuilderA : Builder
    {
        private readonly Product _product = new Product();

        internal override void BuildPartA()
        {
            _product.TypeA = "A1";
        }

        internal override void BuildPartB()
        {
            _product.TypeB = "B1";
        }

        internal override Product GetResult()
        {
            return _product;
        }
    }
}
