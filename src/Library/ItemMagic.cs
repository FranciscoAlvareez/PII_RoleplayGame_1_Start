
using System;
using System.Collections.Generic;

namespace RoleplayGame
{
    public class ItemMagic
    {
        public string Name { get; set; }
        public int AttackValue { get; set; }
        public int DefenseValue { get; set; }

        private List<string> Dex; // Lugar provisional para guardar los nombres de los items
        private List<ItemMagic> Inventory;
        public ItemMagic(string name, int powerAttack, int powerDefense)
        {
            this.Name = name;
            this.AttackValue = powerAttack;
            this.DefenseValue = powerDefense;
            this.Dex.Add(name);
        }
        
        // Quiero que despues de que un item magico se cree, se pueda guardar en una lista 
        
        public void GetItems()
        {
            // add magic items to inventory
            foreach (string items in Dex)
            {
                Console.WriteLine(items);
            }
        }

        /*
        public void GetArmaduras()
        {
            Console.WriteLine("Las armaduras disponibles son: ");
            foreach (string defensa in Armaduras)
            {
                Console.WriteLine(defensa);
            }
        }
        public void GetArmas()
        {
            Console.WriteLine("Las armas disponibles son: ");
            foreach (string arma in Armas)
            {
                Console.WriteLine(arma);
            }
        }
        */    
    }
}