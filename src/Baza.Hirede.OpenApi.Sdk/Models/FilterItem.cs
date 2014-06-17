using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza.Hirede.OpenApi.Models
{
    /// <summary>
    /// 过滤项，实质是一种键值对。
    /// </summary>
    public class FilterItem
    {
        /// <summary>
        /// 过滤项的Id。
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 过滤项的名称。
        /// </summary>
        public string Name { get; set; }

        public FilterItem()
        { }

        public FilterItem(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override bool Equals(object obj)
        {
            var right = obj as FilterItem;
            if (right == null)
                return false;
            return Id == right.Id && Name == right.Name;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
