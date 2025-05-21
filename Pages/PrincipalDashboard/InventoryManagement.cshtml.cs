using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tsmess.Data;
using tsmess.Models;

namespace tsmess.Pages.PrincipalDashboard
{
    public class InventoryManagementModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        // Corrected type name to match the actual model
        public IEnumerable<ImSupplierMaster> Vendors { get; set; } = new List<ImSupplierMaster>();
        public IEnumerable<ImSupplierMaster> items { get; set; } = new List<ImSupplierMaster>();

        public InventoryManagementModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            // Ensure the type matches the property declaration
            Vendors = _context.ImSupplierMasters.OrderBy(s => s.SupplierName).ToList();
        }

        public JsonResult OnGetGetItems()
        {
            // Fetch items from the database
            var items = _context.ImItemmasters.Where(i=>i.ItemType== "Book Stall").Select(i => new { i.ItemId, i.ItemName }).ToList();

            // Return the items as JSON
            return new JsonResult(items);
        }

        public JsonResult OnGetItemStock(string itemId)
        {
            // Fetch the stock value for the given item from the database
            var stock = _context.ImItemExistingStocks
                .Where(i => i.ItemId == itemId)
                .Select(i => i.ExistingStock)
                .FirstOrDefault();

            // Return the stock value as JSON
            return new JsonResult(new { Quantity = stock });
        }


        //public PartialViewResult OnGetPartial()
        //{
        //    // Ensure the type matches the property declaration
        //    //Vendors = _context.ImSupplierMasters.OrderBy(s => s.SupplierName).ToList();
        //    var model = new InventoryManagementModel(_context)
        //    {
        //        Vendors = _context.ImSupplierMasters.OrderBy(s => s.SupplierName).ToList()
        //    };
        //    // Pass the model to the partial view
        //    return Partial("InventoryManagement", model);
        //}
    }
}
