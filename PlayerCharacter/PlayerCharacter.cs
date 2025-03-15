using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BasicGame.PlayerCharacter
{
    internal class PlayerCharacter
    {
        float Health { get; set; }
        float Sheild { get; set; }
        string[] Abilities { get; set; }
        string[] Buffs { get; set; }
        string[] Pets { get; set; }
        string Weapon { get; set; }
        string Helm { get; set; }
        string Body { get; set; }
        string Gauntlets { get; set; }
        string Boots { get; set; }
        float Level { get; set; }
        string Class { get; set; }
        string IconPath = "";


        protected string[] ClassList = new string[3] { "Barbarian", "Mage", "Ranger" };
        public PlayerCharacter GetGear(PlayerCharacter Player, float _level, string _class)
        {
            string _weapon;
            string _material;

            if (_level < 5)
            {
                _weapon = "Wood-";
                _material = "Leather-";
            }
            else if (_level > 5 && _level < 10)
            {
                _weapon = "Stone-";
                _material = "Chain-";
            }
            else if (_level > 10 && _level < 20)
            {
                _weapon = "Steel-";
                _material = "Steel-";
            }
            else if (_level > 20 && _level < 30)
            {
                _weapon = "Gold-";
                _material = "Gold-";
            }
            else if (_level > 30 && _level < 40)
            {
                _weapon = "Jeweled-";
                _material = "Jeweled-";
            }
            else if (_level > 40 && _level < 50)
            {
                _weapon = "Diamond-";
                _material = "Diamond-";
            }
            else
            {
                _weapon = "Amethyst-";
                _material = "Amethyst-";
            }
            IconPath = _class + "-" + _weapon + _material + ".png";
            switch (_class)
            {
                case "Barbarian": _weapon += "WarHammer"; break;
                case "Mage": _weapon += "Staff"; break;
                case "Ranger": _weapon += "Bow"; break;
            }

            string _helm = _material + "Helm";
            string _body = _material + "Armour";
            string _gauntlets = _material + "Gauntlets";
            string _boots = _material + "Boots";
            
            Player.Weapon = _weapon;
            Player.Helm = _helm;
            Player.Body = _body;
            Player.Gauntlets = _gauntlets;
            Player.Boots = _boots;
            Player.IconPath = IconPath;

            return Player;
        }
        public PlayerCharacter ArmCharacter(PlayerCharacter Player, float _health, float _sheild, string[] _abilities, string[] _buffs, string[] _pets)
        {
            Player.Health = _health;
            Player.Sheild = _sheild;
            Player.Abilities = _abilities;
            Player.Buffs = _buffs;
            Player.Pets = _pets;
            return Player;
        }
        public float GetHealth()
        {
            return Health;
        }
        public float GetSheilds()
        {
            return Sheild;
        }
        public string[] GetAbilities()
        {
            return Abilities;
        }
        public string[] GetBuffs()
        {
            return Buffs;
        }
        public string[] GetPets()
        {
            return Pets;
        }
        public string GetClass()
        {
            return Class;
        }
        public string GetModel()
        {
            return IconPath;
        }
        public void SetClass(PlayerCharacter Player, string _class)
        {
            Player.Class = _class;
        }
        public void TakeDamage(PlayerCharacter Player, float damage)
        {
            Player.Health = Player.Health - damage;
        }
    }
}
