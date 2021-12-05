using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    class Mage : Character
    {

        private string _Name { get; set; }
        private int _Age { get; set; }
        
        public Mage(string Name, int Age)
        {
            this.Age = _Age;
            this.Name = _Name;
            Classe = "Mage";
        }
        public override void Andar()
        {
            int speed = 150;
            Console.WriteLine("The speed Mage is {0}", speed);
        }

        public override void Atacar()
        {
            int damage_attack = 75;
            Console.WriteLine("The attack is {0}", damage_attack);
        }

        public override void Correr()
        {
            int speed = 350;
            Console.WriteLine("The speed Fighter is {0}", speed);
        }

        public override void Defender()
        {
            int block = 15;
            Console.WriteLine("The speed Fighter is {0}", block);
        }

        public override void PegarItem(Item item)
        {
            Console.WriteLine("The {0} get item: {1}", Name, item.Name);
        }
    }
}
