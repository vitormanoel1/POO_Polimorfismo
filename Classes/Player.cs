using System;

namespace Atividades16.Classes
{
    public abstract class Player
    {
        public virtual void Correr()
        {
            Console.WriteLine("correndo na velocidade 5x");
        }

        public virtual void Pulo()
        {
            Console.WriteLine("força do pulo 10");
        }
    }
}