using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public abstract class Character
    {
        public string Classe { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public enum Sex { Male, Female }
        public enum Size
        {
            Low,
            Mid,
            High
        }
        public abstract void Andar();
        public abstract void Correr();
        public abstract void Defender();
        public abstract void Atacar();
        public abstract void PegarItem(Item item);


    }
}
