using System;
using System.Collections.Generic;
using System.Text;

namespace Przychodnia.Class.Calendar
{
    public class ClassAppointment
    {
        #region Variables
        private int appointmendtId;
        private int termID;
        private int pacientID;
        private TimeSpan startTime ;
        private string topic;
        private string description;
        private string patientName;
        private string patientSurname;
        private string nrPesel;
        private DateTime date;
        private string dateString;
        private string add_description;

        private string nameDoctor;
        private string surnameDoctor;

        private string doctor;


        public int AppointmendtId
        {
            get { return appointmendtId; }
            set { appointmendtId = value; }
        }

        

        public TimeSpan StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }

        private ClassTerm term;

        public ClassTerm Term
        {
            get { return term; }
            set { term = value; }
        }

     

        public int TermID 
        { get => termID; set => termID = value; }
        public int PacientID 
        { get => pacientID; set => pacientID = value; }
        public string Topic 
        { get => topic; set => topic = value; }
        public string Description 
        { get => description; set => description = value; }
        public string PatientName
        { get => patientName; set => patientName = value; }
        public string PatientSurname
        { get => patientSurname; set => patientSurname = value; }
        public string NrPesel
        { get => nrPesel; set => nrPesel = value; }
        public DateTime Date { get => date; set => date = value; }
        public string NameDoctor { get => nameDoctor; set => nameDoctor = value; }
        public string SurnameDoctor { get => surnameDoctor; set => surnameDoctor = value; }
        public string Doctor { get => nameDoctor + " " + surnameDoctor; set => Doctor = value; }
        public string DateString { get => date.ToString("dd-MM-yyyy"); set => dateString = value; }
        public string Add_description { get => add_description; set => add_description = value; }
        #endregion
    }
}
