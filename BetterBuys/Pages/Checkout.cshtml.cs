using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BetterBuys.Data;
using BetterBuys.Interfaces;
using BetterBuys.Models;
using BetterBuys.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BetterBuys.Pages.Checkout
{
    [Authorize]
    public class CheckoutModel : PageModel
    {
        [BindProperty, Required, RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only"), MinLength(2, ErrorMessage = "First Name must contain at least 2 characters"),
        MaxLength(50, ErrorMessage = "First Name must not exceed 50 characters")]
        public string FirstName { get; set; }
        [BindProperty, Required, RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only"), MinLength(2, ErrorMessage = "Last Name must contain at least 2 characters"),
        MaxLength(50, ErrorMessage = "Last Name must not exceed 50 characters")]
        public string LastName { get; set; }
        [BindProperty, Required, MaxLength(100, ErrorMessage = "Address must not exceed 100 characters")]
        public string Address { get; set; }
        public string Apartment { get; set; }
        [BindProperty, Required, MaxLength(35, ErrorMessage = "City must not exceed 35 characters")]
        public string City { get; set; }
        [BindProperty, Required]
        public string Country { get; set; }
        [BindProperty, Required]
        public string Province { get; set; }
        [BindProperty, Required, RegularExpression("^[a-zA-Z]{1}[0-9]{1}[a-zA-Z]{1}[ ]?[0-9]{1}[a-zA-Z]{1}[0-9]{1}$",
        ErrorMessage = "Invalid Postal Code")]
        public string PostalCode { get; set; }
        [BindProperty, Required, Phone(ErrorMessage = "Invalid Phone Number")]
        public string Phone { get; set; }
        [BindProperty, Required, RegularExpression("^((?!(0))[0-9]{16})$", ErrorMessage = "Invalid Card Number")]
        public string CardNumber { get; set; }
        [BindProperty, Required, RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "Use letters only"), MinLength(2, ErrorMessage = "Cardholder Name must contain at least 2 characters"),
         MaxLength(50, ErrorMessage = "Cardholder Name must not exceed 50 characters")]
        public string CardHolderName { get; set; }
        [BindProperty, Required, RegularExpression("^((0[1-9])|(1[0-2]))/((2[0-9][2-9][0-9])|(3000))$", ErrorMessage = "Invalid Expiration Date")]
        public string ExpirationDate { get; set; }

        private readonly IProductVMService _productVMService;
        private readonly StoreDbContext _db;
        public CheckoutModel(IProductVMService productVMService, StoreDbContext db)
        {
            _productVMService = productVMService;
            _db = db;
        }
        public ProductIndexVM ProductIndex { get; set; } = new ProductIndexVM();
        public void OnGet()
        {
            ProductIndex = _productVMService.GetProductsVM(HttpContext, null);
            if (HttpContext.Session.GetInt32("cartId") != null)
            {
                productsInCart = (from p in ProductIndex.Products
                                  join cp in _db.CartProducts on p.Id equals cp.ProductId
                                  where cp.CartId == (int)HttpContext.Session.GetInt32("cartId")
                                  select p).ToList();
            }
        }

        public CheckoutInfo checkoutInfo;
        public async Task<IActionResult> OnPost()
        {
            ProductIndex = _productVMService.GetProductsVM(HttpContext, null);
            int? cartId = HttpContext.Session.GetInt32("cartId");

            if (cartId != null)
            {
                productsInCart = (from p in ProductIndex.Products
                                  join cp in _db.CartProducts on p.Id equals cp.ProductId
                                  where cp.CartId == cartId
                                  select p).ToList();
            }
            checkoutInfo = new CheckoutInfo(HttpContext.Session.GetInt32("cartId"), FirstName, LastName, Address, Apartment, City,
                             Country, Province, PostalCode, Phone, CardNumber, CardHolderName, ExpirationDate);

            if (!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                await _db.CheckoutInfos.AddAsync(checkoutInfo);
                ShoppingCart cart = await _db.Carts.Where(c => c.Id == cartId).FirstOrDefaultAsync();
                cart.setStatus(1);
                await _db.SaveChangesAsync();
                HttpContext.Session.Remove("cartId");
                return RedirectToPage("Confirmation");
            }
        }
        public List<ProductVM> productsInCart { get; set; } = new List<ProductVM>();

        // Calculate total price before delivery fee
        public decimal CalTotal(List<ProductVM> productList)
        {
            decimal total = 0;
            foreach (var item in productList)
            {
                total += (item.Price * item.Quantity);
            }
            return total;
        }
    }
}


