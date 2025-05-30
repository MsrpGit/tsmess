using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using tsmess.Services;
using tsmess.Models;

namespace tsmess.Pages.PrincipalDashboard
{
    public class InventoryManagementModel : PageModel
    {

        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ITsMessService _tsMessService;

        // Corrected type name to match the actual model
        public List<Supplier> Vendors { get; set; }

        // public IEnumerable<ImSupplierMaster> items { get; set; } = new List<ImSupplierMaster>();

        public List<ItemExpiryModel> ItemsNearingExpiry { get; set; }

        public Dictionary<string, string> ItemTypes { get; set; }

        public List<Partners> Partners { get; set; }

        public InventoryManagementModel(IConfiguration configuration,
            IHttpContextAccessor httpContextAccessor,
            ITsMessService tsMessService

            )
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _tsMessService = tsMessService;
        }
      

        public void OnGet()
        {
            Vendors = _tsMessService.getVendors();
            ItemsNearingExpiry = _tsMessService.GetItemsNearingExpiry();
            ItemTypes = _configuration.GetSection("ItemTypes").Get<Dictionary<string, string>>();
            Partners = _tsMessService.getPratners();
        }

        public JsonResult OnGetGetItems(string itemType)
        {
            itemType = "Book Stall";
            var items = _tsMessService.GetItems(itemType);
            return new JsonResult(items);
        }

        public JsonResult OnGetItemStock(string itemId)
        {
            var stock = _tsMessService.GetExistingItemCount(itemId);
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
        [Required(ErrorMessage = "Quantity Received is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than 0.")]
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

        [BindProperty]
        public string ItemType { get; set; } = "";

        [BindProperty]
        public bool IsAccepted { get; set; }

        [BindProperty]
        public string PartnerName { get; set; } = "";

        public async Task<IActionResult> OnPostAddInventoryAsync()
        {
            ModelState.Remove(nameof(PartnerName));

            if (!ModelState.IsValid)
            {
                return Page();
            }

            TempData["SuccessMessage"] = _tsMessService.OnPostAddInventoryAsync(ImInventoryTransaction) ? "Inventory transaction saved successfully." : "";
            return RedirectToPage("/PrincipalDashboard/Index", new { tab = "v-pills-messages" });
        }

        public async Task<IActionResult> OnPostAddSchoolInventoryAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
                //return new JsonResult(new { success = false, errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage) });
            }

            TempData["SuccessMessage"] = _tsMessService.OnPostAddInventoryAsync(ImInventoryTransaction) ? "Inventory transaction saved successfully." : "";

            return RedirectToPage("/PrincipalDashboard/Index", new { tab = "v-pills-messages" });
        }

        public async Task<IActionResult> OnPostDeleteInventoryAsync()
        {

            ModelState.Remove(nameof(PartnerName));
            ModelState.Remove(nameof(VendorId));
            ModelState.Remove(nameof(ReceivedDate));
            ModelState.Remove(nameof(QuantityReceived));
            ModelState.Remove(nameof(ExpiryDate));
            ModelState.Remove(nameof(NoAdulteration));
            ModelState.Remove(nameof(NoFoulSmell));
            ModelState.Remove(nameof(NoInsects));
            ModelState.Remove(nameof(NoTampering));
            ModelState.Remove(nameof(NotCleanlyPacked));


            if (!ModelState.IsValid)
            {
                return Page();
            }
           
            TempData["SuccessMessage"] = _tsMessService.RemoveInventoryTransaction(ImInventoryTransaction) ? "Inventory transaction saved successfully." : "";

            return RedirectToPage("/PrincipalDashboard/Index", new { tab = "v-pills-messages" });
        }

        
    }
}