using System;

namespace HierarchyClasses.Hierarchy2
{
    class Photo : Content
    {
        public string WhoIsOnPicture { get; set; }
        
        public Photo(int id, string name, DateTime uploadDate, string whoIsOnPicture = null)
            :base (id, name, uploadDate)
        {
            WhoIsOnPicture = whoIsOnPicture;
        }

        public override string ToString()
        {
            if (WhoIsOnPicture != null)
                return base.ToString() + $"Person On Picture: {WhoIsOnPicture}";

            return base.ToString();
        }
    }
}
