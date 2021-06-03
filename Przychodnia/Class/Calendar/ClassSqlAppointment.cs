using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

using Przychodnia.Class.Doctor;

namespace Przychodnia.Class.Calendar
{
    public class ClassSqlAppointment
    {

        public static List<ClassTerm> AppointmentsDateForCombobox()
        {
            string querry = "SELECT * FROM [dbo].[tbl_Term] WHERE [dbo].[tbl_Term].Date >= GETDATE() AND Doctor_id =" + ClassLoggedDoctor.Doctor_Id;
            SqlDataReader dr = ClassQuerry.ExecuteQuerry(querry);
            List<ClassTerm> terms = new List<ClassTerm>();
            while (dr.Read())
            {
                ClassTerm termsCombobox = new ClassTerm();
                termsCombobox.TermId = dr.GetInt32("Term_id");
                termsCombobox.StartTime = dr.GetTimeSpan(1);
                termsCombobox.EndTime= dr.GetTimeSpan(2);
                termsCombobox.Date= dr.GetDateTime("Date");
                
                terms.Add(termsCombobox);
            }
            ClassQuerry.CloseConnection();
            return terms;
        }
    }
}
