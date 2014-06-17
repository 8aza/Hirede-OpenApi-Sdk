using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza.Hirede.OpenApi.Models.Responses
{
    /// <summary>
    /// 职位列表结果。
    /// </summary>
    public class JobsResult
    {
        /// <summary>
        /// 分页结果。
        /// </summary>
        public PagedList<Job> Jobs { get; set; }
        /// <summary>
        /// 相关过滤条件。
        /// </summary>
        public ICollection<JobsResultFilter> Filters { get; set; }
    }
}
