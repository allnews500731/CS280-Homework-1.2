using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS280_Homework_1._2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon pokemon = new Pokemon();
            pokemon.Height = 2.0f;
            pokemon.Weight = 12.7f;
            pokemon.Category = "LIzard";
            pokemon.Abilities = "Blaze";
            pokemon.Gender = "M";
            pokemon.ID = "C001";
            pokemon.SName = "Henry Chen";
            Console.WriteLine("身高:{0}公尺, 體重:{1}磅",
                pokemon.Height, pokemon.Weight);
        }
    }
}