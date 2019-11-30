using System;
using DialogEngine;
using Errors;

namespace CharacterEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //TODO: fix this and implement
            DialogManager mgmr = new DialogManager();
            throw new ScriptNotFoundException("/src/main/badfilepath");
        }
    }
}
