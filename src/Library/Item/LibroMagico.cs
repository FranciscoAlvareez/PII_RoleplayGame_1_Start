namespace RoleplayGame;
public class ItemMagico : ILibroMagico
{
    public ItemMagico(string name, int damage, int defense)
    {
        this.Name = name;
        this.Damage = damage;
        this.Defense = defense;

    }
}