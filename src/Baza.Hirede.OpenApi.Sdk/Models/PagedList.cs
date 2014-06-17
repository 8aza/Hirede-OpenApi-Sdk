using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza.Hirede.OpenApi.Models
{
    /// <summary>
    /// 分页列表。
    /// </summary>
    public class PagedList
    {
        public static readonly int DefaultStart = 0;
        public static readonly int MaximumTake = 100;

        int m_Start = 0;
        /// <summary>
        /// 当前分页起始项的下标，从0开始。
        /// </summary>
        public int Start
        {
            get
            {
                return m_Start;
            }
            set
            {
                if (m_Start < 0)
                {
                    m_Start = 0;
                }
                else if (m_Start > Total)
                {
                    m_Start = Total;
                }
                else
                {
                    m_Start = value;
                }
            }
        }
        /// <summary>
        /// 当前分页请求数量。
        /// </summary>
        public int Take { get; set; }
        /// <summary>
        /// 请求的总数。
        /// </summary>
        public int Total { get; set; }
        /// <summary>
        /// 当前分页条件的第一页链接。
        /// </summary>
        public string First { get; set; }
        /// <summary>
        /// 当前分页的上一页链接。
        /// </summary>
        public string Previous { get; set; }
        /// <summary>
        /// 当前分页的下一页链接。
        /// </summary>
        public string Next { get; set; }
        /// <summary>
        /// 当前分页条件的最后一页链接。
        /// </summary>
        public string Last { get; set; }
    }

    /// <summary>
    /// 包含数据的分页列表。
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PagedList<T> : PagedList
    {
        /// <summary>
        /// 分页数据。
        /// </summary>
        public ICollection<T> Data { get; set; }
        public PagedList()
            : this(new List<T>())
        {

        }
        public PagedList(ICollection<T> collection)
        {
            if (collection == null)
                throw new ArgumentNullException("collection");

            Data = collection;
        }
    }
}
