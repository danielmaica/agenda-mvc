namespace projeto_mvc.Models
{
    public abstract class Entity
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
    }
}