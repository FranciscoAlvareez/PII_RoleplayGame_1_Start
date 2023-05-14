using System;

namespace Library
{
    public class Dwarves
    {
        public string Name {get; set;}
        public int QuantityLife {get; set;}

        
        public Dwarves(string name, int life) 
        {
            this.Name = name;
            this.QuantityLife = life;
        }

        public void Cure(int Quantity) 
        {
            QuantityLife += Quantity;
            Console.WriteLine ($"{Name} se ha curado. Su vida acutal es: {QuantityLife}");
        }

        public void Attack()
        {
            Console.WriteLine($"{Name} ataca");
        }
    }
}

//Esto iría en el Program:
//Dwarves Enano = new Dwarves("Enano", 100);
//Enano.Attack();
//Enano.Cure(20);