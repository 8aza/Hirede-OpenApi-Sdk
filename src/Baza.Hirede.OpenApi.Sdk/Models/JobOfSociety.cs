using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza.Hirede.OpenApi.Models
{
    /// <summary>
    /// 社会招聘职位。
    /// </summary>
    public class JobOfSociety : JobDetail
    {
        /// <summary>
        /// 招聘对象（全职/兼职/实习）。
        /// </summary>
        public DisplayField<int>[] Targets { get; set; }
        /// <summary>
        /// 职位要求的工作年限。
        /// </summary>
        public RangeDisplayField<int?> YearsOfExperience { get; set; }
        /// <summary>
        /// 职位类型（社会招聘、内部推荐、内部招聘）。
        /// </summary>
        public DisplayField<int>[] RecruitTypes { get; set; }
    }
}
