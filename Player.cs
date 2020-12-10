using System;

namespace polimorfismo
{
    public abstract class Player
    {
        public virtual void correr(){
            Console.WriteLine("Correndo em velocidade 10");
        }
    }
}