Public Class DAConstant

#Region "Form Hint Constants"
    Public Shared DA_SAVE_HINT As String = "Save records, If any existing records will be over written..."
    Public Shared DA_NEW_HINT As String = "Clears all fields for a new record..."
    Public Shared DA_DELETE_HINT As String = "Delete selected record..."
    Public Shared DA_CLOSE_HINT As String = "Close this window..."
    Public Shared DA_DISPLAYSELECTED_HINT As String = "Display selected record to edit..."
    Public Shared DA_REFRESH_HINT As String = "Refresh current grid..." 
    Public Shared DA_PRINT_HINT As String = "Print selected record..."



    Public Shared DA_CE_HINT As String = "This Liist Contains Only last Two Months Records. When Other Reocord In Need, Type And Search..."
    Public Shared DA_SEARCH_HINT As String = "Search the Bill..."
    Public Shared DA_UPDATE_HINT As String = "Update existing Bill..."

#End Region

#Region "Database Connection"
    Public Shared DA_DBCONNECTION_STRING As String = "DAOpticiansConnetionString"
#End Region

#Region "Start Up Stored Procedure Constants"
    Public Shared DA_SUPPLIER_INSERT As String = "Supplier_Insert"
    Public Shared DA_SUPPLIER_DELETE As String = "Supplier_Delete"
    Public Shared DA_SUPPLIER_GETBYID As String = "Supplier_GetByID"
    Public Shared DA_SUPLLIER_GETALL As String = "Supplier_GetAll"

    Public Shared DA_DOCTOR_INSERT As String = "Doctor_Insert"
    Public Shared DA_DOCTOR_DELETE As String = "Doctor_Delete"
    Public Shared DA_DOCTOR_GETALL As String = "Doctor_GetAll"
    Public Shared DA_DOCTOR_GETBYID As String = "Doctor_GetByID"

    Public Shared DA_CUSTOMER_INSERT As String = "Customer_Insert"
    Public Shared DA_CUSTOMER_GETBYID As String = "Customer_GetByID"
    Public Shared DA_CUSTOMER_GETALL As String = "Customer_GetAll"
    Public Shared DA_CUSTOMER_DELETE As String = "Doctor_GetByID"

    Public Shared DA_EMPLOYER_INSERT As String = "Employer_Insert"
    Public Shared DA_EMPLOYER_DELETE As String = "Employer_Delete"
    Public Shared DA_EMPLOYER_GETBYID As String = "Employer_GetByID"
    Public Shared DA_EMPLOYER_GETALL As String = "Employer_GetAll"

    Public Shared DA_BANKS_INSERT As String = "Banks_Insert"
    Public Shared DA_BANKS_DELETE As String = "Banks_Delete"
    Public Shared DA_BANKS_GETBYID As String = "Banks_GetByID"
    Public Shared DA_BANKS_GETALL As String = "Banks_GetAll"
    Public Shared DA_BANKS_ISACCOUNTNOEXISTS As String = "Banks_IsAccountNoExists"

    Public Shared DA_STOCK_INSERT As String = "Stock_Insert"
    Public Shared DA_STOCK_DELETE As String = "Stock_Delete"
    Public Shared DA_STOCK_GETALL As String = "Stock_GetAll"
    Public Shared DA_STOCK_GETBYID As String = "Stock_GetByID" 

    Public Shared DA_STOCKCATEGORY_GETALL As String = "StockCategory_GetAll"
    Public Shared DA_STOCKCATEGORY_DELETE As String = "StockCategory_Delete"
    Public Shared DA_STOCKCATEGORY_INSERT As String = "StockCategory_Insert"
    Public Shared DA_STOCKCATEGORY_UPDATE As String = "StockCategory_Update"
    Public Shared DA_STOCK_ISSTOCKEXISTS As String = "Stock_IsStockExists"


    Public Shared DA_DESIGNATION_DELETE As String = "Designation_Delete"
    Public Shared DA_DESIGNATION_GETALL As String = "Designation_GetAll"
    Public Shared DA_DESIGNATION_INSERT As String = "Designation_Insert"

    Public Shared DA_COMPANY_INSERT As String = "Company_Insert"
    Public Shared DA_COMPANY_GETALL As String = "Company_GetAll"


    Public Shared USERLOGIN_DELETE As String = "UserLogin_Delete"
    Public Shared USERLOGIN_GETALL As String = "UserLogin_GetAll"
    Public Shared USERLOGIN_GETBYID As String = "UserLogin_GetByID"
    Public Shared USERLOGIN_INSERT As String = "UserLogin_Insert"
    Public Shared USERLOGIN_ISUSERNAMEEXISTS As String = "UserLogin_IsUserNameExists"
    Public Shared USERLOGIN_GETBYUSERNAMEANDPASSWORD As String = "UserLogin_GetByUserNameAndPassword"


