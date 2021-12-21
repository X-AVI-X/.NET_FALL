using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussLayer.BussEntity
{
    public class ReportModel
    {
        public int RepoID { get; set; }
        public int NewsID { get; set; }
        public string RepoDate { get; set; }
        public string RepoTime { get; set; }
        public string RepoCat { get; set; }
        public string News { get; set; }

    }
}
