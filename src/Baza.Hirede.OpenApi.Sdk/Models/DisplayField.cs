using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza.Hirede.OpenApi.Models
{
    /// <summary>
    /// 用于描述雇得易自定义数据类型。
    /// </summary>
    /// <typeparam name="T">所描述类型的类型。</typeparam>
    public class DisplayField<T>
    {
        public DisplayField()
        { }
        public DisplayField(T value, string displayValue)
        {
            Value = value;
            DisplayValue = displayValue;
        }

        /// <summary>
        /// 雇得易自定义数据类型的值。
        /// </summary>
        public T Value { get; set; }
        /// <summary>
        /// 值的人类可读显示。
        /// </summary>
        public string DisplayValue { get; set; }

        public override bool Equals(object obj)
        {
            var f2 = obj as DisplayField<T>;
            if (f2 == null)
                return false;
            if ((f2.DisplayValue == null && this.DisplayValue != null) ||
                (f2.DisplayValue != null && this.DisplayValue == null))
                return false;
            if ((f2.Value == null && this.Value != null) ||
                (f2.Value != null && this.Value == null))
                return false;
            if (f2.DisplayValue == null && this.DisplayValue == null
                && f2.Value == null && this.Value == null)
                return true;

            return f2.DisplayValue == this.DisplayValue &&
                f2.Value.Equals(this.Value);
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + DisplayValue.GetHashCode();
            hash = (hash * 7) + Value.GetHashCode();
            return hash;
        }
    }
}
