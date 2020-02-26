using System;

namespace Classes
{
    class ComputerGame
    {
        public string Title { get; set; }
        public string DeveloperFirm { get; set; }
        public int YearPublication { get; set; }
        public string Genre { get; set; }

        public override string ToString()
        {
            string info = $"Title: {Title} " +
                          $"Developer firm: {DeveloperFirm} " +
                          $"Year publication: {YearPublication} " +
                          $"Genre: {Genre}";

            return info;
        }

        public ComputerGame(string developerfirm, string genre, int yearPublication, string title = "Untitle Game")
        {
            Title = title;
            DeveloperFirm = developerfirm;
            Genre = genre;
            YearPublication = yearPublication;
        }
    }
}
