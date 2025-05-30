using tsmess.Models;
using CampusDAO;
using System.Data;

namespace tsmess.Services
{
    public class TsMessService : ITsMessService
    {

        private readonly IDBInterface _dbConnection;

        public TsMessService(IDBInterface dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public string GetConnectionString()
        {
            return _dbConnection.GetTenantConString();
        }

        public string GetConnectionString(bool isMaster)
        {
            return isMaster.Equals(true) ? _dbConnection.GetMasterConString() : _dbConnection.GetTenantConString();
        }

        public string GetTGMSConString()
        {
            return _dbConnection.GetTGMSConString();
        }

        public List<Supplier> getVendors()
        {

            try
            {
                var suppliers = new List<Supplier>();

                DataTable dt = new DataTable();
                dt = _dbConnection.GetDataAsDataSetWithQuery(this.GetConnectionString(), "SELECT SupplierId,SupplierName FROM shastrischema.IM_SupplierMaster ORDER BY SupplierName");
                foreach (DataRow row in dt.Rows)
                {
                    suppliers.Add(new Supplier
                    {
                        SupplierId = row.Field<string>("SupplierId"),
                        SupplierName = row.Field<string>("SupplierName")
                    });
                }

                return suppliers;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Partners> getPratners()
        {
            try
            {
                var Partners = new List<Partners>();

                DataTable dt = new DataTable();
                dt = _dbConnection.GetDataAsDataSetWithQuery(this.GetConnectionString(true), "SELECT PartnerId,PartnerName FROM dbo.WDI_M_Partners");
                foreach (DataRow row in dt.Rows)
                {
                    Partners.Add(new Partners
                    {
                        PartnerId = row.Field<long>("PartnerId"),
                        PartnerName = row.Field<string>("PartnerName")
                    });
                }

                return Partners;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ImItemmaster> GetItems(string itemType)
        {
            try
            {
                var items = new List<ImItemmaster>();

                var sql = "SELECT ItemId, ItemName FROM shastrischema.IM_ITEMMASTER WHERE ItemType = @ItemType";
                var parameters = new { ItemType = itemType };


                DataTable dt = new DataTable();
                dt = _dbConnection.GetDataAsDataSetWithQuery(this.GetConnectionString(), sql, parameters);
                foreach (DataRow row in dt.Rows)
                {
                    items.Add(new ImItemmaster
                    {
                        ItemId = row.Field<string>("ItemId"),
                        ItemName = row.Field<string>("ItemName")
                    });
                }

                return items;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int GetExistingItemCount(string itemId)
        {
            try
            {
                var sql = "SELECT TOP 1 ExistingStock FROM shastrischema.IM_ItemExistingStock WHERE ItemId = @ItemId";
                var parameters = new { ItemId = itemId };

                DataTable dt = new DataTable();
                dt = _dbConnection.GetDataAsDataSetWithQuery(this.GetConnectionString(), sql, parameters);

                if (dt.Rows.Count > 0)
                {
                    return Convert.ToInt32(dt.Rows[0][0]);
                }
                return 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ItemExpiryModel> GetItemsNearingExpiry()
        {
            try
            {
                var items = new List<ItemExpiryModel>();

                string sql = @"
                                SELECT 
                                    t.Id AS TransactionId,
                                    m.ItemType AS Category,
                                    m.ItemName,
                                    DATEDIFF(DAY, GETDATE(), t.ExpiryDate) AS DaysToExpiry
                                FROM 
                                    shastrischema.IM_InventoryTransaction t
                                INNER JOIN 
                                    shastrischema.IM_ITEMMASTER m ON CAST(t.ItemId AS VARCHAR) = m.ItemId
                                WHERE 
                                    DATEDIFF(DAY, GETDATE(), t.ExpiryDate) >= 0;
                            ";

                DataTable dt = _dbConnection.GetDataAsDataSetWithQuery(this.GetConnectionString(), sql);

                foreach (DataRow row in dt.Rows)
                {
                    items.Add(new ItemExpiryModel
                    {
                        TransactionId = row.Field<int>("TransactionId"),
                        Category = row.Field<string>("Category"),
                        ItemName = row.Field<string>("ItemName"),
                        DaysToExpiry = row.Field<int>("DaysToExpiry")
                    });
                }

                return items;
            }
            catch (Exception ex)
            {
                // Optional: log the error
                throw new Exception("Error fetching items nearing expiry", ex);
            }
        }

        public bool OnPostAddInventoryAsync(ImInventoryTransaction ImInventoryTransaction)
        {
            try
            {
                // Step 1: Check if existing stock exists
                string selectQuery = @"
                                        SELECT ExistingStock 
                                        FROM shastrischema.IM_ItemExistingStock 
                                        WHERE ItemId = @ItemId";

                var parameters = new { ItemId = ImInventoryTransaction.ItemId.ToString() };

                DataTable selectResult = _dbConnection.GetDataAsDataSetWithQuery(this.GetConnectionString(), selectQuery, parameters);

                bool stockExists = selectResult.Rows.Count > 0;

                // Step 2: If existing stock found and accepted, update it
                if (stockExists && ImInventoryTransaction.IsAccepted)
                {
                    int existingStock = Convert.ToInt32(selectResult.Rows[0]["ExistingStock"]);
                    int updatedStock = existingStock + ImInventoryTransaction.QuantityReceived;

                    string updateQuery = @"
                                            UPDATE shastrischema.IM_ItemExistingStock 
                                            SET ExistingStock = @ExistingStock 
                                            WHERE ItemId = @ItemId";

                    var updateParams = new { ExistingStock = updatedStock, ItemId = ImInventoryTransaction.ItemId.ToString() };

                    _dbConnection.GetDataAsDataSetWithQuery(this.GetConnectionString(), updateQuery, updateParams);
                }

                // Step 3: Insert inventory transaction with all fields
                string insertQuery = @"
                                    INSERT INTO shastrischema.IM_InventoryTransaction (
                                        ItemId, QuantityPresent, VendorId, ReceivedDate, QuantityReceived,
                                        ExpiryDate, NoAdulteration, NoFoulSmell, NoInsects, NoTampering,
                                        NotCleanlyPacked, Remarks, IsAccepted, ItemType, PartnerName
                                    ) VALUES (
                                        @ItemId, @QuantityPresent, @VendorId, @ReceivedDate, @QuantityReceived,
                                        @ExpiryDate, @NoAdulteration, @NoFoulSmell, @NoInsects, @NoTampering,
                                        @NotCleanlyPacked, @Remarks, @IsAccepted, @ItemType, @PartnerName
                                    )";

                var insertParams = new
                {
                    ItemId = ImInventoryTransaction.ItemId,
                    QuantityPresent = ImInventoryTransaction.QuantityPresent,
                    VendorId = ImInventoryTransaction.VendorId,
                    ReceivedDate = ImInventoryTransaction.ReceivedDate,
                    QuantityReceived = ImInventoryTransaction.QuantityReceived,
                    ExpiryDate = ImInventoryTransaction.ExpiryDate,
                    NoAdulteration = ImInventoryTransaction.NoAdulteration,
                    NoFoulSmell = ImInventoryTransaction.NoFoulSmell,
                    NoInsects = ImInventoryTransaction.NoInsects,
                    NoTampering = ImInventoryTransaction.NoTampering,
                    NotCleanlyPacked = ImInventoryTransaction.NotCleanlyPacked,
                    Remarks = ImInventoryTransaction.Remarks,
                    IsAccepted = ImInventoryTransaction.IsAccepted,
                    ItemType = ImInventoryTransaction.ItemType,
                    PartnerName = ImInventoryTransaction.PartnerName ?? "",
                    IsDeleted = false
                };

                _dbConnection.GetDataAsDataSetWithQuery(this.GetConnectionString(), insertQuery, insertParams);

                return true; // success
            }
            catch (Exception ex)
            {
                // Optional: log the error
                throw new Exception("Error saving inventory transaction", ex);
            }
        }

        public bool RemoveInventoryTransaction(ImInventoryTransaction ImInventoryTransaction)
        {
            try
            {
                // Step 1: Fetch existing stock
                string selectQuery = @"
                                    SELECT ExistingStock 
                                    FROM shastrischema.IM_ItemExistingStock 
                                    WHERE ItemId = @ItemId";

                var selectParams = new { ItemId = ImInventoryTransaction.ItemId.ToString() };

                DataTable selectResult = _dbConnection.GetDataAsDataSetWithQuery(this.GetConnectionString(), selectQuery, selectParams);

                bool stockExists = selectResult.Rows.Count > 0;

                // Step 2: If stock exists, reduce the stock
                if (stockExists)
                {
                    int existingStock = Convert.ToInt32(selectResult.Rows[0]["ExistingStock"]);
                    int updatedStock = existingStock - ImInventoryTransaction.QuantityReceived;

                    string updateQuery = @"
                                            UPDATE shastrischema.IM_ItemExistingStock 
                                            SET ExistingStock = @ExistingStock 
                                            WHERE ItemId = @ItemId";

                    var updateParams = new { ExistingStock = updatedStock, ItemId = ImInventoryTransaction.ItemId.ToString() };


                    _dbConnection.GetDataAsDataSetWithQuery(this.GetConnectionString(), updateQuery, updateParams);
                }

                // Step 3: Insert the inventory transaction (ReceivedDate & ExpiryDate set to NOW)
                string insertQuery = @"
                                    INSERT INTO shastrischema.IM_InventoryTransaction (
                                        ItemId, QuantityPresent, VendorId, ReceivedDate, QuantityReceived,
                                        ExpiryDate, NoAdulteration, NoFoulSmell, NoInsects, NoTampering,
                                        NotCleanlyPacked, Remarks, IsAccepted, ItemType, PartnerName
                                    ) VALUES (
                                        @ItemId, @QuantityPresent, @VendorId, @ReceivedDate, @QuantityReceived,
                                        @ExpiryDate, @NoAdulteration, @NoFoulSmell, @NoInsects, @NoTampering,
                                        @NotCleanlyPacked, @Remarks, @IsAccepted, @ItemType, @PartnerName
                                    )";

                var insertParams = new
                {
                    ItemId = ImInventoryTransaction.ItemId,
                    QuantityPresent = ImInventoryTransaction.QuantityPresent,
                    VendorId = ImInventoryTransaction.VendorId,
                    ReceivedDate = DateTime.Now,
                    QuantityReceived = ImInventoryTransaction.QuantityReceived,
                    ExpiryDate = DateTime.Now,
                    NoAdulteration = ImInventoryTransaction.NoAdulteration,
                    NoFoulSmell = ImInventoryTransaction.NoFoulSmell,
                    NoInsects = ImInventoryTransaction.NoInsects,
                    NoTampering = ImInventoryTransaction.NoTampering,
                    NotCleanlyPacked = ImInventoryTransaction.NotCleanlyPacked,
                    Remarks = ImInventoryTransaction.Remarks,
                    IsAccepted = ImInventoryTransaction.IsAccepted,
                    ItemType = ImInventoryTransaction.ItemType,
                    PartnerName = ImInventoryTransaction.PartnerName ?? "",
                    IsDeleted = true
                };

                _dbConnection.GetDataAsDataSetWithQuery(this.GetConnectionString(), insertQuery, insertParams);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error removing inventory transaction", ex);
            }
        }

        public bool OnPostAddVendorAsync(VendorMaster vendor)
        {
            try
            {
                // Step 1: Construct the INSERT query
                //string insertQuery = @"
                //            INSERT INTO VendorMaster (
                //                VendorTitle, VendorSurname, VendorName, VendorSupplingAreaDistricts, VendorSuppliingAreaZones,
                //                VendorContact, VendorSecondaryContact, VendorType, VendorAcType, VendorLocationCity,
                //                VendorLocationDistrict, VendorLocationZone, VendorAddress, VendorPinCode, VendorTINNumber,
                //                VendorPANNumber, VendorGSTNumber, BusinessNature, VendorBankName, VendorBankAccountNo,
                //                VendorBankIFSC, VendorBankBranch, VendorIDCardNumer, VendorStatus
                //            )
                //            VALUES (
                //                @VendorTitle, @VendorSurname, @VendorName, @VendorSupplingAreaDistricts, @VendorSuppliingAreaZones,
                //                @VendorContact, @VendorSecondaryContact, @VendorType, @VendorAcType, @VendorLocationCity,
                //                @VendorLocationDistrict, @VendorLocationZone, @VendorAddress, @VendorPinCode, @VendorTINNumber,
                //                @VendorPANNumber, @VendorGSTNumber, @BusinessNature, @VendorBankName, @VendorBankAccountNo,
                //                @VendorBankIFSC, @VendorBankBranch, @VendorIDCardNumer, @VendorStatus
                //            )";

                // Step 2: Create parameter object
                //var insertParams = new
                //{
                //    vendor.VendorTitle,
                //    vendor.VendorSurname,
                //    vendor.VendorName,
                //    vendor.VendorSupplingAreaDistricts,
                //    vendor.VendorSuppliingAreaZones,
                //    vendor.VendorContact,
                //    vendor.VendorSecondaryContact,
                //    vendor.VendorType,
                //    vendor.VendorAcType,
                //    vendor.VendorLocationCity,
                //    vendor.VendorLocationDistrict,
                //    vendor.VendorLocationZone,
                //    vendor.VendorAddress,
                //    vendor.VendorPinCode,
                //    vendor.VendorTINNumber,
                //    vendor.VendorPANNumber,
                //    vendor.VendorGSTNumber,
                //    vendor.BusinessNature,
                //    vendor.VendorBankName,
                //    vendor.VendorBankAccountNo,
                //    vendor.VendorBankIFSC,
                //    vendor.VendorBankBranch,
                //    vendor.VendorIDCardNumer,
                //    vendor.VendorStatus
                //};
                string insertQuery = @"
                            INSERT INTO VendorMaster (
                                VendorName, 
                                VendorContact,    
                                VendorBankAccountNo,
                                VendorBankIFSC,
                                VendorType,
                                CircularUploadPath,
                                VendorDocsPath,
                                VendorLocationCity,
                                VendorAddress,
                                VendorPinCode,                                
                                VendorSupplingAreaDistricts,
                                VendorSuppliingAreaZones
                            )
                            VALUES (
                                @VendorName, 
                                @VendorContact,                                                         
                                @VendorBankAccountNo,
                                @VendorBankIFSC,
                                @VendorType,
                                @CircularUploadPath,
                                @VendorDocsPath,
                                '',
                                '',
                                '',
                                '',
                                ''
                            )";

                var insertParams = new
                {
                    vendor.VendorName,
                    vendor.VendorContact,
                    vendor.VendorBankAccountNo,
                    vendor.VendorBankIFSC,
                    vendor.VendorType,
                    vendor.CircularUploadPath,
                    vendor.VendorDocsPath
                };

                // Step 3: Execute the insert
                _dbConnection.GetDataAsDataSetWithQuery(this.GetTGMSConString(), insertQuery, insertParams);

                return true; // success
            }
            catch (Exception ex)
            {
                // Optional: log the error
                throw new Exception("Error saving vendor", ex);
            }
        }

        public List<VendorMaster> GetVendorMasterList()
        {
            try
            {
                var vendors = new List<VendorMaster>();

                string sql = @"
                                SELECT 
                                    [VendorId],
                                    [VendorName],
                                    [VendorContact],
                                    [VendorType],
                                    [VendorBankAccountNo],
                                    [VendorBankIFSC],
                                    [CircularUploadPath],
                                    [VendorDocsPath]
                                FROM 
                                    [dbo].[VendorMaster]
                            ";

                DataTable dt = _dbConnection.GetDataAsDataSetWithQuery(this.GetTGMSConString(), sql);

                foreach (DataRow row in dt.Rows)
                {
                    vendors.Add(new VendorMaster
                    {
                        VendorId = row.Field<long>("VendorId"),
                        VendorName = row.Field<string>("VendorName"),
                        VendorContact = row.Field<string>("VendorContact"),
                        VendorType = row.Field<string>("VendorType"),
                        VendorBankAccountNo = row.Field<string>("VendorBankAccountNo"),
                        VendorBankIFSC = row.Field<string>("VendorBankIFSC"),
                        CircularUploadPath = row.Field<string>("CircularUploadPath"),
                        VendorDocsPath = row.Field<string>("VendorDocsPath")
                    });
                }

                return vendors;
            }
            catch (Exception ex)
            {
                // Optional: log the error
                throw new Exception("Error fetching items nearing expiry", ex);
            }
        }

        public bool OnPostDeleteVendorAsync(int vendorId)
        {
            try
            {
                string sql = $@"DELETE FROM [dbo].[VendorMaster]
                                WHERE VendorId = {vendorId}";

                _dbConnection.GetDataAsDataSetWithQuery(this.GetTGMSConString(), sql);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
