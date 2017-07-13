namespace TemplateMethodPattern
{
    internal abstract class AbstractClass
    {
        protected void TemplateMethod()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
            if (Hook())
                ConcreteOperation();
        }

        protected abstract void PrimitiveOperation1();

        protected abstract void PrimitiveOperation2();

        internal void ConcreteOperation()
        {
            // Concrete Method
        }

        protected virtual bool Hook()
        {
            return true;
        }
    }
}
