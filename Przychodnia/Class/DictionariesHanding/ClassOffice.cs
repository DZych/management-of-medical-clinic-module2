using System;
using System.Collections.Generic;
using System.Text;

namespace Przychodnia.Class.DictionariesHanding
{
    public class ClassOffice
    {
        private static List<ClassOffice> listClassOffice; //List of offices
        private int officeId;
        private int officeNumber;

        public static List<ClassOffice> ListClassOffice { get => listClassOffice; set => listClassOffice = value; }
        public int OfficeId { get => officeId; set => officeId = value; }
        public int OfficeNumber { get => officeNumber; set => officeNumber = value; }
        public override string ToString()
        {
            return OfficeNumber.ToString();
        }
    }
}
