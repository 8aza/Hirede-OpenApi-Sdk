using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza.Hirede.OpenApi.Models.Requests
{
    /// <summary>
    /// 定义了分页过滤器的公共属性。
    /// </summary>
    public class PagingFilter
    {
        public const int DefaultPageStart = 0;
        public const int DefaultPageTake = 10;
        public const int MaxPageStart = 10000;
        public const int MaxPageTake = 100;
        /// <summary>
        /// 当前分页起始项的下标，从0开始。
        /// </summary>
        public int Start { get; set; }
        /// <summary>
        /// 当前分页请求数量。
        /// </summary>
        public int Take { get; set; }

        public PagingFilter()
        {
            Start = DefaultPageStart;
            Take = DefaultPageTake;
        }
    }
}
