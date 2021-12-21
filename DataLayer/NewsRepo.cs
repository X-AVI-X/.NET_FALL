using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class NewsRepo
    {
        static NewsPortalEntities db;
        static NewsRepo()
        {
            db = new NewsPortalEntities();
        }
        public static List<Report_info> Get()
        {
            return db.Report_info.ToList();
        }
        public static Report_info Get(int id)
        {
            return db.Report_info.FirstOrDefault(e => e.NewsID == id);
        }

        public static void Edit(Report_info s)
        {
            var ds = db.Report_info.FirstOrDefault(e => e.RepoID == s.RepoID);
            db.Entry(ds).CurrentValues.SetValues(s);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var ds = db.Report_info.FirstOrDefault(e => e.RepoID == id);
            db.Report_info.Remove(ds);
        }
        public static void Add(Report_info s)
        {
            db.Report_info.Add(s);
            db.SaveChanges();
        }
    }
}
