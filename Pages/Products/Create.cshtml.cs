﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Products_Sales_Commission_Core_Web.BusinessLayer;
using Products_Sales_Commission_Core_Web.Models;

namespace Products_Sales_Commission_Core_Web.Pages.Products
{
    public class CreateModel : PageModel
    {
        private readonly Products_Sales_Commission_Core_Web.Models.Products_Sales_Commission_Data_Context _context;

        public CreateModel(Products_Sales_Commission_Core_Web.Models.Products_Sales_Commission_Data_Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ManufacturerId"] = new SelectList(_context.Manufacturer, "Id", "BusinessName");
            return Page();
        }

        [BindProperty]
        public Product Product { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Product.Add(Product);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
