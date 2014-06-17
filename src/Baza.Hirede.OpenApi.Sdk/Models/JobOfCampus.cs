using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza.Hirede.OpenApi.Models
{
    /// <summary>
    /// 校园招聘职位。
    /// </summary>
    public class JobOfCampus : JobDetail
    {
        public JobOfCampus()
        {
            Type = RecruitType.Campus;
        }
    }
}
