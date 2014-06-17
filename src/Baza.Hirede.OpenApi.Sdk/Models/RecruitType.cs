using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza.Hirede.OpenApi.Models
{
    /// <summary>
    /// 招聘类型。
    /// </summary>
    public enum RecruitType
    {
        /// <summary>
        /// 所有，不分类别。
        /// </summary>
        All = 0,
        /// <summary>
        /// 社会招聘。
        /// </summary>
        Society = 1,
        /// <summary>
        /// 校园招聘。
        /// </summary>
        Campus = 2,
        /// <summary>
        /// 内部推荐。
        /// </summary>
        Referral = 3,
        /// <summary>
        /// 内部招聘。
        /// </summary>
        Transfer = 4
    }

    public class JobTypeString
    {
        /// <summary>
        /// 所有，不分类别。
        /// </summary>
        public const string All = "all";
        /// <summary>
        /// 社会招聘。
        /// </summary>
        public const string Society = "society";
        /// <summary>
        /// 校园招聘。
        /// </summary>
        public const string Campus = "campus";
        /// <summary>
        /// 内部推荐。
        /// </summary>
        public const string Referral = "referral";
        /// <summary>
        /// 内部招聘。
        /// </summary>
        public const string Transfer = "transfer";

        public static RecruitType ToJobType(string jobType)
        {
            if (string.IsNullOrWhiteSpace(jobType))
                return RecruitType.All;

            switch (jobType.ToLower())
            {
                case All:
                    return RecruitType.All;
                case Society:
                    return RecruitType.Society;
                case Campus:
                    return RecruitType.Campus;
                case Referral:
                    return RecruitType.Referral;
                case Transfer:
                    return RecruitType.Transfer;
                default:
                    throw new ArgumentException("jobType");
            }
        }
    }
}