using System;
namespace RoleplayGame
{
    public class Elve : ICharacter
    {
        public string Name {get; set;}
        public int QuantityLife {get; set; }

        public Elve(string name, int life) 
        {
            this.Name = name;
            this.QuantityLife = life;
        }
        
        public void HealCharacter(ICharacter character, int cantidad)
        {
           character.Cure(cantidad);
           Console.WriteLine($"{Name}ha curado al personaje {character.Name}, y acutalmente su estado de vida es: {character.QuantityLife}"); 
        }

        public void Attack(ICharacter character)
        {
            Console.WriteLine($"El elfo {Name} ha atacdo a {character.Name}.");
            
        }
        
        /*
        public void ThrowArrow(Dwarves personaje)
        {
            personaje.Life -= 20;
        }
        */
        public void Cure(int Quantity) 
        {
            if (Quantity <= 1000)
            {
                QuantityLife += Quantity;
                Console.WriteLine($"Se ha curado a {Name}, su estado de vida actual es {QuantityLife}");
            }
            else
            {
                Console.WriteLine("La cantidad que desea curar excede los limites de curación.");
            }
        }

    }
}