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
<<<<<<< HEAD
            QuantityLife += number;
            Console.WriteLine ($"{Name} se ha curado. Su vida acutal es: {QuantityLife}");
=======
            QuantityLife += Quantity;
            Console.WriteLine($"Se ha curado a {Name}, su estado de vida actual es {QuantityLife}");
>>>>>>> 3e257014557c023b7a387082c76d654037878cd3
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