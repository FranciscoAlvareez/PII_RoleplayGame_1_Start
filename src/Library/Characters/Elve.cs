using System;
namespace RoleplayGame
{
    public class Elve
    {
        public int health = 100;
        public string Name {get; set;}
        public int health {get; set; }

<<<<<<< HEAD:src/Library/Characters/Elfo.cs
        public Elfo(string name) 
=======
        public Elve(string name, int life) 
>>>>>>> 7c3b8acaa57d2bf988c19c563f42b19b8273167a:src/Library/Characters/Elve.cs
        {
            this.Name = name;
        }
        public void Cure(int Quantity) 
        {
<<<<<<< HEAD:src/Library/Characters/Elfo.cs
            health += cantidad;
=======
            QuantityLife += Quantity;
>>>>>>> 7c3b8acaa57d2bf988c19c563f42b19b8273167a:src/Library/Characters/Elve.cs
            Console.WriteLine($"Se ha curado a {Name}, su estado de vida actual es {QuantityLife}");
        }
        public void HealCharacter(int cantidad, Dwarves character)
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