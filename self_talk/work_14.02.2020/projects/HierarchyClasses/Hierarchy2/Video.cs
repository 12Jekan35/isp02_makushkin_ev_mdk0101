using System;

namespace HierarchyClasses.Hierarchy2
{
    class Video : Content
    {
        public TimeSpan Length { get; set; }

        public Video(int id, string name, DateTime uploadDate, TimeSpan length)
            : base(id, name, uploadDate)
        {
            Length = length;
        }

        public override string ToString()
        {
            return base.ToString() + $"Length: {Length}";
        }
    }
}
