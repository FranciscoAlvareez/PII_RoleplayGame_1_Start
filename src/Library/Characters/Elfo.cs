using System;
namespace Library
{
    public class Elfo
    {
        public string Name {get; set;}
        public int QuantityLife {get; set; }

        public Elfo(string name, int life) 
        {
            this.Name = name;
            this.QuantityLife = life;
        }
        public void Cure(int cantidad) 
        {
            QuantityLife += cantidad;
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