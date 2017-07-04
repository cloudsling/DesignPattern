using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Observer.Interface;

namespace DesignPattern.Observer.Model
{
    public class LazyPerson : Person
    {
        public LazyPerson(ISubject sub) : base (sub)
        {
            _workStatus = "Working.................\"Orz...............\"";
        }
        public override void Update(bool current, string status)
        {
            Console.Write(status + "\t");

            if (current) Lazying();
            else Work();
        }

        public void Lazying()
        {
            Console.WriteLine("Boss is leave, I can sleep for a while.......\r\n");
        }
    }
}
