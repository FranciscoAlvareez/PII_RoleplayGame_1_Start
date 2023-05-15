using System;

namespace RoleplayGame
{
    public class Dwarves : ICharacter
    {
        public string Name {get; set;}
        public int QuantityLife { get; set; }
        public Item Weapon { get; set; }
 
        
        public Dwarves(string name, int life) 
        {
            this.Name = name;
            this.QuantityLife = life;
        }

        public void AttackWeapon(ICharacter character)
        {
            QuantityLife += Quantity;
            Console.WriteLine ($"{Name} se ha curado. Su vida acutal es: {QuantityLife}");
        }

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

