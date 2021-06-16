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
                appointmentDataGrid.Patient = new DictionariesHanding.ClassPatient();
                appointmentDataGrid.Patient.Name = dr.GetString("Name");
                appointmentDataGrid.Patient.Surname = dr.GetString("Surname");
                appointmentDataGrid.Patient.PersonalIdentityNumber = dr.GetString("Personal_identity_number");
                appointmentDataGrid.Patient.PatientId = dr.GetInt32("Patient_id");
                appointmentDataGrid.Topic = dr.GetString("Topic");
                
                appointment.Add(appointmentDataGrid);
            }
            ClassQuerry.CloseConnection();
            return appointment;
        }

        public static List<ClassAppointment> GetAllApoitmentsForPatien(ClassAppointment getAppointment)
        {
            string querry = "SELECT Appointment_id, [dbo].[tbl_Appointment].Start_time, Patient_id, [dbo].[tbl_Appointment].Term_id, ToPay, add_description, Topic, Date, Name, Surname, Personal_identity_number FROM [dbo].[tbl_Appointment], [dbo].[tbl_Term], [dbo].[tbl_Doctor], [dbo].[tbl_Employee] WHERE [dbo].[tbl_Appointment].Patient_id = " + getAppointment.Patient.PatientId + " AND [dbo].[tbl_Term].Term_id = [dbo].[tbl_Appointment].Term_id AND [dbo].[tbl_Term].Doctor_id = [dbo].[tbl_Doctor].Doctor_id AND [dbo].[tbl_Doctor].Employee_id = [dbo].[tbl_Employee].Employee_id";

            

            SqlDataReader dr = ClassQuerry.ExecuteQuerry(querry);
            List<ClassAppointment> appointment = new List<ClassAppointment>();
            while (dr.Read())
            {
                ClassAppointment appointmentDataGrid = new ClassAppointment();
                appointmentDataGrid.AppointmendtId = dr.GetInt32("Appointment_id");
                appointmentDataGrid.StartTime = dr.GetTimeSpan(1);
                appointmentDataGrid.Patient = new DictionariesHanding.ClassPatient();
                appointmentDataGrid.Patient.Name = dr.GetString("Name");
                appointmentDataGrid.Patient.Surname = dr.GetString("Surname");
                appointmentDataGrid.Patient.PersonalIdentityNumber = dr.GetString("Personal_identity_number");
                appointmentDataGrid.Patient.PatientId = dr.GetInt32("Patient_id");
                appointmentDataGrid.Topic = dr.GetString("Topic");
                appointmentDataGrid.Term = new ClassTerm();
                appointmentDataGrid.Term.Date = dr.GetDateTime(7);
                appointmentDataGrid.Doctor = new DictionariesHanding.ClassDoctor();
                appointmentDataGrid.Doctor.Employee = new DictionariesHanding.ClassEmployee();
                appointmentDataGrid.Doctor.Employee.Name = dr.GetString("Name");
                appointmentDataGrid.Doctor.Employee.Surname = dr.GetString("Surname");
                try
                {
                    appointmentDataGrid.Description = dr.GetString("add_description");
                }
                catch (System.Data.SqlTypes.SqlNullValueException ex)
                {
                    appointmentDataGrid.Description = "Brak";
                }


                appointment.Add(appointmentDataGrid);
            }
            ClassQuerry.CloseConnection();
            return appointment;
        }

        public static List<ClassAppointment>GetAllAppoitments()
        {
            string querry = "SELECT [dbo].[tbl_Appointment].[Appointment_id], [dbo].[tbl_Term].Date, [dbo].[tbl_Patient].Patient_id, [dbo].[tbl_Patient].Name AS Patient_name, [dbo].[tbl_Patient].Surname AS Patient_surname, " +
                                    "[dbo].[tbl_Patient].Personal_identity_number as PESEL, [dbo].[tbl_Patient].Phone_number AS Patient_phone_number," +
                                    "[dbo].[tbl_Doctor].Doctor_id, [dbo].[tbl_Employee].Name AS Doctor_name, [dbo].[tbl_Employee].Surname AS Doctor_surname, " +
                                    "[dbo].[tbl_Appointment].add_description as Description, [dbo].[tbl_Appointment].Topic " +
                            "FROM[dbo].[tbl_Appointment], [dbo].[tbl_Term], [dbo].[tbl_Doctor], [dbo].[tbl_Employee], [dbo].[tbl_Patient]" +
                            "WHERE[dbo].[tbl_Term].Term_id = [dbo].[tbl_Appointment].Term_id AND[dbo].[tbl_Term].Doctor_id = [dbo].[tbl_Doctor].Doctor_id AND[dbo].[tbl_Doctor].Employee_id = [dbo].[tbl_Employee].Employee_id AND[dbo].[tbl_Appointment].Patient_id = [dbo].[tbl_Patient].Patient_id";
            SqlDataReader dr = ClassQuerry.ExecuteQuerry(querry);
            List<ClassAppointment> appointment = new List<ClassAppointment>();
            while (dr.Read())
            {
                ClassAppointment appointmentDataGrid = new ClassAppointment();
                appointmentDataGrid.AppointmendtId = dr.GetInt32("Appointment_id");
                appointmentDataGrid.Term = new ClassTerm();
                appointmentDataGrid.Term.Date = dr.GetDateTime(1);
                appointmentDataGrid.Patient = new DictionariesHanding.ClassPatient();
                appointmentDataGrid.Patient.PatientId = dr.GetInt32("Patient_id");
                appointmentDataGrid.Patient.Name = dr.GetString("Patient_name");
                appointmentDataGrid.Patient.Surname = dr.GetString("Patient_surname");
                appointmentDataGrid.Patient.PersonalIdentityNumber = dr.GetString("PESEL");
                appointmentDataGrid.Patient.PhoneNumber = dr.GetString("Patient_phone_number");
                appointmentDataGrid.Doctor = new DictionariesHanding.ClassDoctor();
                appointmentDataGrid.Doctor.Doctor_id = dr.GetInt32("Doctor_id");
                appointmentDataGrid.Doctor.Employee = new DictionariesHanding.ClassEmployee();
                appointmentDataGrid.Doctor.Employee.Name = dr.GetString("Doctor_name");
                appointmentDataGrid.Doctor.Employee.Surname = dr.GetString("Doctor_surname");
                appointmentDataGrid.Topic = dr.GetString("Topic");
                try
                {
                    appointmentDataGrid.Description = dr.GetString("Description");
                }
                catch(System.Data.SqlTypes.SqlNullValueException ex)
                {
                    appointmentDataGrid.Description = "Brak";
                }

                appointment.Add(appointmentDataGrid);
            }
            ClassQuerry.CloseConnection();
            return appointment;
        }

        #region Update
        public static void UpdateAppointment(int appointmentId, string description, string topic)
        {
            string querry = "Use [db_Clinic] UPDATE [dbo].[tbl_Appointment] SET add_description = N'"+ description + "', Topic = '"+ topic +"' WHERE Appointment_id = " + appointmentId;
            SqlDataReader dr = ClassQuerry.ExecuteQuerry(querry);
            ClassQuerry.CloseConnection();
        }
        #endregion
    }
}
