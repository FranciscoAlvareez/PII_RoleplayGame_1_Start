using NUnit.Framework;



namespace RoleplayGame
{
    public class WizardsTest
    {
        [Test]
        public void TestingWizards()
        {
            Wizard Wizard1 = new Wizard("Dr. Strange", 100);
            Wizard Wizard2 = new Wizard("Dr. Doom", 100);
            ItemMagic Object = new ItemMagic("Libro", "El Poder del Fuego", 50, 0);  // Me da error. Dice que ItemMagic no es invocable. No se si me da problema el Namespace en el archivo de ItemMagic
            Wizard1.AddObjects(Object);
            Wizard1.Attack(Wizard2);

            Assert.AreEqual(50, Wizard2.QuantityLife);
        }
    }
}

