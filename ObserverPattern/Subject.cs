using System.Collections.Generic;
using ObserverPattern.Interface;

namespace ObserverPattern
{
    public class Subject : ISubject
    {
        public Subject()
        {
            _obs = new List<IObserver>();
        }

        private readonly IList<IObserver> _obs;

        private string _status;
        private bool _ifBossLeave;

        public void AddObserverToList(IObserver o)
        {
            _obs.Add(o);
        }

        public void RemoveObserverFormList(IObserver o)
        {
            if (_obs.Contains(o))
            {
                _obs.Remove(o);
            }
        }

        public void NotifyAllObservers()
        {
            foreach (var observer in _obs)
            {
                observer.Update(_ifBossLeave, _status);
            }
        }

        public void StatusChanged(bool ifBossLeave, string status)
        {
            _ifBossLeave = ifBossLeave;
            _status = status;
            NotifyAllObservers();
        }
    }

    public class BossStatus
    {
        public static bool Leave { get; } = true;

        public static bool Back { get; } = false;
    }
}
