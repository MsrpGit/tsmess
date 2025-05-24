using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
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
            var items = _context.ImItemmasters.Where(i => i.ItemType == "Book Stall").Select(i => new { i.ItemId, i.ItemName }).ToList();

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

        [BindProperty]
        public ImInventoryTransaction ImInventoryTransaction { get; set; }

        [BindProperty]
        public string ItemId { get; set; }

        [BindProperty]
        public int QuantityPresent { get; set; }

        [BindProperty]
        public int VendorId { get; set; }

        [BindProperty]
        [DataType(DataType.Date)]
        public DateTime ReceivedDate { get; set; } = DateTime.Now;

        [BindProperty]
        public int QuantityReceived { get; set; }

        [BindProperty]
        [DataType(DataType.Date)]
        public DateTime ExpiryDate { get; set; } = DateTime.Now; // Default to 30 days from now

        [BindProperty]
        public bool NoAdulteration { get; set; }

        [BindProperty]
        public bool NoFoulSmell { get; set; }

        [BindProperty]
        public bool NoInsects { get; set; }

        [BindProperty]
        public bool NoTampering { get; set; }

        [BindProperty]
        public bool NotCleanlyPacked { get; set; }

        [BindProperty]
        public string Remarks { get; set; }

        public async Task<IActionResult> OnPostAddInventoryAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
                //return new JsonResult(new { success = false, errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage) });
            }

            _context.ImInventoryTransactions.Add(ImInventoryTransaction);
            await _context.SaveChangesAsync();

            return RedirectToPage("/PrincipalDashboard/Index", new { tab = "v-pills-messages" });
        }
    }
}
