using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza.Hirede.OpenApi.Models
{
    /// <summary>
    /// 描述一个雇得易系统的客户公司信息，这些信息由雇主在雇得易系统中配置。
    /// </summary>
    public class CompanyInformation
    {
        /// <summary>
        /// 公司名称。
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 公司的简介。
        /// </summary>
        public string Introduction { get; set; }
        /// <summary>
        /// 公司的联系方式。
        /// </summary>
        public CompanyContact Contract { get; set; }
    }
}
