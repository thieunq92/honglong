using System;
using System.Collections;
using System.IO;
using System.Web;
using GemBox.Spreadsheet;
using Portal.Modules.OrientalSails.Domain;

namespace Portal.Modules.OrientalSails.ReportEngine
{
    //public class CustomerDetails
    //{
    //    public static void OrientalSails(IList customers, DateTime startDate, string tplPath, HttpResponse response)
    //    {
    //        ExcelFile excelFile = new ExcelFile();
    //        excelFile.LoadXls(tplPath);

    //        ExcelWorksheet sheet = excelFile.Worksheets[0];
    //        // Dòng dữ liệu đầu tiên
    //        const int firstrow = 5;
    //        int crow = firstrow;
    //        sheet.Rows[crow].InsertCopy(customers.Count - 1, sheet.Rows[firstrow]);

    //        foreach (Customer customer in customers)
    //        {
    //            sheet.Cells[crow, 0].Value = crow - firstrow + 1;
    //            sheet.Cells[crow, 1].Value = customer.Fullname;
    //            if (customer.IsMale.HasValue)
    //            {
    //                if (customer.IsMale.Value)
    //                {
    //                    sheet.Cells[crow, 2].Value = "Male";
    //                }
    //                else
    //                {
    //                    sheet.Cells[crow, 3].Value = "Female";
    //                }
    //            }

    //            if (customer.Birthday.HasValue)
    //            {
    //                sheet.Cells[crow, 4].Value = customer.Birthday.Value;
    //            }

    //            sheet.Cells[crow, 5].Value = customer.Country;
    //            sheet.Cells[crow, 6].Value = customer.Passport;
    //            sheet.Cells[crow, 7].Value = customer.VisaNo;
    //            sheet.Cells[crow, 8].Value = customer.VisaExpired;
    //            sheet.Cells[crow, 9].Value = startDate;

    //            crow += 1;
    //        }

    //        response.Clear();
    //        response.Buffer = true;
    //        response.ContentType = "application/vnd.ms-excel";
    //        response.AppendHeader("content-disposition",
    //                              "attachment; filename=" + string.Format("customer{0:dd_MMM}", startDate));

    //        MemoryStream m = new MemoryStream();

    //        excelFile.SaveXls(m);

    //        response.OutputStream.Write(m.GetBuffer(), 0, m.GetBuffer().Length);
    //        response.OutputStream.Flush();
    //        response.OutputStream.Close();

    //        m.Close();
    //        response.End();
    //    }

    //    public static void Emotion(IList customers, DateTime startDate, string tplPath, HttpResponse response)
    //    {
    //        ExcelFile excelFile = new ExcelFile();
    //        excelFile.LoadXls(tplPath);

    //        ExcelWorksheet sheet = excelFile.Worksheets[0];
    //        // Dòng dữ liệu đầu tiên
    //        const int firstrow = 7;
    //        int crow = firstrow;

    //        IList checkinCustomers = new ArrayList();
    //        foreach (Customer customer in customers)
    //        {
    //            if (customer.Booking.StartDate == startDate)
    //            {
    //                checkinCustomers.Add(customer);
    //            }
    //        }

    //        sheet.Rows[crow].InsertCopy(checkinCustomers.Count - 1, sheet.Rows[firstrow]);

    //        sheet.Cells["F2"].Value = checkinCustomers.Count;
    //        IList countedRoom = new ArrayList();
    //        foreach (Customer customer in checkinCustomers)
    //        {
    //            sheet.Cells[crow, 0].Value = crow - firstrow + 1;
    //            sheet.Cells[crow, 1].Value = customer.Fullname;
    //            if (customer.IsMale.HasValue)
    //            {
    //                if (customer.IsMale.Value)
    //                {
    //                    sheet.Cells[crow, 2].Value = "Nam";
    //                }
    //                else
    //                {
    //                    sheet.Cells[crow, 2].Value = "Nữ";
    //                }
    //            }

    //            if (customer.Birthday.HasValue)
    //            {
    //                sheet.Cells[crow, 3].Value = customer.Birthday.Value;
    //            }

    //            if (customer.Nationality!=null)
    //            {
    //                sheet.Cells[crow, 4].Value = customer.Nationality.Code;
    //            }
    //            sheet.Cells[crow, 5].Value = customer.Passport;
    //            sheet.Cells[crow, 6].Value = customer.StayTerm;

    //            sheet.Cells[crow, 7].Value = customer.Booking.StartDate;
    //            sheet.Cells[crow, 8].Value = customer.Booking.EndDate;
    //            sheet.Cells[crow, 9].Value = (customer.Booking.EndDate - customer.Booking.StartDate).Days;                

    //            sheet.Cells[crow, 10].Value = string.Format("{0} {1}", customer.BookingRoom.RoomClass.Name,
    //                                                       customer.BookingRoom.RoomType.Name);
    //            if (customer.BookingRoom.Room!=null)
    //            {
    //                sheet.Cells[crow, 11].Value = customer.BookingRoom.Room.Name;
    //            }

    //            sheet.Cells[crow, 12].Value = customer.Booking.CustomBookingId;

    //            if (customer.Booking.Agency!=null)
    //            {
    //                sheet.Cells[crow, 13].Value = customer.Booking.Agency.Name;
    //            }
    //            sheet.Cells[crow, 14].Value = customer.StayIn;

    //            if (customer.Birthday.HasValue)
    //            {
    //                if (customer.Booking.StartDate.DayOfYear <= customer.Birthday.Value.DayOfYear && customer.Booking.EndDate.DayOfYear >= customer.Birthday.Value.DayOfYear)
    //                {
    //                    sheet.Cells[crow, 15].Value = "BIRTHDAY";
    //                }
    //            }

    //            crow += 1;
    //            if (!countedRoom.Contains(customer.BookingRoom))
    //            {
    //                countedRoom.Add(customer.BookingRoom);
    //            }
    //        }

    //        sheet.Cells["H2"].Value = countedRoom.Count;
    //        sheet.Cells["O1"].Value = startDate;
    //        response.Clear();
    //        response.Buffer = true;
    //        response.ContentType = "application/vnd.ms-excel";
    //        response.AppendHeader("content-disposition",
    //                              "attachment; filename=" + string.Format("customer{0:dd_MMM}", startDate));

    //        MemoryStream m = new MemoryStream();

    //        excelFile.SaveXls(m);

    //        response.OutputStream.Write(m.GetBuffer(), 0, m.GetBuffer().Length);
    //        response.OutputStream.Flush();
    //        response.OutputStream.Close();

    //        m.Close();
    //        response.End();
    //    }
    //}
}
