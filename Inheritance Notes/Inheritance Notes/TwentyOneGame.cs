﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Notes
{
    public class TwentyOneGame : Game, IWalkAway
    {
        public override void Play()
        {
            throw new NotImplementedException(); //use this if you have no implementation yet or specific play function
        }

        public override void Listplayers()
        {
            Console.WriteLine("21 Players: ");
            base.Listplayers();
        }

        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
