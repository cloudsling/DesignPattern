namespace SingletonPattern
{
    internal class LockedSingletonClass
    {
        private static LockedSingletonClass _singletonInstance;

        private LockedSingletonClass() { }

        public static LockedSingletonClass GetInstance()
        {
            lock (_singletonInstance)
            {
                if (_singletonInstance == null)
                {
                    _singletonInstance = new LockedSingletonClass();
                }
            }

            return _singletonInstance;
        }
    }
}
