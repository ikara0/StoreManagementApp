using System;

namespace InformationModels
{
    public class Product
    {
        public Product(string productName, string productCode, decimal price, User createdBy, DateTime createdAt, Category category)
        {
            Name = productName;    
            Code = productCode;
            Price = price;
            CreatedBy = createdBy;
            CreatedAt = createdAt;
            Category = category;

        }
        public Product()
        {

        }
        public string Name { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        public User CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public Category Category { get; set; }
    }

}
