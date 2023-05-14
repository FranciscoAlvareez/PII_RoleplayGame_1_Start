using System;
namespace RoleplayGame
{
    public class Elve
    {
        public string Name {get; set;}
        public int QuantityLife {get; set; }

        public Elve(string name, int life) 
        {
            this.Name = name;
            this.QuantityLife = life;
        }
        public void Cure(int Quantity) 
        {
            QuantityLife += Quantity;
            Console.WriteLine($"Se ha curado a {Name}, su estado de vida actual es {QuantityLife}");
        }
        public void HealCharacter(Dwarves character, int cantidad)
        {
           character.Cure(cantidad);
           Console.WriteLine($"{Name}ha curado al personaje {character.Name}, y acutalmente su estado de vida es: {character.QuantityLife}"); 
        }
        /*
        public void ThrowArrow(Dwarves personaje)
        {
            personaje.Life -= 20;
        }
        */
        


    }
}