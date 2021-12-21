using BussLayer.BussEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataLayer;

namespace BussLayer
{
    public class ReportService
    {
        public static List<ReportModel> Get()
        {
            var config = new MapperConfiguration(c =>
             {
                 c.CreateMap<Reacts_info, ReportModel>();
             });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<ReportModel>>(NewsRepo.Get());

            return data;
        }
        public static List<string> GetNames()
        {
            var data = NewsRepo.Get().Select(e => e.News).ToList();
            return data;
        }
        public void Add(ReportModel s)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Reacts_info, ReportModel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Report_info>(s);
            NewsRepo.Add(data);
        }
    }
}
