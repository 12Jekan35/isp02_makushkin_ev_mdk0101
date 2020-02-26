using System;

namespace Classes
{
    class MonetaryDenomination
    {
        public string SerialAndNumber { get; set; }
        public int Nominal { get; set; }
        public string NominalInWords { get; set; }

        public override string ToString()
        {
            string info = $"Serial And Number: {SerialAndNumber} " +
                          $"Nominal: {Nominal} " +
                          $"Nominal value in words: {NominalInWords} ";

            return info;
        }

        public MonetaryDenomination(string serialAndNumber, int nominal, string nominalInWords)
        {
            SerialAndNumber = serialAndNumber;
            Nominal = nominal;
            NominalInWords = nominalInWords;
        }
    }
}
