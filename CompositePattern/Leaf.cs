namespace CompositePattern
{
    internal class Leaf : Component
    {
        internal override void Add(Component c)
        {
            throw new System.InvalidOperationException();
        }

        internal override void Remove(Component c)
        {
            throw new System.InvalidOperationException();
        }

        internal override void Operation(Component c)
        {
            // Operation here
        }
    }
}
