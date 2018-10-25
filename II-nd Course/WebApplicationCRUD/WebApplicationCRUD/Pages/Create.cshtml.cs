﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplicationCRUD.Pages
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _db;

        [BindProperty]
        public Customer Customer { get; set; }

        [TempData]
        public string Message { get; set; }

        public CreateModel(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            //Customer customer = new Customer();
            //customer.Name = Name;
            //customer.Id = 1;
            _db.Customers.Add(Customer);
            await _db.SaveChangesAsync();

            Message = $"Customer {Customer.Name} added.";

            return RedirectToPage("/Index");
        }
    }
}