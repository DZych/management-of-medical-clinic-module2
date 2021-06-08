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
        #endregion
    }
}
