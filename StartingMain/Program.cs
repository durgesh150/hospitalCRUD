using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace hospitalCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            myhospitaldbcontext dbobj = new myhospitaldbcontext();
            Console.WriteLine("How Many Records do you want to insert in DataBase");
            int rec = Convert.ToInt32(Console.ReadLine());
            AddUserData.AddPatientData(rec);
            if (dbobj.Appusertable.Count() == 0)
            {
                AddUserData.AddAdminData();
            }
            Console.WriteLine("\nPress any key to Exit");
            Console.ReadKey();
        }
    }
}

