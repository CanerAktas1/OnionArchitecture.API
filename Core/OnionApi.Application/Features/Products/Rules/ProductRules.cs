using OnionApi.Application.Bases;
using OnionApi.Application.Features.Products.Exceptions;
using OnionApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApi.Application.Features.Products.Rules
{
    public class ProductRules : BaseRules
    {
        public Task ProductTitleMustNotBeSame(IList<Product> products, string requestTitle)
        {
            if (products.Any(x=>x.Title == requestTitle.ToLower()))
                throw new ProductTitleMustNotBeSameException();

            return Task.CompletedTask;
        }
    }
}
