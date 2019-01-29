using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer;

namespace BusinessLayer
{
    public class BAL
    {
        public static List<REGISTER> GetAllUsers()
        {
            return DAL.GetAllStudents();
        }

        public static int InsertRegister(REGISTER insertreg)
        {
            return DAL.SaveRegistration(insertreg);
        }

        public static int UpdateStudentDetails(REGISTER insertreg)
        {
            return DAL.UpdateRegistration(insertreg);
        }

        public static List<book> GetAllBooks()
        {
            return DAL.GetAllBooks();
        }

        public static void InsertBooksCollected(checkout checkoutdetails)
        {
            DAL.InsertCheckoutBooks(checkoutdetails);
        }

        public static List<address> GetAlladdress()
        {
            return DAL.GetAllAddress();
        }

        public static List<checkout> GetAllcheckout()
        {
            return DAL.GetAllcheckout();
        }

        public static void InsertAddress(address insertadd)
        {
            DAL.InsertAddress(insertadd);
        }

        public static List<REGISTER> GetUser(string selectedValue)
        {
            return DAL.GetUserDetails(selectedValue);
        }

        public static void DeleteRecord(string selectedValue)
        {
            DAL.DeleteRecord(selectedValue);
        }

        public static void InsertBookDetails(book booksdetails)
        {
            DAL.InsertBookDetails(booksdetails);
        }

        public static List<Login> GetDataTable(string username, string password)
        {
          return DAL.GetDataTable(username,password);
        }

    }
}
