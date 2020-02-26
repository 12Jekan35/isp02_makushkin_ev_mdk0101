using System;

namespace Classes
{
    class Credit
    {
        private int grade;

        public string FIOExaminee { get; set; }
        public string FIOExaminer { get; set; }
        public DateTime Date { get; set; }
        public int Grade 
        {
            get => grade;
            set
            {
                if (value < 0 || value > 5)
                    throw (new Exception("Enter invalid value"));
                else
                    grade = value;
            }
        }

        public override string ToString()
        {
            string info = $"Full name Examiner's: {FIOExaminer} " +
                          $"Full name Examinee's: {FIOExaminee} " +
                          $"Date: {Date} " +
                          $"Grade {Grade}";

            return info;
        }

        public Credit(DateTime date, int grade, string fioExaminee, string fioExaminer)
        {
            Grade = grade;
            FIOExaminee = fioExaminee;
            FIOExaminer = fioExaminer;
            Date = date;
        }
        public Credit(string fioExaminer, int grade, string fioExaminee = "Noname")
            :this (DateTime.Now, grade, fioExaminee, fioExaminer)
        {
        }
    }
}
