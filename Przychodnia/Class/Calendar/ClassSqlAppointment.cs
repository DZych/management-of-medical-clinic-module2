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

        public static List<ClassAppointment> AppointmentsForDataGrid(DateTime date)
        {
            string querry = "SELECT dbo.tbl_Appointment.Appointment_id, [dbo].[tbl_Appointment].Start_time, [dbo].[tbl_Patient].Name, [dbo].[tbl_Patient].Surname, [dbo].[tbl_Patient].Personal_identity_number, [dbo].[tbl_Patient].Patient_id, [dbo].[tbl_Appointment].Topic  FROM [dbo].[tbl_Appointment], [dbo].[tbl_Patient] WHERE Term_id = ( SELECT tbl_Term.Term_id FROM [dbo].[tbl_Term] WHERE tbl_Term.Date = N'" + date.ToString("yyyy-MM-dd") + "' AND [dbo].[tbl_Term].Doctor_id = " + ClassLoggedDoctor.Doctor_Id + ") AND [dbo].[tbl_Appointment].Patient_id = [dbo].[tbl_Patient].Patient_id";
            SqlDataReader dr = ClassQuerry.ExecuteQuerry(querry);
            List<ClassAppointment> appointment = new List<ClassAppointment>();
            while (dr.Read())
            {
                ClassAppointment appointmentDataGrid = new ClassAppointment();
                appointmentDataGrid.AppointmendtId = dr.GetInt32("Appointment_id"); 
                appointmentDataGrid.StartTime = dr.GetTimeSpan(1);
                appointmentDataGrid.PatientName = dr.GetString("Name");
                appointmentDataGrid.PatientSurname = dr.GetString("Surname");
                appointmentDataGrid.NrPesel = dr.GetString("Personal_identity_number");
                appointmentDataGrid.PacientID = dr.GetInt32("Patient_id");
                appointmentDataGrid.Topic = dr.GetString("Topic");
                
                appointment.Add(appointmentDataGrid);
            }
            ClassQuerry.CloseConnection();
            return appointment;
        }

        public static List<ClassAppointment> GetAllApoitmentsForPatien(ClassAppointment getAppointment)
        {
            string querry = "SELECT Appointment_id, [dbo].[tbl_Appointment].Start_time, Patient_id, [dbo].[tbl_Appointment].Term_id, ToPay, add_description, Topic, Date, Name, Surname, Personal_identity_number FROM [dbo].[tbl_Appointment], [dbo].[tbl_Term], [dbo].[tbl_Doctor], [dbo].[tbl_Employee] WHERE [dbo].[tbl_Appointment].Patient_id = " + getAppointment.PacientID + " AND [dbo].[tbl_Term].Term_id = [dbo].[tbl_Appointment].Term_id AND [dbo].[tbl_Term].Doctor_id = [dbo].[tbl_Doctor].Doctor_id AND [dbo].[tbl_Doctor].Employee_id = [dbo].[tbl_Employee].Employee_id";

            

            SqlDataReader dr = ClassQuerry.ExecuteQuerry(querry);
            List<ClassAppointment> appointment = new List<ClassAppointment>();
            while (dr.Read())
            {
                ClassAppointment appointmentDataGrid = new ClassAppointment();
                appointmentDataGrid.AppointmendtId = dr.GetInt32("Appointment_id");
                appointmentDataGrid.StartTime = dr.GetTimeSpan(1);
                appointmentDataGrid.PatientName = dr.GetString("Name");
                appointmentDataGrid.PatientSurname = dr.GetString("Surname");
                appointmentDataGrid.NrPesel = dr.GetString("Personal_identity_number");
                appointmentDataGrid.PacientID = dr.GetInt32("Patient_id");
                appointmentDataGrid.Topic = dr.GetString("Topic");
                appointmentDataGrid.Date = dr.GetDateTime(7);
                appointmentDataGrid.NameDoctor = dr.GetString("Name");
                appointmentDataGrid.SurnameDoctor = dr.GetString("Surname");
                appointmentDataGrid.Add_description = dr.GetString("add_description");
                

                appointment.Add(appointmentDataGrid);
            }
            ClassQuerry.CloseConnection();
            return appointment;
        }
    }
}
