using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza.Hirede.OpenApi.Models
{
    /// <summary>
    /// 有雇得易客户在雇得易系统中定义的招聘门户自定义栏目。
    /// </summary>
    public class CustomPage
    {
        /// <summary>
        /// 自定义栏目的标题。
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 栏目的内容，由富文本编辑器生成，可能含有HTML代码。
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 内容的类型。
        /// </summary>
        public CustomPageContentType ContentType { get; set; }
        /// <summary>
        /// 是否在招聘门户中显示。
        /// </summary>
        public bool Visible { get; set; }
    }
}
