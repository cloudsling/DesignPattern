﻿using System;
using ObserverPattern.Interface;

namespace ObserverPattern.Model
{
   public  class ShopPerson : Person
    {
        public ShopPerson(ISubject sub) : base(sub)
        {
            _workStatus = "Working.................\"That Notebook seems on sale..............\"";
        }

        public override void Update(bool current, string status)
        {
            Console.Write(status + "\t");

            if (current) Shopping();
            else Work();
        }

        public void Shopping()
        {
            Console.WriteLine("Shopping.................");
        }
    }
}
