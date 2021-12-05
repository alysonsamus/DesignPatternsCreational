using System;

namespace DesignPattern
{
    public class Fighter : Character
    {
        private string _Name { get; set; }
        private int _Age { get; set; }

        public Fighter(string Name , int Age)
        {
            this.Age = _Age;
            this.Name = Name;
            Classe = "Fighter";
        }

        public override void Andar()
        {
            int speed = 100;
            Console.WriteLine("The speed Fighter is {0}",speed);
        }

        public override void Atacar()
        {
            int damage_attack = 35;
            Console.WriteLine("The attack is {0}", damage_attack);
        }

        public override void Correr()
        {
            int speed = 300;
            Console.WriteLine("The speed Fighter is {0}", speed);
        }

        public override void Defender()
        {
            int block = 50;
            Console.WriteLine("The speed Fighter is {0}", block);
        }

        public override void PegarItem(Item item)
        {
            Console.WriteLine("The {0} get item: {1}", Name, item.Name);
        }
    }
}
