using System;

namespace Classes
{
    class EducationalGroup
    {
        private int amountStudents;
        private int yearFormation;

        public string Id { get; set; }
        public int AmountStudents 
        {
            get => amountStudents;
            set
            {
                if (value < 0)
                    throw (new Exception("Enter invalid value"));
                else
                    amountStudents = value;
            }
        }
        
        public int YearFormation
        {
            get => yearFormation;
            set
            {
                if (value < 1)
                    throw (new Exception("Enter invalid value"));
                else
                    yearFormation = value;
            }
        }
        public string Specialty { get; set; }

        public override string ToString()
        {
            string info = $"ID: {Id} " +
                          $"Specialty: {Specialty} " +
                          $"Amount: {AmountStudents} " +
                          $"Year Formation: {YearFormation} ";

            return info;
        }

        public EducationalGroup(int yearFormation, string id, int amountStudents = 0, string specialty = "Indefined specialty")
        {
            AmountStudents = amountStudents;
            YearFormation = yearFormation;
            Id = id;
            Specialty = specialty;
        }
    }
}
