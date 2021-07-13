using System;

namespace DIO.TVShows
{
    public class TVShow : BaseEntity
    {
        //Atributes

        private  Genre Genre {get ; set;}
        private string Title {get; set;}
        private string Synopsis {get; set;}
        private int Year {get; set;}

        private bool Deleted {get; set;}

        //Métodos
        
        public TVShow(int id, Genre genre, string title, string synopsis, int year)
        {
            this.Id = id;
            this.Genre = genre;
            this.Title = title;
            this.Year = year;
            this.Deleted = false;
        }


        public override string ToString()
        {
            string Return = " ";
            Return += "Genre: " + this.Genre + Environment.NewLine;
            Return += "Title: " + this.Title + Environment.NewLine;
            Return += "Synopsis: " + this.Synopsis + Environment.NewLine;
            Return += "Year: " + this.Year + Environment.NewLine;
            Return += "Deleted: " + this.Deleted;

            
            return Return;
        }

        public string returnTitle()
        {
            return this.Title;
        }
        public int returnId()
        {
            return this.Id;
        }

        public void Delete()
        {
           this.Deleted = true; 
        }

        public bool returnDeleted()
        {
            return this.Deleted;
        }
    }

}