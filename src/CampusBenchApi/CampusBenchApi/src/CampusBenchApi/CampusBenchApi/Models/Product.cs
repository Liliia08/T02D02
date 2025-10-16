using System.Text.Json.Serialization;

namespace CampusBenchApi.Models;

public partial class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    [JsonIgnore]
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}