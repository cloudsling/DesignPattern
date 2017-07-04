using System;
using ObserverPattern.Interface;

namespace ObserverPattern.Model
{
    public class GamePerson : Person
    {

        public GamePerson(ISubject sub) : base(sub)
        {
            _workStatus = "Working.................\"steam summer sale started, what should i buy..............\"";
        }
        public override void Update(bool current, string status)
        {
            Console.Write(status + "\t");

            if (current) Gaming();
            else Work();
        }

        public void Gaming()
        {
            Console.WriteLine("open case!!!!..............");
        }
    }
}
