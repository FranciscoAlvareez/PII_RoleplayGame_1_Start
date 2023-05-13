using System;

namespace Library
{
    public class Dwarves
    {
        public string Name {get; set;}
        public int Life {get; set;}

        
        public Dwarves(string name, int life)
        {
            this.Name = name;
            this.Life = life;
        }

        public void Cure(int Quantity) 
        {
            QuantityLife += Quantity;
            Console.WriteLine($"Se ha curado a {Name}, su estado de vida actual es {QuantityLife}");
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