#End Region

#Region "Prescription Stored Procedure Constants"
    Public Shared DA_PRESCRIPTION_INSERT As String = "Prescription_Insert"
    Public Shared DA_PRESCRIPTION_SELECT_POP As String = "Prescription_Select_Pop"
    Public Shared DA_PRESCRIPTION_SELECTBYID As String = "Prescription_SelectByID"
    Public Shared DA_PRESCRIPTIONINTERNAL_INSERT As String = "PrescriptionInternal_Insert"
    Public Shared DA_PRESCRIPTIONINTERNAL_SELECTBYID As String = "PrescriptionInternal_SelectByID"
    Public Shared DA_PRESCRIPTIONEXTERNAL_INSERT As String = "PrescriptionExternal_Insert"
    Public Shared DA_PRESCRIPTIONEXTERNAL_SELECTBYID As String = "PrescriptionExternal_SelectByID"
    Public Shared DA_PRESCRIPTION_GETBYDATES As String = "Prescription_GetByDates"
    Public Shared DA_PRESCRIPTION_REMINDER As String = "Prescription_Reminder"
    Public Shared DA_PRESCRIPTION_GETBYALL As String = "Prescription_GetByall"


    Public Shared PRESCRIPTIONHBRX_INSERT As String = "PrescriptionHbRx_Insert"
    Public Shared PRESCRIPTIONHBRX_SELECTBYID As String = "PrescriptionHbRx_SelectByID"


#End Region

#Region "Quotation Stored Procedure Constants"

    Public Shared DA_QUOTATION_INSERT As String = "Quotation_Insert"
    Public Shared DA_QUOTATION_DELETE As String = "Quotation_Delete"
    Public Shared DA_QUOTATION_SELECT_POP As String = "Quotation_Select_Pop"
    Public Shared DA_QUOTATION_GETBYID As String = "Quotation_GetByID"
    Public Shared DA_QUOTATION_GETALL As String = "Quotation_GetAll"

#End Region

#Region "Hearing Quotation Stored Procedure Constants"

    Public Shared DA_HEARINGQUOTATION_DELETE As String = "HearingQuotation_Delete"
    Public Shared DA_HEARINGQUOTATION_GETALL As String = "HearingQuotation_GetAll"
    Public Shared DA_HEARINGQUOTATION_GETBYID As String = "HearingQuotation_GetByID"
    Public Shared DA_HEARINGQUOTATION_INSERT As String = "HearingQuotation_Insert"

#End Region

#Region "Purchases Stored Procedures Constant"
    Public Shared DA_PURCHASES_INSERT As String = "Purchases_Insert"
    Public Shared DA_PURCHASES_GETALL As String = "Purchases_GetAll"
    Public Shared DA_PURCHASES_GETBYID As String = "Purchases_GetByID"

    Public Shared DA_PURCHASESDESCRIPTION_INSERT As String = "PurchasesDescription_Insert"
    Public Shared DA_PURCHASESDESCRIPTION_GETBYID As String = "PurchasesDescription_GetByID"
    Public Shared DA_PURCHASESDESCRIPTION_DELETE As String = "PurchasesDescription_Delete"

    Public Shared DA_STOCK_REMOVEFROMPURCHASE As String = "Stock_RemoveFromPurchase"
    Public Shared DA_PURCHASES_UPDTESTOCK As String = "Stock_UpdateByPurchase"
    Public Shared DA_PURCHASESCOLLECTION_DELETE As String = "PurchasesCollection_Delete"

