namespace TemplateMethodPattern
{
    internal class ConcreteClass1 : AbstractClass
    {
        protected override void PrimitiveOperation1()
        {
            // Some Work here
        }

        protected override void PrimitiveOperation2()
        {
            // Some work here
        }

        protected override bool Hook()
        {
            if (SomeOperation())
            {
                return false;
            }
            return true;
        }

        private bool SomeOperation() => false;
    }

}
