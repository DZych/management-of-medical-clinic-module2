using Przychodnia.Class.DictionariesHanding;
using System;
using System.Collections.Generic;
using System.Text;

namespace Przychodnia.Class.Calendar
{
    public class ClassAppointment
    {
        #region field and properties
        private int appointmendtId;
        public int AppointmendtId
        {
            get { return appointmendtId; }
            set { appointmendtId = value; }
        }


        private TimeSpan startTime;
        public TimeSpan StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }


        private ClassPatient patient;
        public ClassPatient Patient 
        {
            get { return patient; }
            set { patient = value; }
        }


        private ClassTerm term;
        public ClassTerm Term
        {
            get { return term; }
            set { term = value; }
        }

        private ClassDoctor doctor;
        public ClassDoctor Doctor
        {
            get { return doctor; }
            set { doctor = value; }
        }


        private string toPay;
        public string ToPay 
        {
            get { return toPay; }
            set { toPay = value; }
        }


        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }


        private string topic;
        public string Topic 
        {
            get { return topic; }
            set { topic = value; }
        }


        #endregion


        #region For DataGrid

        private string dateDataGrid;
        public string DateDataGrid 
        { 
            get => Term.Date.ToString("dd-MM-yyyy"); 
        }


        private string doctorDataGrid;
        public string DoctorDataGrid
        {
            get => Doctor.Employee.Name + " " + Doctor.Employee.Surname; 
        }
        

        private string patientNameDataGrid;
        public string PatientNameDataGrid 
        { 
            get => Patient.Name; 
        }
        

        private string patientSurnameDataGrid;
        public string PatientSurnameDataGrid 
        { 
            get => Patient.Surname; 
        }


        private string patientPESELDataGrid;
        public string PatientPESELDataGrid 
        { 
            get => Patient.PersonalIdentityNumber; 
        }

        #endregion
    }
}
