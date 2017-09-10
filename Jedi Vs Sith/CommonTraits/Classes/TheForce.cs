using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonTraits.Enums;

namespace CommonTraits.Classes
{
    public abstract class TheForce
    {
        public List<Force> Forces { get; private set; }
        public int Midichlorians { get; private set; }

        public TheForce(int midichlorians)
        {
            Midichlorians = midichlorians;
            Forces = new List<Force>();

        }

        public abstract string WhatAreYou(Being suspect);

        protected virtual void AddForce(Force force)
        {
            Forces.Add(force);
        }
    }
}
