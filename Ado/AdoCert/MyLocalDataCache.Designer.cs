﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdoCert {
    
    
    public partial class MyLocalDataCacheClientSyncProvider : Microsoft.Synchronization.Data.SqlServerCe.SqlCeClientSyncProvider {
        
        public MyLocalDataCacheClientSyncProvider() {
            this.ConnectionString = global::AdoCert.Properties.Settings.Default.ClientAdventureWorksLTConnectionString;
        }
        
        public MyLocalDataCacheClientSyncProvider(string connectionString) {
            this.ConnectionString = connectionString;
        }
    }
    
    public partial class MyLocalDataCacheSyncAgent : Microsoft.Synchronization.SyncAgent {
        
        private SalesLT_ProductSyncTable _salesLT_ProductSyncTable;
        
        partial void OnInitialized();
        
        public MyLocalDataCacheSyncAgent() {
            this.InitializeSyncProviders();
            this.InitializeSyncTables();
            this.OnInitialized();
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public SalesLT_ProductSyncTable SalesLT_Product {
            get {
                return this._salesLT_ProductSyncTable;
            }
            set {
                this.Configuration.SyncTables.Remove(this._salesLT_ProductSyncTable);
                this._salesLT_ProductSyncTable = value;
                this.Configuration.SyncTables.Add(this._salesLT_ProductSyncTable);
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void InitializeSyncProviders() {
            // Create SyncProviders.
            this.RemoteProvider = new MyLocalDataCacheServerSyncProvider();
            this.LocalProvider = new MyLocalDataCacheClientSyncProvider();
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void InitializeSyncTables() {
            // Create SyncTables.
            this._salesLT_ProductSyncTable = new SalesLT_ProductSyncTable();
            this._salesLT_ProductSyncTable.SyncGroup = new Microsoft.Synchronization.Data.SyncGroup("SalesLT_ProductSyncTableSyncGroup");
            this.Configuration.SyncTables.Add(this._salesLT_ProductSyncTable);
        }
        
        public partial class SalesLT_ProductSyncTable : Microsoft.Synchronization.Data.SyncTable {
            
            partial void OnInitialized();
            
            public SalesLT_ProductSyncTable() {
                this.InitializeTableOptions();
                this.OnInitialized();
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private void InitializeTableOptions() {
                this.TableName = "SalesLT_Product";
                this.CreationOption = Microsoft.Synchronization.Data.TableCreationOption.DropExistingOrCreateNewTable;
            }
        }
    }
}
namespace AdoCert {
    
    
    public partial class SalesLT_ProductSyncAdapter : Microsoft.Synchronization.Data.Server.SyncAdapter {
        
        partial void OnInitialized();
        
        public SalesLT_ProductSyncAdapter() {
            this.InitializeCommands();
            this.InitializeAdapterProperties();
            this.OnInitialized();
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void InitializeCommands() {
            // SalesLT_ProductSyncTableInsertCommand command.
            this.InsertCommand = new System.Data.SqlClient.SqlCommand();
            this.InsertCommand.CommandText = @" SET IDENTITY_INSERT SalesLT.Product ON ;WITH CHANGE_TRACKING_CONTEXT (@sync_client_id_binary) INSERT INTO SalesLT.Product ([ProductID], [Name], [ProductNumber], [Color], [StandardCost], [ListPrice], [Size], [Weight], [ProductCategoryID], [ProductModelID], [SellStartDate], [SellEndDate], [DiscontinuedDate], [ThumbNailPhoto], [ThumbnailPhotoFileName], [rowguid], [ModifiedDate]) VALUES (@ProductID, @Name, @ProductNumber, @Color, @StandardCost, @ListPrice, @Size, @Weight, @ProductCategoryID, @ProductModelID, @SellStartDate, @SellEndDate, @DiscontinuedDate, @ThumbNailPhoto, @ThumbnailPhotoFileName, @rowguid, @ModifiedDate) SET @sync_row_count = @@rowcount; IF CHANGE_TRACKING_MIN_VALID_VERSION(object_id(N'SalesLT.Product')) > @sync_last_received_anchor RAISERROR (N'SQL Server Change Tracking has cleaned up tracking information for table ''%s''. To recover from this error, the client must reinitialize its local database and try again',16,3,N'SalesLT.Product')  SET IDENTITY_INSERT SalesLT.Product OFF ";
            this.InsertCommand.CommandType = System.Data.CommandType.Text;
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_client_id_binary", System.Data.SqlDbType.VarBinary));
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ProductID", System.Data.SqlDbType.Int));
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Name", System.Data.SqlDbType.NVarChar));
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ProductNumber", System.Data.SqlDbType.NVarChar));
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Color", System.Data.SqlDbType.NVarChar));
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@StandardCost", System.Data.SqlDbType.Money));
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ListPrice", System.Data.SqlDbType.Money));
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Size", System.Data.SqlDbType.NVarChar));
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Weight", System.Data.SqlDbType.Decimal));
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ProductCategoryID", System.Data.SqlDbType.Int));
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ProductModelID", System.Data.SqlDbType.Int));
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@SellStartDate", System.Data.SqlDbType.DateTime));
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@SellEndDate", System.Data.SqlDbType.DateTime));
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@DiscontinuedDate", System.Data.SqlDbType.DateTime));
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ThumbNailPhoto", System.Data.SqlDbType.VarBinary));
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ThumbnailPhotoFileName", System.Data.SqlDbType.NVarChar));
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@rowguid", System.Data.SqlDbType.UniqueIdentifier));
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ModifiedDate", System.Data.SqlDbType.DateTime));
            System.Data.SqlClient.SqlParameter insertcommand_sync_row_countParameter = new System.Data.SqlClient.SqlParameter("@sync_row_count", System.Data.SqlDbType.Int);
            insertcommand_sync_row_countParameter.Direction = System.Data.ParameterDirection.Output;
            this.InsertCommand.Parameters.Add(insertcommand_sync_row_countParameter);
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_last_received_anchor", System.Data.SqlDbType.BigInt));
            // SalesLT_ProductSyncTableDeleteCommand command.
            this.DeleteCommand = new System.Data.SqlClient.SqlCommand();
            this.DeleteCommand.CommandText = @";WITH CHANGE_TRACKING_CONTEXT (@sync_client_id_binary) DELETE SalesLT.Product FROM SalesLT.Product JOIN CHANGETABLE(VERSION SalesLT.Product, ([ProductID]), (@ProductID)) CT  ON CT.[ProductID] = SalesLT.Product.[ProductID] WHERE (@sync_force_write = 1 OR CT.SYS_CHANGE_VERSION IS NULL OR CT.SYS_CHANGE_VERSION <= @sync_last_received_anchor OR (CT.SYS_CHANGE_CONTEXT IS NOT NULL AND CT.SYS_CHANGE_CONTEXT = @sync_client_id_binary)) SET @sync_row_count = @@rowcount; IF CHANGE_TRACKING_MIN_VALID_VERSION(object_id(N'SalesLT.Product')) > @sync_last_received_anchor RAISERROR (N'SQL Server Change Tracking has cleaned up tracking information for table ''%s''. To recover from this error, the client must reinitialize its local database and try again',16,3,N'SalesLT.Product') ";
            this.DeleteCommand.CommandType = System.Data.CommandType.Text;
            this.DeleteCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_client_id_binary", System.Data.SqlDbType.VarBinary));
            this.DeleteCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ProductID", System.Data.SqlDbType.Int));
            this.DeleteCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_force_write", System.Data.SqlDbType.Bit));
            this.DeleteCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_last_received_anchor", System.Data.SqlDbType.BigInt));
            System.Data.SqlClient.SqlParameter deletecommand_sync_row_countParameter = new System.Data.SqlClient.SqlParameter("@sync_row_count", System.Data.SqlDbType.Int);
            deletecommand_sync_row_countParameter.Direction = System.Data.ParameterDirection.Output;
            this.DeleteCommand.Parameters.Add(deletecommand_sync_row_countParameter);
            // SalesLT_ProductSyncTableUpdateCommand command.
            this.UpdateCommand = new System.Data.SqlClient.SqlCommand();
            this.UpdateCommand.CommandText = @";WITH CHANGE_TRACKING_CONTEXT (@sync_client_id_binary) UPDATE SalesLT.Product SET [Name] = @Name, [ProductNumber] = @ProductNumber, [Color] = @Color, [StandardCost] = @StandardCost, [ListPrice] = @ListPrice, [Size] = @Size, [Weight] = @Weight, [ProductCategoryID] = @ProductCategoryID, [ProductModelID] = @ProductModelID, [SellStartDate] = @SellStartDate, [SellEndDate] = @SellEndDate, [DiscontinuedDate] = @DiscontinuedDate, [ThumbNailPhoto] = @ThumbNailPhoto, [ThumbnailPhotoFileName] = @ThumbnailPhotoFileName, [rowguid] = @rowguid, [ModifiedDate] = @ModifiedDate FROM SalesLT.Product  JOIN CHANGETABLE(VERSION SalesLT.Product, ([ProductID]), (@ProductID)) CT  ON CT.[ProductID] = SalesLT.Product.[ProductID] WHERE (@sync_force_write = 1 OR CT.SYS_CHANGE_VERSION IS NULL OR CT.SYS_CHANGE_VERSION <= @sync_last_received_anchor OR (CT.SYS_CHANGE_CONTEXT IS NOT NULL AND CT.SYS_CHANGE_CONTEXT = @sync_client_id_binary)) SET @sync_row_count = @@rowcount; IF CHANGE_TRACKING_MIN_VALID_VERSION(object_id(N'SalesLT.Product')) > @sync_last_received_anchor RAISERROR (N'SQL Server Change Tracking has cleaned up tracking information for table ''%s''. To recover from this error, the client must reinitialize its local database and try again',16,3,N'SalesLT.Product') ";
            this.UpdateCommand.CommandType = System.Data.CommandType.Text;
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Name", System.Data.SqlDbType.NVarChar));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ProductNumber", System.Data.SqlDbType.NVarChar));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Color", System.Data.SqlDbType.NVarChar));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@StandardCost", System.Data.SqlDbType.Money));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ListPrice", System.Data.SqlDbType.Money));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Size", System.Data.SqlDbType.NVarChar));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Weight", System.Data.SqlDbType.Decimal));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ProductCategoryID", System.Data.SqlDbType.Int));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ProductModelID", System.Data.SqlDbType.Int));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@SellStartDate", System.Data.SqlDbType.DateTime));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@SellEndDate", System.Data.SqlDbType.DateTime));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@DiscontinuedDate", System.Data.SqlDbType.DateTime));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ThumbNailPhoto", System.Data.SqlDbType.VarBinary));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ThumbnailPhotoFileName", System.Data.SqlDbType.NVarChar));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@rowguid", System.Data.SqlDbType.UniqueIdentifier));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ModifiedDate", System.Data.SqlDbType.DateTime));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ProductID", System.Data.SqlDbType.Int));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_force_write", System.Data.SqlDbType.Bit));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_last_received_anchor", System.Data.SqlDbType.BigInt));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_client_id_binary", System.Data.SqlDbType.VarBinary));
            System.Data.SqlClient.SqlParameter updatecommand_sync_row_countParameter = new System.Data.SqlClient.SqlParameter("@sync_row_count", System.Data.SqlDbType.Int);
            updatecommand_sync_row_countParameter.Direction = System.Data.ParameterDirection.Output;
            this.UpdateCommand.Parameters.Add(updatecommand_sync_row_countParameter);
            // SalesLT_ProductSyncTableSelectConflictDeletedRowsCommand command.
            this.SelectConflictDeletedRowsCommand = new System.Data.SqlClient.SqlCommand();
            this.SelectConflictDeletedRowsCommand.CommandText = "SELECT CT.[ProductID], CT.SYS_CHANGE_CONTEXT, CT.SYS_CHANGE_VERSION FROM CHANGETA" +
                "BLE(CHANGES SalesLT.Product, @sync_last_received_anchor) CT WHERE (CT.[ProductID" +
                "] = @ProductID AND CT.SYS_CHANGE_OPERATION = \'D\')";
            this.SelectConflictDeletedRowsCommand.CommandType = System.Data.CommandType.Text;
            this.SelectConflictDeletedRowsCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_last_received_anchor", System.Data.SqlDbType.BigInt));
            this.SelectConflictDeletedRowsCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ProductID", System.Data.SqlDbType.Int));
            // SalesLT_ProductSyncTableSelectConflictUpdatedRowsCommand command.
            this.SelectConflictUpdatedRowsCommand = new System.Data.SqlClient.SqlCommand();
            this.SelectConflictUpdatedRowsCommand.CommandText = @"SELECT SalesLT.Product.[ProductID], [Name], [ProductNumber], [Color], [StandardCost], [ListPrice], [Size], [Weight], [ProductCategoryID], [ProductModelID], [SellStartDate], [SellEndDate], [DiscontinuedDate], [ThumbNailPhoto], [ThumbnailPhotoFileName], [rowguid], [ModifiedDate], CT.SYS_CHANGE_CONTEXT, CT.SYS_CHANGE_VERSION FROM SalesLT.Product JOIN CHANGETABLE(VERSION SalesLT.Product, ([ProductID]), (@ProductID)) CT  ON CT.[ProductID] = SalesLT.Product.[ProductID]";
            this.SelectConflictUpdatedRowsCommand.CommandType = System.Data.CommandType.Text;
            this.SelectConflictUpdatedRowsCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ProductID", System.Data.SqlDbType.Int));
            // SalesLT_ProductSyncTableSelectIncrementalInsertsCommand command.
            this.SelectIncrementalInsertsCommand = new System.Data.SqlClient.SqlCommand();
            this.SelectIncrementalInsertsCommand.CommandText = @"IF @sync_initialized = 0 SELECT SalesLT.Product.[ProductID], [Name], [ProductNumber], [Color], [StandardCost], [ListPrice], [Size], [Weight], [ProductCategoryID], [ProductModelID], [SellStartDate], [SellEndDate], [DiscontinuedDate], [ThumbNailPhoto], [ThumbnailPhotoFileName], [rowguid], [ModifiedDate] FROM SalesLT.Product LEFT OUTER JOIN CHANGETABLE(CHANGES SalesLT.Product, @sync_last_received_anchor) CT ON CT.[ProductID] = SalesLT.Product.[ProductID] WHERE (CT.SYS_CHANGE_CONTEXT IS NULL OR CT.SYS_CHANGE_CONTEXT <> @sync_client_id_binary) ELSE  BEGIN SELECT SalesLT.Product.[ProductID], [Name], [ProductNumber], [Color], [StandardCost], [ListPrice], [Size], [Weight], [ProductCategoryID], [ProductModelID], [SellStartDate], [SellEndDate], [DiscontinuedDate], [ThumbNailPhoto], [ThumbnailPhotoFileName], [rowguid], [ModifiedDate] FROM SalesLT.Product JOIN CHANGETABLE(CHANGES SalesLT.Product, @sync_last_received_anchor) CT ON CT.[ProductID] = SalesLT.Product.[ProductID] WHERE (CT.SYS_CHANGE_OPERATION = 'I' AND CT.SYS_CHANGE_CREATION_VERSION  <= @sync_new_received_anchor AND (CT.SYS_CHANGE_CONTEXT IS NULL OR CT.SYS_CHANGE_CONTEXT <> @sync_client_id_binary)); IF CHANGE_TRACKING_MIN_VALID_VERSION(object_id(N'SalesLT.Product')) > @sync_last_received_anchor RAISERROR (N'SQL Server Change Tracking has cleaned up tracking information for table ''%s''. To recover from this error, the client must reinitialize its local database and try again',16,3,N'SalesLT.Product')  END ";
            this.SelectIncrementalInsertsCommand.CommandType = System.Data.CommandType.Text;
            this.SelectIncrementalInsertsCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_initialized", System.Data.SqlDbType.Bit));
            this.SelectIncrementalInsertsCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_last_received_anchor", System.Data.SqlDbType.BigInt));
            this.SelectIncrementalInsertsCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_client_id_binary", System.Data.SqlDbType.VarBinary));
            this.SelectIncrementalInsertsCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_new_received_anchor", System.Data.SqlDbType.BigInt));
            // SalesLT_ProductSyncTableSelectIncrementalDeletesCommand command.
            this.SelectIncrementalDeletesCommand = new System.Data.SqlClient.SqlCommand();
            this.SelectIncrementalDeletesCommand.CommandText = @"IF @sync_initialized > 0  BEGIN SELECT CT.[ProductID] FROM CHANGETABLE(CHANGES SalesLT.Product, @sync_last_received_anchor) CT WHERE (CT.SYS_CHANGE_OPERATION = 'D' AND CT.SYS_CHANGE_VERSION <= @sync_new_received_anchor AND (CT.SYS_CHANGE_CONTEXT IS NULL OR CT.SYS_CHANGE_CONTEXT <> @sync_client_id_binary)); IF CHANGE_TRACKING_MIN_VALID_VERSION(object_id(N'SalesLT.Product')) > @sync_last_received_anchor RAISERROR (N'SQL Server Change Tracking has cleaned up tracking information for table ''%s''. To recover from this error, the client must reinitialize its local database and try again',16,3,N'SalesLT.Product')  END ";
            this.SelectIncrementalDeletesCommand.CommandType = System.Data.CommandType.Text;
            this.SelectIncrementalDeletesCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_initialized", System.Data.SqlDbType.Bit));
            this.SelectIncrementalDeletesCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_last_received_anchor", System.Data.SqlDbType.BigInt));
            this.SelectIncrementalDeletesCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_new_received_anchor", System.Data.SqlDbType.BigInt));
            this.SelectIncrementalDeletesCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_client_id_binary", System.Data.SqlDbType.VarBinary));
            // SalesLT_ProductSyncTableSelectIncrementalUpdatesCommand command.
            this.SelectIncrementalUpdatesCommand = new System.Data.SqlClient.SqlCommand();
            this.SelectIncrementalUpdatesCommand.CommandText = @"IF @sync_initialized > 0  BEGIN SELECT SalesLT.Product.[ProductID], [Name], [ProductNumber], [Color], [StandardCost], [ListPrice], [Size], [Weight], [ProductCategoryID], [ProductModelID], [SellStartDate], [SellEndDate], [DiscontinuedDate], [ThumbNailPhoto], [ThumbnailPhotoFileName], [rowguid], [ModifiedDate] FROM SalesLT.Product JOIN CHANGETABLE(CHANGES SalesLT.Product, @sync_last_received_anchor) CT ON CT.[ProductID] = SalesLT.Product.[ProductID] WHERE (CT.SYS_CHANGE_OPERATION = 'U' AND CT.SYS_CHANGE_VERSION <= @sync_new_received_anchor AND (CT.SYS_CHANGE_CONTEXT IS NULL OR CT.SYS_CHANGE_CONTEXT <> @sync_client_id_binary)); IF CHANGE_TRACKING_MIN_VALID_VERSION(object_id(N'SalesLT.Product')) > @sync_last_received_anchor RAISERROR (N'SQL Server Change Tracking has cleaned up tracking information for table ''%s''. To recover from this error, the client must reinitialize its local database and try again',16,3,N'SalesLT.Product')  END ";
            this.SelectIncrementalUpdatesCommand.CommandType = System.Data.CommandType.Text;
            this.SelectIncrementalUpdatesCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_initialized", System.Data.SqlDbType.Bit));
            this.SelectIncrementalUpdatesCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_last_received_anchor", System.Data.SqlDbType.BigInt));
            this.SelectIncrementalUpdatesCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_new_received_anchor", System.Data.SqlDbType.BigInt));
            this.SelectIncrementalUpdatesCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_client_id_binary", System.Data.SqlDbType.VarBinary));
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void InitializeAdapterProperties() {
            this.TableName = "SalesLT_Product";
        }
    }
    
    public partial class MyLocalDataCacheServerSyncProvider : Microsoft.Synchronization.Data.Server.DbServerSyncProvider {
        
        private SalesLT_ProductSyncAdapter _salesLT_ProductSyncAdapter;
        
        partial void OnInitialized();
        
        public MyLocalDataCacheServerSyncProvider() {
            string connectionString = global::AdoCert.Properties.Settings.Default.AdventureWorksLT2008ConnectionString;
            this.InitializeConnection(connectionString);
            this.InitializeSyncAdapters();
            this.InitializeNewAnchorCommand();
            this.OnInitialized();
        }
        
        public MyLocalDataCacheServerSyncProvider(string connectionString) {
            this.InitializeConnection(connectionString);
            this.InitializeSyncAdapters();
            this.InitializeNewAnchorCommand();
            this.OnInitialized();
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public SalesLT_ProductSyncAdapter SalesLT_ProductSyncAdapter {
            get {
                return this._salesLT_ProductSyncAdapter;
            }
            set {
                this._salesLT_ProductSyncAdapter = value;
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void InitializeConnection(string connectionString) {
            this.Connection = new System.Data.SqlClient.SqlConnection(connectionString);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void InitializeSyncAdapters() {
            // Create SyncAdapters.
            this._salesLT_ProductSyncAdapter = new SalesLT_ProductSyncAdapter();
            this.SyncAdapters.Add(this._salesLT_ProductSyncAdapter);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void InitializeNewAnchorCommand() {
            // selectNewAnchorCmd command.
            this.SelectNewAnchorCommand = new System.Data.SqlClient.SqlCommand();
            this.SelectNewAnchorCommand.CommandText = "Select @sync_new_received_anchor = CHANGE_TRACKING_CURRENT_VERSION()";
            this.SelectNewAnchorCommand.CommandType = System.Data.CommandType.Text;
            System.Data.SqlClient.SqlParameter selectnewanchorcommand_sync_new_received_anchorParameter = new System.Data.SqlClient.SqlParameter("@sync_new_received_anchor", System.Data.SqlDbType.BigInt);
            selectnewanchorcommand_sync_new_received_anchorParameter.Direction = System.Data.ParameterDirection.Output;
            this.SelectNewAnchorCommand.Parameters.Add(selectnewanchorcommand_sync_new_received_anchorParameter);
        }
    }
}