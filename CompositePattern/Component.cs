namespace CompositePattern
{
    internal abstract class Component
    {
        internal abstract void Add(Component c);

        internal abstract void Remove(Component c);

        internal abstract void Operation(Component c);
    }
}
