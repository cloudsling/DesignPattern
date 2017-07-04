using System.Threading;
using ObserverPattern.Model;

namespace ObserverPattern
{
    public class ObserverDelegator 
    { 
        public static void DelegateMainMethod()
        {
            Subject subject = new Subject();

            Person gamePerson = new GamePerson(subject);
            Person shopPerson = new ShopPerson(subject);
            Person lazyPerson = new LazyPerson(subject);

            subject.StatusChanged(BossStatus.Leave, "Boss has gone!!!");
            Thread.Sleep(2000);
            subject.StatusChanged(BossStatus.Back, "Boss is back!!!");
        }
    }
}
