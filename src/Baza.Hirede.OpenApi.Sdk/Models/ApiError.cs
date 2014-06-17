using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza.Hirede.OpenApi.Models
{
    /// <summary>
    /// 定义了Api的错误信息。
    /// </summary>
    public class ApiError
    {
        /// <summary>
        /// 错误代码。
        /// </summary>
        public int Code { get; set; }
        /// <summary>
        /// 错误的详细信息。
        /// </summary>
        public string Message { get; set; }
    }
}
