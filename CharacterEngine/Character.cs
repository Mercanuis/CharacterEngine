using System;
using DialogEngine;
using Errors;

namespace CharacterEngine
{
    class Character
    {
        Attribute attributes;

        public Character()
        {
            attributes = new Attribute(10, 10, 10, 10, 10, 10);
        }
        static void Main(string[] args)
        {
            throw new NotImplementedException();
        }
    }

    struct Attribute
    {
        public Attribute(int str, int dex, int con, int intel, int wis, int chr)
        {
            Strength = str;
            Dexterity = dex;
            Constitution = con;
            Intelligence = intel;
            Wisdom = wis;
            Charisma = chr;
        }

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
    }
}
