using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Models
{
    public class Space
    {
        public Space(int number)
        {
            Number = number;
        }
        public int Number { get; set; }

        public virtual void Act(Player player)
        {
            Console.WriteLine($"{Number}: Space test");
        }
    }
}
