using HelpApp.Domain.Entities;

namespace HelpApp.Domain.Entities
{
    public class Product
    {
        #region Atributes
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; } 
        public int Stack { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }

        #endregion

        #region Constructors
        public Product(string name, string description, decimal price, int stack, string image)
        {
            Name= name;
            Description= description;
            Price= price;
            Stack= stack;
            Image= image;
        }

        public Category Category { get; set; }
        #endregion
    }
}
