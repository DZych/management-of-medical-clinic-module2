using Przychodnia.Class.DictionariesHanding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace ClinicUnitTests.Doctor
{
    public class SqlConnections 
    {
        public SqlConnections() 
        {
            ClassOffice o1 = new ClassOffice();
            o1.OfficeId = 1;
            o1.OfficeNumber = 2;

            ClassOffice o2 = new ClassOffice();
            o1.OfficeId = 2;
            o1.OfficeNumber = 3;



            listOfOfices = new List<ClassOffice>() { o1,o2 };


            ClassDoctor dct1 = new ClassDoctor();
            dct1.Active = true;
            dct1.Doctor_id = 20;
            dct1.Name = "Jan";
            dct1.Surname = "Nowak";
            dct1.OfficeNumber = 100;
            ClassDoctor dct2 = new ClassDoctor();
            dct2.Active = true;
            dct2.Doctor_id = 10;
            dct2.Name = "Tomasz";
            dct2.Surname = "Kowalski";
            dct2.OfficeNumber = 200;
            ListDoctor = new List<ClassDoctor>() { dct1, dct2 };


            ClassUser u1 = new ClassUser();
            u1.Login = "u1";
            u1.Password = "1";
            u1.Permission = new ClassPermission();
            u1.Permission.Permission = "Doctor";
            u1.User_id = 1;

            ClassUser u2 = new ClassUser();
            u2.Login = "u2";
            u2.Password = "2";
            u2.Permission = new ClassPermission();
            u2.Permission.Permission = "Doctor";
            u2.User_id = 2;
            ClassUser u3 = new ClassUser();
            u3.Login = "u3";
            u3.Password = "3";
            u3.Permission = new ClassPermission();
            u3.Permission.Permission = "Administrator";
            u3.User_id = 3;
            ListUser = new List<ClassUser>() { u1, u2,u3 };








        }

        #region Veriables
        static List<ClassOffice> listOfOfices;
        static List<ClassDoctor> ListDoctor;
        static List<ClassUser> ListUser;

        #endregion





        public int GetOfficeIdForDoctor(int idDoctor)

        {
            foreach (var d in ListDoctor) 
            {
                if (d.Doctor_id == idDoctor) 
                {
                    return d.OfficeNumber;
                }
            }
            return 0;


        }

        public string GetUserType(string login, string password) 
        {
            foreach (var u in ListUser) 
            {
                if (u.Login.Equals(login) && u.Password.Equals(password)) 
                {
                    return u.Permission.Permission;
                }

            }
            return null;
        
        }
        

        public int GetLoggedDoctorId(string login, string password) 
        {
            int loggedDoctor=0;

            foreach (var user in ListUser) 
            {

                if (user.Login.Equals(login) && user.Password.Equals(password)) 
                {
                    loggedDoctor = user.User_id;
                }
            
            }


            return loggedDoctor;
        }



    }
}
