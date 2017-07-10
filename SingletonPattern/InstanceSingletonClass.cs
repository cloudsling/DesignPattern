namespace SingletonPattern
{
    internal class InstanceSingletonClass
    {
        private static readonly InstanceSingletonClass SingletonInstance = new InstanceSingletonClass();

        private InstanceSingletonClass() { }

        public static InstanceSingletonClass GetInstance() => SingletonInstance;
    }
}
