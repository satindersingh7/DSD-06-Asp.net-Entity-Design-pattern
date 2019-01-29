using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer
{
    public class DAL
    {
        public static List<REGISTER> GetAllStudents()
        {
            List<REGISTER> lst = null;
            using (EntityEntities db = new EntityEntities())
            {
                lst = (from u in db.REGISTERs select u).ToList();
            }
            return lst;
        }

        public static List<address> GetAllAddress()
        {
            List<address> lst = null;
            using (EntityEntities db = new EntityEntities())
            {
                lst = (from u in db.addresses select u).ToList();
                return lst;
            }

        }

        public static List<checkout> GetAllcheckout()
        {
            List<checkout> lst = null;
            using (EntityEntities db = new EntityEntities())
            {
                var lst1 = (from u in db.checkouts select u).ToList();
                return lst;
            }

        }

        public static void InsertAddress(address insertadd)
        {
            using (EntityEntities db = new EntityEntities())
            {
                db.addresses.Add(insertadd);
                db.SaveChanges();
            }
        }

        public static List<REGISTER> GetUserDetails(string selectedValue)
        {
            List<REGISTER> lst = null;
            using (EntityEntities db = new EntityEntities())
            {
                lst = (from u in db.REGISTERs where u.ID.ToString() == selectedValue select u).ToList();
            }
            return lst;
        }

        public static void InsertBookDetails(book booksdetails)
        {
            using (EntityEntities db = new EntityEntities())
            {
                db.books.Add(booksdetails);
                db.SaveChanges();
            }
        }

        public static List<Login> GetDataTable(string username, string password)
        {
            try
            {
                List<Login> lst = null;
                using (EntityEntities db = new EntityEntities())
                {
                   lst = (from u in db.Logins where u.username == username && u.password==password select u).ToList();
                    return lst;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static List<book> GetAllBooks()
        {
            List<book> lst = null;
            using (EntityEntities db = new EntityEntities())
            {
                lst = (from u in db.books select u).ToList();
            }
            return lst;
        }

        public static void InsertCheckoutBooks(checkout checkoutdetails)
        {
            using (EntityEntities db = new EntityEntities())
            {
                db.checkouts.Add(checkoutdetails);
                db.SaveChanges();
            }
        }

        public static int SaveRegistration(REGISTER insertreg)
        {
            using (EntityEntities db = new EntityEntities())
            {
                db.REGISTERs.Add(insertreg);
                db.SaveChanges();
                return insertreg.ID;
            }
        }

        public static int UpdateRegistration(REGISTER insertreg)
        {
            using (EntityEntities db = new EntityEntities())
            {
               //Lembda expression

                REGISTER c = db.REGISTERs.SingleOrDefault(x => x.ID == insertreg.ID);
                c.FNAME = insertreg.FNAME;
                c.LNAME = insertreg.LNAME;
                c.EMAILID = insertreg.EMAILID;
                c.PASSWORD = insertreg.PASSWORD;
                db.SaveChanges();
                return insertreg.ID;
            }
        }

        public static void DeleteRecord(string insertreg)
        {
            using (EntityEntities db = new EntityEntities())
            {
                REGISTER c = db.REGISTERs.SingleOrDefault(x => x.ID.ToString().Trim() == insertreg.Trim());
                if (c != null)
                {
                    db.REGISTERs.Remove(c);
                    db.SaveChanges();
                }
                
            }
        }
    }
}