#End Region

#Region "Purchase Order Stored Procedures Constant"
    Public Shared DA_PURCHASEORDER_GETALL As String = "PurchaseOrder_GetAll"
    Public Shared DA_PURCHASEORDER_GETBYID As String = "PurchaseOrder_GetByID"
    Public Shared DA_PURCHASEORDER_INSERT As String = "PurchaseOrder_Insert"

    Public Shared DA_PURCHASEORDERDESCRIPTION_DELETE As String = "PurchaseOrderDescription_Delete"
    Public Shared DA_PURCHASEORDERDESCRIPTION_GETBYID As String = "PurchaseOrderDescription_GetByID"
    Public Shared DA_PURCHASEORDERDESCRIPTION_INSERT As String = "PurchaseOrderDescription_Insert"


#End Region

#Region "POrder"

    Public Shared DA_PORDER_INSERT As String = "POrder_Insert"
    Public Shared DA_PORDER_DELETE As String = "POrder_Delete"
    Public Shared DA_PORDER_GETALL As String = "POrder_GetAll"
    Public Shared DA_PORDER_GETBYID As String = "POrder_GetByID"

#End Region

#Region "Sales Stored Procedures Constant"
    Public Shared DA_SALES_INSERT As String = "Sales_Insert"
    Public Shared DA_SALES_GETALL As String = "Sales_GetAll"
    Public Shared DA_SALES_GETBYID As String = "Sales_GetByID"

    Public Shared DA_SALESDESCRIPTION_INSERT As String = "SalesDescription_Insert"
    Public Shared DA_SALESDESCRIPTION_GETBYID As String = "SalesDescription_GetByID"
    Public Shared DA_SALESDESCRIPTION_DELETE As String = "SalesDescription_Delete"

    Public Shared DA_STOCK_UPDATEBYSALES As String = "Stock_UpdateBySales"
    Public Shared DA_STOCK_ADDROMSALES As String = "Stock_AddFromSales"


#End Region

#Region "Pay Bills Stored Procedures Constants"
    Public Shared DA_PURCHASE_UNSETTLED_BILLS As String = "Purchase_Unsettled_Bills"
    Public Shared DA_PURCHASE_SETTLED_BILLS As String = "Purchase_Settled_Bills"
#End Region

#Region "Receive Payment Stored Procedures Constants"

    Public Shared DA_SALES_SETTLED_BILLS As String = "Sales_Settled_Bills"
    Public Shared DA_SALES_UNSETTLED_BILLS As String = "Sales_Unsettled_Bills"
#End Region

#Region "Expnese Stored Procedures"
    Public Shared DA_EXPENSES_DELETE As String = "Expenses_Delete"
    Public Shared DA_EXPENSES_GETALL As String = "Expenses_GetAll"
    Public Shared DA_EXPENSES_INSERT As String = "Expenses_Insert"
    Public Shared DA_EXPENSE_GETBYID As String = "Expense_GetByID"


    Public Shared DA_EXPENSETYPES_INSERT As String = "ExpenseTypes_Insert"
    Public Shared DA_EXPENSETYPES_DELETE As String = "ExpenseTypes_Delete"
    Public Shared DA_EXPENSETYPES_GETALL As String = "ExpenseTypes_GetAll"

#End Region

#Region "Collection Stored Procedures Constant"

    Public Shared DA_COLLECTION_INSERT As String = "Collection_Insert"
    Public Shared DA_COLLECTION_DELETE As String = "Collection_Delete"
    Public Shared DA_COLLECTION_GETBYID As String = "Collection_GetByID"
    Public Shared DA_COLLECTION_GETALL As String = "Collection_GetAll"
    Public Shared DA_DAYBOOK_GETBYDATES As String = "DayBook_GetByDates"


