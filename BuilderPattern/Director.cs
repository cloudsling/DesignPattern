namespace BuilderPattern
{
    internal class Director
    {

        internal Product Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();

            return builder.GetResult();
        }
    }
}
