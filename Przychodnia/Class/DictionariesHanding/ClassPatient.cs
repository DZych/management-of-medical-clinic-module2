using System;
using System.Collections.Generic;
using System.Text;

namespace Przychodnia.Class.DictionariesHanding
{
    public class ClassPatient
    {
        private int patientId;
        public int PatientId 
        { 
            get => patientId; 
            set => patientId = value; 
        }


        private string name;
        public string Name 
        { 
            get => name; 
            set => name = value; 
        }


        private string surname;
        public string Surname 
        { 
            get => surname; 
            set => surname = value; 
        }


        private string phoneNumber;
        public string PhoneNumber 
        { 
            get => phoneNumber; 
            set => phoneNumber = value; 
        }


        private DateTime dateOfBirth;
        public DateTime DateOfBirth 
        { 
            get => dateOfBirth; 
            set => dateOfBirth = value; 
        }
        

        private string personalIdentityNumber;
        public string PersonalIdentityNumber 
        { 
            get => personalIdentityNumber; 
            set => personalIdentityNumber = value; 
        }
        

        private string city;
        public string City
        { 
            get => city; 
            set => city = value; 
        }
        

        private string street;
        public string Street 
        { 
            get => street; 
            set => street = value; 
        }
        

        private string streetNumber;
        public string StreetNumber 
        { 
            get => streetNumber; 
            set => streetNumber = value; 
        }


        private int active;
        public int Active 
        { 
            get => active; 
            set => active = value; 
        }

    }
}
