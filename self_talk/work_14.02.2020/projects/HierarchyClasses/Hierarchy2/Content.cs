using System;

namespace HierarchyClasses.Hierarchy2
{
    abstract class Content
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime UploadDate { get; set; }

        public Content(int id, string name, DateTime uploadDate)
        {
            Id = id;
            Name = name;
            UploadDate = uploadDate;
        }

        public override string ToString()
        {
            return $"Id: {Id} Name: {Name} Upload date: {UploadDate} ";
        }
    }
}
