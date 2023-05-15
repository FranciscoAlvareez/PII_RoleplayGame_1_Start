
using System;
using System.Collections.Generic;

namespace RoleplayGame
{
    public class ItemMagic
    {
        public ItemMagic(string type, string name, int powerAttack, int powerDefense)
        {
            this.Type = type;
            this.Name = name;
            this.AttackValue = powerAttack;
            this.DefenseValue = powerDefense;
            this.Dex.Add(name);     // No se si esta, está correcto
        }
        

        public string Type { get; set; }
        public string Name { get; set; }
        public int AttackValue { get; set; }
        public int DefenseValue { get; set; }

        private List<string> Dex;       // Lugar provisional para guardar los nombres de los items
        
        // private List<ItemMagic> Inventory;
        // Quiero que despues de que un item magico se cree, se pueda guardar en una lista 
        
        public void GetItems()
        {
            // add magic items to inventory
            foreach (string items in Dex)
            {
                Console.WriteLine(items);
            }
        }

    }
}