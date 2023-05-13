using System;

namespace RoleplayGame
{
    public class Dwarves
    {
        public string Name {get; set;}
        public int health {get; set;}

        
        public Dwarves(string name, int life)
        {
            this.Name = name;
            this.health = life;
        }

        public void Cure(int number)
        {
            health += number;
            Console.WriteLine ($"{Name} se ha curado. Su vida acutal es: {health}");
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