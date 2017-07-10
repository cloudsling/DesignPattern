namespace SingletonPattern
{
    internal class SingletonClass
    {
        private static SingletonClass _singletonInstance;

        private SingletonClass() { }

        public static SingletonClass GetInstance()
        {
            if (_singletonInstance == null)
            {
               _singletonInstance = new SingletonClass();
            }

            return _singletonInstance;
        }
    }
}
