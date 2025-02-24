using HelpApp.Domain.Validation;
using System.Collections.Generic;

namespace HelpApp.Domain.Entities
{
    public class Category
    {
        #region Atributes
        public int Id { get; set; }
        public string Name { get; set; }
        #endregion

        #region Constructors
        public Category(string name) 
        {
            Name= name;
        }

        public ICollection<Product> Products { get; set; }
        #endregion

        #region Validations
        private void ValidationDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name),
                "Invalid name, name is Requerid");

            DomainExceptionValidation.When(name.Length < 3,
                "Invalid name, too start, minimun 3 characters");

            Name= name;
        }
        #endregion
    }
}
