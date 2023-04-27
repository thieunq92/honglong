﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portal.Modules.OrientalSails.Enums
{
    public enum PermissionEnum
    {
        //Permission Name = Permission Id
        FORM_BOOKINGREPORT = 1,
        FORM_BOOKINGREPORTPERIODALL = 2,
        FORM_BOOKINGREPORTPERIOD = 3,
        FORM_ORDERREPORT = 4,
        FORM_TRACKINGREPORT = 5,
        FORM_INCOMEREPORT = 6,
        FORM_PAYMENTREPORT = 7,
        FORM_EXPENSEREPORT = 8,
        FORM_PAYABLELIST = 9,
        FORM_BALANCEREPORT = 10,
        FORM_AGENCYEDIT = 11,
        FORM_AGENCYLIST = 12,
        FORM_AGENTLIST = 13,
        FORM_SAILSTRIPEDIT = 14,
        FORM_SAILSTRIPLIST = 15,
        FORM_CRUISESEDIT = 16,
        FORM_CRUISESLIST = 17,
        FORM_ROOMCLASSEDIT = 18,
        FORM_ROOMTYPEXEDIT = 19,
        FORM_ROOMEDIT = 20,
        FORM_ROOMLIST = 21,
        FORM_EXTRAOPTIONEDIT = 22,
        FORM_COSTING = 23,
        FORM_CRUISECONFIG = 24,
        FORM_EXCHANGERATE = 25,
        FORM_COSTTYPES = 26,
        FORM_ADDBOOKING = 27,
        FORM_BOOKINGLIST = 28,
        FORM_AGENCYSELECTORPAGE = 29,
        VIEW_ALLBOOKINGRECEIVABLE = 30,
        ACTION_EXPORTCONGNO = 31,
        ACTION_EXPORTSELFSALES = 32,
        ACTION_EXPORTREVENUE = 33,
        ACTION_EXPORTREVENUEBYSALE = 34,
        FORM_BOOKINGPAYMENT = 37,
        FORM_RECEIVABLETOTAL = 38,
        ACTION_EXPORTAGENCY = 39,
        FORM_EXPENSEPERIOD = 40,
        ACTION_EDITAGENCY = 41,
        LOCK_INCOME = 42,
        EDIT_AFTER_LOCK = 43,
        EDIT_TOTAL = 44,
        EDIT_TRIP_AFTER = 45,
        EDIT_SALE_IN_CHARGE = 46,
        VIEW_TOTAL_BY_DATE = 47,
        VIEW_ALL_AGENCY = 48,
        VIEWBOOKINGBYAGENCY = 49,
        CONTACTS = 50,
        RECENTACTIVITIES = 51,
        CONTRACTS = 52,
        ADDSERIES = 53,
        VIEWALLSERIES = 54,
        CANCELALLSERIES = 55,
        AllowLockBooking = 56,
        AllowUnlockBooking = 57,
        AllowAccessDashboardPage = 58,
        AllowAccessBookingAddingPage = 59,
        AllowAccessBookingManagementPage = 60,
        AllowAccessBookingManagementByDatePage = 61,
        AllowAccessRevenuePage = 62,
        AllowAccessReceivablesPage = 63,
        AllowAccessReportVATPage = 64,
        AllowAccessReportDebtReceivablePage = 65,
        AllowAccessBankAccountListPage = 66,
        AllowAccessReportAccountPaymentPage = 67,
        AllowAccessMenuAddingPage = 68,
        AllowAccessMenuManagementPage = 69,
        AllowAddBooking = 70,
        AllowAccessBookingViewingPage = 71,
        AllowEditBooking = 72,
        AllowViewHistoryBooking = 73,
        AllowExportSalesReport = 74,
        AllowExportForKitchen = 75,
        AllowPaymentBooking = 76,
        AllowExportMenu = 77,
        AllowExportRevenue = 78,
        AllowExportReceivable = 79,
        AllowAccessPayment = 80,
        AllowSaveVAT = 81,
        AllowExportVAT = 82,
        AllowExportDebtReceivables = 83,
        AllowAddBankAccount = 84,
        AllowEditBankAccount = 85,
        AllowExportAccountPayment = 86,
        AllowAddMenu = 87,
        AllowAccessMenuEditingPage = 88,
        AllowEditMenu = 89,
        AllowAccessAddAgencyPage = 90,
        AllowAccessEditAgencyPage = 91,
        AllowAddAgency = 92,
        AllowEditAgency = 93,
        AllowChangeSalesIncharge = 94,
        AllowAccessAgencyManagementPage = 95,
        AllowAllSalesInChargeFilter = 96,
    }
}