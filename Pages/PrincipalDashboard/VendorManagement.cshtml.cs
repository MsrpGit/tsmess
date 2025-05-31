using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using tsmess.Models;
using tsmess.Services;

namespace tsmess.Pages.PrincipalDashboard
{
    public class VendorManagementModel : PageModel
    {
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ITsMessService _tsMessService;
        private readonly IWebHostEnvironment _environment;

        public VendorManagementModel(IConfiguration configuration,
            IHttpContextAccessor httpContextAccessor,
            ITsMessService tsMessService,
            IWebHostEnvironment environment
            )
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _tsMessService = tsMessService;
            _environment = environment;
        }

        [BindProperty]
        public VendorMaster vendor { get; set; }

        [BindProperty]
        public List<VendorMaster> vendors { get; set; }

        [BindProperty]
        public IFormFile CircularUpload { get; set; }

        [BindProperty]
        public IFormFile VendorDocs { get; set; }

        [BindProperty]
        public string toMobileNo { get; set; }

        public void OnGet()
        {
            vendors = _tsMessService.GetVendorMasterList();
        }

        public async Task<IActionResult> OnPostAddVendorAsync()
        {
            // Handle CircularUpload
            if (CircularUpload != null)
            {
                var circularPath = Path.Combine("uploads", "circulars", GenerateTimestampCode() + Path.GetFileName(CircularUpload.FileName));
                var fullCircularPath = Path.Combine(_environment.WebRootPath, circularPath);
                Directory.CreateDirectory(Path.GetDirectoryName(fullCircularPath));
                using (var stream = new FileStream(fullCircularPath, FileMode.Create))
                {
                    await CircularUpload.CopyToAsync(stream);
                }
                vendor.CircularUploadPath = "/" + circularPath.Replace("\\", "/");
            }

            // Handle VendorDocs
            if (VendorDocs != null)
            {
                var docsPath = Path.Combine("uploads", "vendordocs", GenerateTimestampCode() + Path.GetFileName(VendorDocs.FileName));
                var fullDocsPath = Path.Combine(_environment.WebRootPath, docsPath);
                Directory.CreateDirectory(Path.GetDirectoryName(fullDocsPath));
                using (var stream = new FileStream(fullDocsPath, FileMode.Create))
                {
                    await VendorDocs.CopyToAsync(stream);
                }
                vendor.VendorDocsPath = "/" + docsPath.Replace("\\", "/");
            }

            if (!ModelState.IsValid)
            {
                return Page();
                //return new JsonResult(new { success = false, errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage) });
            }

            TempData["SuccessMessage"] = _tsMessService.OnPostAddVendorAsync(vendor) ? "Vendor details saved successfully." : "";

            return RedirectToPage("/PrincipalDashboard/Index", new { tab = "v-pills-vm-tab" });
        }

        public async Task<IActionResult> OnPostDeleteVendorAsync(int vendorId)
        {
            _tsMessService.OnPostDeleteVendorAsync(vendorId);
            return RedirectToPage("/PrincipalDashboard/Index", new { tab = "v-pills-vm-tab" });
        }

        private string GenerateTimestampCode()
        {
            return DateTime.UtcNow.Ticks.ToString().Substring(10, 5);
        }

       
        public async Task<IActionResult> OnPostsendSMSAsync(string toMobileNo)
        {
            var Templateid = "1707172380728192202";
            var senderId = "EDUSNC";
            var message = "Dear {#var#} , Your OTP for the edusync mobile application login is {#var#} .Please enter in the concerned fields for further process. Thank you -EDUSNC\r\n";
            var url = "http://sms.scubedigi.com/api.php?username=intense;password=intense;to=$$mobile$$;from=EDUSNC;message=$$message$$;PEID=1501470690000013369;templateid=1707172380728192202";
            return new JsonResult(new
            {
                success = true,
                message = "SMS send successfully."
            });
        }
       
    }
}
