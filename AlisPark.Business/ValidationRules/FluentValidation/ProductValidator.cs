using FluentValidation;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlisPark.Entities.Concrete;

namespace AlisPark.Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        //fluent validation
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Product Name can't be empty.");
            RuleFor(p => p.CategoryId).NotEmpty();
            RuleFor(p => p.StockAmount).NotEmpty();
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(-1).WithMessage("The product unitprice must be greater than 0.");
            RuleFor(p => p.StockAmount).GreaterThan(-1).WithMessage("Product stock cannot be negative.");
            RuleFor(p => p.StockAmount).Must(BeAnInteger).WithMessage("Product stock must be an integer number.");
            RuleFor(p => p.UnitPrice).Must(BeAnInteger).WithMessage("Product stock must be an integer number.");
        }

        private bool BeAnInteger(decimal arg)
        {
            return arg % 1 == 0;
        }

        private bool BeAnInteger(int stock)
        {
            return stock % 1 == 0;
        }

    }
}
