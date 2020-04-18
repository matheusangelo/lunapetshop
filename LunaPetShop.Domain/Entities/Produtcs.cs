namespace LunaPetShop.Domain.Entities
{
    public class Products : Entity
    {
    public string Name { get; set; }
    public double Price { get; set; }
    public int Amount { get; set; }
    public double Reviews { get; set; }
    public string AnimalType { get; set; }
        
    }
}