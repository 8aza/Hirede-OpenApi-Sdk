using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza.Hirede.OpenApi.Models.Requests
{
    /// <summary>
    /// 职位查询过滤器。
    /// </summary>
    public class JobQueryFilter : PagingFilter
    {
        /// <summary>
        /// 职位的关键字。
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// 职位的工作地点。
        /// </summary>
        public int? Area { get; set; }

        /// <summary>
        /// 职位的类别。
        /// </summary>
        public int? Category { get; set; }
    }
}
