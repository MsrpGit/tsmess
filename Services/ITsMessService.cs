using tsmess.Models;

namespace tsmess.Services
{
    public interface ITsMessService
    {
        string GetConnectionString();
        string GetConnectionString(bool isMaster);

        string GetTGMSConString();
        List<Supplier> getVendors();
        List<Partners> getPratners();
        List<ImItemmaster> GetItems(string itemType);
        int GetExistingItemCount(string itemId);
        List<ItemExpiryModel> GetItemsNearingExpiry();
        bool OnPostAddInventoryAsync(ImInventoryTransaction ImInventoryTransaction);
        bool RemoveInventoryTransaction(ImInventoryTransaction ImInventoryTransaction);
        bool OnPostAddVendorAsync(VendorMaster vendor);
        List<VendorMaster> GetVendorMasterList();
        bool OnPostDeleteVendorAsync(int vendorId);
    }
}
