using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza.Hirede.OpenApi.Models
{
    /// <summary>
    /// 描述一个雇得易系统中的职位。
    /// </summary>
    public class Job
    {
        /// <summary>
        /// 职位在雇得易系统中的唯一标识。
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 职位的招聘类型。
        /// </summary>
        public RecruitType Type { get; set; }
        /// <summary>
        /// 职位名称。
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 职位的招聘地点。
        /// </summary>
        public DisplayField<int>[] Areas { get; set; }
        /// <summary>
        /// 职位的招聘部门。
        /// </summary>
        public DisplayField<int> Department { get; set; }
        /// <summary>
        /// 职位的发布日期。
        /// </summary>
        public DateTime PostedDate { get; set; }
        /// <summary>
        /// 职位的招聘人数。
        /// </summary>
        public int RecruitNumber { get; set; }
        /// <summary>
        /// 职位的职能类别，此数据由雇得易雇主在系统管理-基础数据中设置。
        /// </summary>
        public DisplayField<int> Category { get; set; }
    }
}
