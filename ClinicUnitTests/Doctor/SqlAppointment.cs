using Przychodnia.Class.Calendar;
using Przychodnia.Class.DictionariesHanding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicUnitTests.Doctor
{
    class SqlAppointment
    {

        public SqlAppointment()
        {
            ClassAppointment cA1 = new ClassAppointment();
            cA1.AppointmendtId = 1;
            cA1.Description = "badania1";
            cA1.Doctor = new ClassDoctor();
            cA1.Doctor.Doctor_id = 1;
            cA1.Topic = "badania1";
            cA1.Term = new ClassTerm();
            cA1.Term.Date = new DateTime(1);
            cA1.Patient = new ClassPatient();
            cA1.Patient.PatientId = 1;
            cA1.Patient.Name = "Waldek";
            cA1.Patient.Surname = "wotal";

            listAppointment.Add(cA1);

            ClassAppointment cA2 = new ClassAppointment();
            cA2.AppointmendtId = 2;
            cA2.Description = "badania2";
            cA2.Doctor = new ClassDoctor();
            cA2.Doctor.Doctor_id = 2;
            cA2.Topic = "badania2";
            cA2.Term = new ClassTerm();
            cA2.Term.Date = new DateTime(1);
            cA2.Patient = new ClassPatient();
            cA2.Patient.PatientId = 2;
            cA2.Patient.Name = "Wojtek";
            cA2.Patient.Surname = "kona";

            listAppointment.Add(cA2);

            ClassTerm t1 = new ClassTerm();
            t1.TermId = 1;
            t1.StartTime = new TimeSpan(7, 0, 0);
            t1.EndTime = new TimeSpan(19, 0, 0);
            t1.Date = new DateTime(2021, 6, 12);
            listTerm.Add(t1);

            ClassTerm t2 = new ClassTerm();
            t2.TermId = 2;
            t2.StartTime = new TimeSpan(7, 0, 0);
            t2.EndTime = new TimeSpan(19, 0, 0);
            t2.Date = new DateTime(2021, 7, 12);
            listTerm.Add(t2);






        }

        static List<ClassAppointment> listAppointment = new List<ClassAppointment>();
        static List<ClassTerm> listTerm = new List<ClassTerm>();


        public List<ClassAppointment> GetAllAppoitments()
        {
            List<ClassAppointment> la = new List<ClassAppointment>();

            foreach (var a in listAppointment)
            {
                la.Add(a);

            }

            return la;



        }

        public void UpdateAppointment(int appointmentId, string description, string topic)
        {

            foreach (var t in listAppointment)
            {
                if (appointmentId == t.AppointmendtId)
                {
                    t.Description = description;
                    t.Topic = topic;

                }

            }




        }
        public List<ClassTerm> AppointmentsDateForCombobox()
        {
            List<ClassTerm> terms = new List<ClassTerm>();

            foreach (var ter in listTerm) 
            {
                terms.Add(ter);
            
            }

            return terms;
        
        }

        





    }
}
