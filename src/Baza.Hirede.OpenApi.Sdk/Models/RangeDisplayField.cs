using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza.Hirede.OpenApi.Models
{
    /// <summary>
    /// 一种表示范围值得可见描述类型。
    /// </summary>
    /// <typeparam name="T">可见范围的值类型。</typeparam>
    public class RangeDisplayField<T>
    {
        public RangeDisplayField()
        { }
        public RangeDisplayField(T minimum, T maximum)
        {
            MinimumValue = minimum;
            MaximumValue = maximum;
            MinimumString = minimum == null ? null : minimum.ToString();
            MaximumString = maximum == null ? null : maximum.ToString();
        }
        public RangeDisplayField(T minimum, T maximum, string minimumString, string maximumString)
        {
            MinimumValue = minimum;
            MaximumValue = maximum;
            MinimumString = minimumString;
            MaximumString = maximumString;
        }

        /// <summary>
        /// 范围的最大值。
        /// </summary>
        public T MaximumValue { get; set; }
        /// <summary>
        /// 范围的最小值。
        /// </summary>
        public T MinimumValue { get; set; }
        /// <summary>
        /// 最小值的字符串表示值。
        /// </summary>
        public string MinimumString { get; set; }
        /// <summary>
        /// 最大值的字符串表示值。
        /// </summary>
        public string MaximumString { get; set; }
    }
}
