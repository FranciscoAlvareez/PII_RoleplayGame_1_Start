using System;
namespace RoleplayGame
{
    public class Elfo
    {
        public int health = 100;
        public string Name {get; set;}
        public int health {get; set; }

        public Elfo(string name) 
        {
            this.Name = name;
        }
        public void Cure(int cantidad) 
        {
            health += cantidad;
            Console.WriteLine($"Se ha curado a {Name}, su estado de vida actual es {QuantityLife}");
        }
        public void HealCharacter(int cantidad, Dwarves character)
        {
           character.Cure(cantidad);
           Console.WriteLine($"{Name}ha curado al personaje {character.Name}, y acutalmente su estado de vida es: {character.Life}"); 
        }
        /*
        public void ThrowArrow(Dwarves personaje)
        {
            personaje.Life -= 20;
        }
        */
        


    }
}