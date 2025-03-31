using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using HelpApp.Domain;
using HelpApp.Domain.Entities;

namespace HelpApp.Domain.Test
{
    public class CategoryUnitTestcs
    {
        #region Testes Positivos
        [Fact(DisplayName = "Create Category Whith Valid State")]

        public void CreateCategory_WhithValidParameters_ResultobjectValidState()
        {
            Action action = () => new Category(1, "Category Name");
            action.Should().NotThrow<HelpApp.Domain.Validation.DomainExceptionValidation>();

        }
        #endregion

        #region Testes Negativos
        [Fact(DisplayName = "Create Category Whith Name Empty")]
        public void CreateCategory_WhithNameEmpty_ResultobjectException()
        {
            Action action = () => new Category(1, "");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
            .WithMessage("Invalid name, name is required.");
        }

        [Fact(DisplayName = "Create Category Whit Name Mininum 3 Characteres")]

        public void CreateCategory_WhithNameMinimum3Characteres_ResultCharacteres()
        {
            Action action = () => new Category(1, "AZ");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
            .WithMessage("Invalid name, too short, minimum 3 characters.");
        }

        [Fact(DisplayName = "Create Category Whith Id Value")]
        public void CreateCategory_WhithIdValue_ResultobjectException()
        {
            Action action = () => new Category(-1, "Category Name");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
            .WithMessage("Invalid Id value.");
        }
        #endregion

    }
}

