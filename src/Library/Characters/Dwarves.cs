using System;

namespace RoleplayGame
{
    public class Dwarves : ICharacter
    {
        public string Name {get; set;}
        public int QuantityLife { get; set; }

        
        public Dwarves(string name, int life) 
        {
            this.Name = name;
            this.QuantityLife = life;
        }

        public void Cure(int Quantity) 
        {
            QuantityLife += Quantity;
            Console.WriteLine($"Se ha curado a {Name}, su estado de vida actual es {QuantityLife}");
        }

        public void Attack(ICharacter character)
        {
            Console.WriteLine($"El elfo {Name} ha atacdo a {character.Name}.");
            
        }
    }
}

//Esto iría en el Program:
//Dwarves Enano = new Dwarves("Enano", 100);
//Enano.Attack();
//Enano.Cure(20);