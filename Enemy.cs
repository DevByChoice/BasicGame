﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicGame
{
    internal class Enemy
    {
        protected int ID { get; set; }
        protected string Name { get; set; }
        protected float HP { get; set; }
        protected float Damage { get; set; }
        string State { get; set; }
        string[] Path { get; set; }
        public string[] GetPath(string ID, string state)
        {
            switch(ID)
            {
                case "1": break; 
                case "2": break;
                default: break;
            }
                return Path;
        }
        public float Attack(float damage, float shield, float damageReduction)
        {
            float impact = 0;
            damage = (damage / 100) * damageReduction;
            if (damage < shield) { impact = 0; }
            else if (damage < 1) { impact = 0; }
            else { impact = shield - damage; }
            return impact;
        }
    }
}
