using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonTraits.Enums;

namespace CommonTraits.Classes
{
    public class Being : TheForce
    {
        public string Name { get; private set; }
        public Races Race { get; set; }

        public Being(string name, Races race, int midichlorians) : base(midichlorians)
        {
            Name = name;
            Race = race;
        }

        protected sealed override void AddForce(Force force)
        {
            if(!Forces.Contains(force))
            Forces.Add(force);
        }

        public override string WhatAreYou(Being suspect)
        {
            if (suspect == null)
                return "I don't exist";
            else if (suspect.Forces.Contains(Force.DarkSide) &&
                Forces.Contains(Force.DarkSide))
                return "I'm a Sith";
            else if (suspect.Forces.Contains(Force.LightSide))
                return "I'm a Jedi";

            return "I'm neither Sith nor Jedi";
        }

        public virtual string AreYouSith(Being suspect)
        {
            return "I'm not a Sith";
        }
    }
}
