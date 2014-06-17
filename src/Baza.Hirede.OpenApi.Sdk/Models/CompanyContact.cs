using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza.Hirede.OpenApi.Models
{
    /// <summary>
    /// 公司联系方式。
    /// </summary>
    public class CompanyContact
    {
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
    }
}
