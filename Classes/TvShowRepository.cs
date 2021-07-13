using System;
using System.Collections.Generic;
using DIO.TVShows;

namespace DIO.TVShows
{
    public class TvShowRepository : IRepository<TVShow>
    {
        private List<TVShow> ListTvShow = new List<TVShow>();
        
        public void Add(TVShow obj)
        {
            ListTvShow.Add(obj);
        }

        public void Delete(int id)
        {
           ListTvShow[id].Delete();
        }

        public List<TVShow> List()
        {
           return ListTvShow;
        }

        public int NextId()
        {
            return ListTvShow.Count;
        }

        public TVShow ReturnById(int id)
        {
            return ListTvShow[id];
        }

        public void Update(int id, TVShow obj)
        {
           ListTvShow[id] = obj;
        }
    }
}