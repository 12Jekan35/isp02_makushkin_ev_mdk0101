using System;

namespace Classes
{
    class Workshop
    {
        public readonly string Id;
        private int numberOfWorkers;

        public int NumberOfWorkers
        {
            get => numberOfWorkers;
            set
            {
                if (value < 0)
                    throw (new Exception("Enter invalid value"));
                else
                    numberOfWorkers = value;
            }
        }

        public override string ToString()
        {
            string info = $"ID: {Id} " +
                          $"Number of Workers : {NumberOfWorkers} ";
            return info;
        }

        public Workshop(string id, int numberOfWorkers = 0)
        {
            Id = id;
            NumberOfWorkers = numberOfWorkers;
        }
    }
}
