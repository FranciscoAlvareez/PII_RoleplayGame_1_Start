using System;

namespace RoleplayGame
{
    public class Dwarves
    {
        public string Name {get; set;}

        public int health {get; set;}

        //public int QuantityLife {get; set;}

        
        public Dwarves(string name) 
        {
            this.Name = name;
        }

        public void Cure(int number) 
        {
            health += number;
            Console.WriteLine ($"{Name} se ha curado. Su vida acutal es: {health}");


            QuantityLife += number;
            Console.WriteLine ($"{Name} se ha curado. Su vida acutal es: {QuantityLife}");

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