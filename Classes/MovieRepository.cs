using System;
using System.Collections.Generic;
using DIO.TVShows.interfaces;

namespace DIO.TVShows
{
    public class MovieRepository : IMovieRepository<Movie>
    {
        private List<Movie> ListMovie = new List<Movie>();
        
        public void Add(Movie obj)
        {
            ListMovie.Add(obj);
        }

        public void Delete(int id)
        {
           ListMovie[id].Delete();
        }

        public List<Movie> List()
        {
           return ListMovie;
        }

        public int NextId()
        {
            return ListMovie.Count;
        }

        public Movie ReturnById(int id)
        {
            return ListMovie[id];
        }

        public void Update(int id, Movie obj)
        {
           ListMovie[id] = obj;
        }
    }
}