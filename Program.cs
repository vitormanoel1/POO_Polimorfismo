using System;
using Atividades16.Classes;

namespace Atividades16
{
    class Program
    {
        static void Main(string[] args)
        {
            MegaMan mega = new MegaMan();
            mega.Correr();

            Zero zero = new Zero();
            zero.Pulo();
        }
    }
}
