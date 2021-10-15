using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Owin_Song_Tên_Sinh_Viên
{
   public class SongController : ApiController
    {
       static List<Song> ml = new List<Song>();

       public SongController()
        {
            SongController.GetListSanPham();    
        }
        private static List<Song> GetListSanPham()
        {
            List<Song> ml = new List<Song>();
            ml.Add(new Song() { Id = 1,Title = "Hey Jude", Artist = "The Beatles", Price = 1.9 });
            ml.Add(new Song() { Id = 2, Title = "I Gotta Feeling", Artist = "The Black Eyed Peas", Price = 1.5 });
            ml.Add(new Song() { Id = 3, Title = "The Twist", Artist = "Chubby Checker", Price = 2 });
            return ml;
        }
        public IEnumerable<Song> Get()
        {
            return GetListSanPham();
        }

        // GET api/values/5
        public Song Get(int id)
        {
            return new Song();
        }

        // POST api/values
        public void Post(Song item)
        {
            int a = 0;
            if(item != null)
            {
                ml.Add(item);
            }
        }

        // PUT api/values/5
        public void Put(Song item)
        {
            if (item != null)
            {
                Song s_old = ml.Where(n => n.Id == item.Id).First();
                s_old.Artist = item.Artist;
                s_old.Title = item.Title;
                s_old.Price = item.Price;
            }
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
          
        }
    }
}
