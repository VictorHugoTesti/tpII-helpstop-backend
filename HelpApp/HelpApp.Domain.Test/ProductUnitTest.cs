using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using HelpApp.Domain.Entities;

namespace HelpApp.Domain.Test
{
    public class ProductUnitTest
    {
        #region Testes Positivos
        [Fact(DisplayName = "Create Product Whith Valid Parameters")]

        public void CreateProdutc_WhithValidParameters_ResultobjectValidParameters() 
        {
            Action action = () => new Product(1, "Product Name" , "Product Description", 1, 1, "Product Image");
            action.Should().NotThrow<HelpApp.Domain.Validation.DomainExceptionValidation>();
        }
        #endregion

        #region Testes Negativos
        [Fact(DisplayName = "Create Product Whith Id Value")]
        public void CreateProduct_WhithIdValue_ResultobjectExpetion()
        {
            Action action = () => new Product(-1, "Product Name", "Product Description", 1, 1, "Product Image");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
            .WithMessage("Update Invalid Id value");
        }

        [Fact(DisplayName = "Create Product Whith Name Empty")]
        public void CreateProduct_WhithNameEmpty_ResultobjectExpetion()
        {
            Action action = () => new Product(1, "", "Product Description", 1, 1, "Product Image");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
            .WithMessage("Invalid name, name is required.");
        }

        [Fact(DisplayName = "Create Product Whith Name Null")]
        public void CreateProduct_WhithNameNull_ResultobjectExpetion()
        {
            Action action = () => new Product(1, null, "Product Description", 1, 1, "Product Image");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
            .WithMessage("Invalid name, name is required.");
        }

        [Fact(DisplayName = "Create Product Whith Name Mininum 3 Characteres")]
        public void CreateProduct_WhithNameMinimum3Characteres_ResultobjectExpetion()
        {
            Action action = () => new Product(1, "Az", "Product Description", 1, 1, "Product Image");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
            .WithMessage("Invalid name, too short, minimum 3 characters.");
        }

        [Fact(DisplayName = "Create Product Whith Descripition Empty")]
        public void CreateProduct_WhithDescripitionEmpty_ResultobjectExpetion()
        {
            Action action = () => new Product(1, "Product Name", "", 1, 1, "Product Image");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
            .WithMessage("Invalid description, name is required.");
        }

        [Fact(DisplayName = "Create Product Whith Descripition Mininum 5 Characteres")]
        public void CreateProduct_WhithDescripitionMinimum5Characteres_ResultobjectExpetion()
        {
            Action action = () => new Product(1, "Product Name", "ABC", 1, 1, "Product Image");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
            .WithMessage("Invalid description, too short, minimum 5 characters.");
        }

        [Fact(DisplayName = "Create Product Whith Descripition Null")]
        public void CreateProduct_WhithDescripitionNull_ResultobjectExpetion()
        {
            Action action = () => new Product(1, "Product Name", null, 1, 1, "Product Image");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
            .WithMessage("Invalid description, name is required.");
        }

        [Fact(DisplayName = "Create Product Whith Price Negative")]
        public void CreateProduct_WhithPriceNegative_ResultobjectExpetion()
        {
            Action action = () => new Product(1, "Product Name", "Product Description", -1, 1, "Product Image");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
            .WithMessage("Invalid price negative value.");
        }

        [Fact(DisplayName = "Create Product Whith Stock Negative")]
        public void CreateProduct_WhithStockNegative_ResultobjectExpetion()
        {
            Action action = () => new Product(1, "Product Name", "Product Description", 1, -1, "Product Image");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
            .WithMessage("Invalid stock negative value.");
        }

        [Fact(DisplayName = "Create Product Whith Image Maximum 250 Characteres")]
        public void CreateProduct_WhithImageMaximum250Characteres_ResultobjectExpetion()
        {
            Action action = () => new Product(1, "Product Name", "Product Description", 1, 1, "Product Image (250) - 1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
            .WithMessage("Invalid image name, too long, maximum 250 characters.");
        }

        [Fact(DisplayName = "Create Product Whith Image Empty")]
        public void CreateProduct_WhithImageEmpty_ResultobjectExpetion()
        {
            Action action = () => new Product(1, "Product Name", "Product Description", 1, 1, "");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
            .WithMessage("Invalid image name, image name is Empty");
        }

        [Fact(DisplayName = "Create Product Whith Image Null")]
        public void CreateProduct_WhithImageNull_ResultobjectExpetion()
        {
            Action action = () => new Product(1, "Product Name", "Product Description", 1, 1, null);
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
            .WithMessage("Invalid image name, image name is null");
        }
        #endregion

    }
}
