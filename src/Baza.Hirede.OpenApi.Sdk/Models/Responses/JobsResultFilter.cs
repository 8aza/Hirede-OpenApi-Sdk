using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza.Hirede.OpenApi.Models.Responses
{
    /// <summary>
    /// 职位列表过滤条件。
    /// </summary>
    public class JobsResultFilter
    {
        /// <summary>
        /// 过滤条件的名称。
        /// </summary>
        public string FilterName { get; set; }
        /// <summary>
        /// 和结果相关联的过滤集合。
        /// </summary>
        public ICollection<FilterItem> Items { get; set; }

        public JobsResultFilter()
        { }

        public JobsResultFilter(JobsResultFilterType type, ICollection<FilterItem> items)
        {
            FilterName = type.ToString();
            Items = items;
        }
    }
}