#End Region

#Region "Receipts Stored Procedures"

    Public Shared DA_RECEIPTS_DELETE As String = "Receipts_Delete"
    Public Shared DA_RECEIPTS_GETBYDATES As String = "Receipts_GetByDates"
    Public Shared DA_RECEIPTS_GETBYID As String = "Receipts_GetByID"
    Public Shared DA_RECEIPTS_INSERT As String = "Receipts_Insert"
    Public Shared DA_RECEIPTS_GETBYPRESCRIPTIONID As String = "Receipts_GetByPrescriptionID"

    Public Shared DA_RECEIPTSDESCRIPTION_DELETE As String = "ReceiptsDescription_Delete"
    Public Shared DA_RECEIPTSDESCRIPTION_INSERT As String = "ReceiptsDescription_Insert"
    Public Shared DA_RECEIPTSDESCRIPTIONGETBYRECEIPTID As String = "ReceiptsDescriptionGetByReceiptID"
    Public Shared DA_RECEIPTSDESCRIPTION_UPDATE As String = "ReceiptsDescription_Update"

    Public Shared DA_STOCK_ADDFROMRECEIPT As String = "Stock_AddFromReceipt"



#End Region

#Region " Price Preset / Price List Stores Precedures"

    Public Shared DA_PRICEPRESET_GETALL As String = "PricePreset_GetAll"
    Public Shared DA_PRICEPRESET_UPDATE As String = "PricePreset_Update"

    Public Shared DA_PRICELIST_DELETE As String = "PriceList_Delete"
    Public Shared DA_PRICELIST_INSERT As String = "PriceList_Insert"
    Public Shared DA_PRICELISTGETALL As String = "PriceListGetAll"
    Public Shared DA_PRICELISTGETBYID As String = "PriceListGetByID"




#End Region

#Region "Message Constant"

    Public Shared DA_DELETE_CONFIRMATION_TITLE As String = "Delete The Current Record?"
    Public Shared DA_DELETE_CONFIRMATION_TITLELABEL As String = "Are you sure you want to delete the selected record?"
    Public Shared DA_DELETE_CONFIRMATION_DESCRIPTIONLABEL As String = "Click Yes to Delete..."

    Public Shared DA_DELETE_ERROR_CONFIRMATION_TITLE As String = "Can not delete the record"
    Public Shared DA_DELETE_ERROR_CONFIRMATION_TITLELABEL As String = "This record contains references to other tables, To delete the record, delete the reference records first and try again"
    Public Shared DA_DELETE_ERROR_CONFIRMATION_DESCRIPTIONLABEL As String = "Click OK to continue"

    Public Shared DA_SAVESUCCESS_CONFIRMATION_TITLE As String = "Record Saved"
    Public Shared DA_SAVESUCCESS_CONFIRMATION_TITLELABEL As String = "Record saved succuessfully"
    Public Shared DA_SAVESUCCESS_CONFIRMATION_DESCRIPTIONLABEL As String = "Click OK to continue"

    Public Shared DA_USERLOGIN_CONFIRMATION_TITLE As String = "User Name Already Exists"
    Public Shared DA_USERLOGIN_CONFIRMATION_TITLELABEL As String = "You can not save this records, Change User Name and save"
    Public Shared DA_USERLOGIN_CONFIRMATION_DESCRIPTIONLABEL As String = "Click Ok to continue"

    Public Shared DA_UPDATE_CONFIRMATION_TITLE As String = "Record already exists"
    Public Shared DA_UPDATE_CONFIRMATION_TITLELABEL As String = "Do you want to replace the selected record?"
    Public Shared DA_UPDATE_CONFIRMATION_DESCRIPTIONLABEL As String = "Click Yes to replace"

#End Region


End Class
