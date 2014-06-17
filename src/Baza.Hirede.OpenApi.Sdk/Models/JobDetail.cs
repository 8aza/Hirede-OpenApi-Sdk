using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza.Hirede.OpenApi.Models
{
    /// <summary>
    /// 描述雇得易系统中的职位详情。
    /// </summary>
    public class JobDetail : Job
    {
        /// <summary>
        /// 职位的内部编码。
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 职位的详情，可能含HTML代码。
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 职位要求的学位等级。
        /// </summary>
        public RangeDisplayField<int?> Degree { get; set; }
        /// <summary>
        /// 职位所属的职位类别。
        /// </summary>
        public DisplayField<int>[] JobFunctions { get; set; }
        /// <summary>
        /// 职位的年龄要求。
        /// </summary>
        public RangeDisplayField<int?> Age { get; set; }
        /// <summary>
        /// 职位提供的月薪。
        /// </summary>
        public RangeDisplayField<int?> MonthlySalary { get; set; }
        /// <summary>
        /// 职位要求的英语等级。
        /// </summary>
        public DisplayField<int?> EnglishLevel { get; set; }
        /// <summary>
        /// 职位要求的性别。
        /// </summary>
        public DisplayField<int?> Gender { get; set; }
    }
}
