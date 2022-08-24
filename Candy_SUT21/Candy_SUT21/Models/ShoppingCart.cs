using FluentAssertions.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace Candy_SUT21.Models
{
    public class ShoppingCart
    {
        private readonly AppDbContext _appDbContext;

        
        public string ShoppingCartID { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        public ShoppingCart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDbContext>();

            string cartId = session.GetString("CartID") ?? Guid.NewGuid().ToString();
            session.SetString("CartID", cartId);

            return new ShoppingCart(context) { ShoppingCartID = cartId };
        }
    }
}