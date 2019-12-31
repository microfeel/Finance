using System;

namespace MicroFeel.Finance.Models
{
    /// <summary>
    /// 通用传输对象
    /// </summary>
    public class Emp
    {
        /// <summary>
        /// 核算项
        /// </summary>
        public int FItemId { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 编码
        /// </summary>
        public string Number { get; set; }
        /// <summary>
        /// 短编码
        /// </summary>
        public string ShortNumber { get; set; }
        /// <summary>
        /// 电话号码
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// 部门编码
        /// </summary>
        public string DepartmentNumber { get; set; }
        /// <summary>
        /// 电子邮件
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 家庭住址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 性别:男,女,未知
        /// </summary>
        public string Sex { get; set; } = "未知";
        /// <summary>
        /// 生日
        /// </summary>
        public DateTime? Birthday { get; set; }
        /// <summary>
        /// 身份证号
        /// </summary>
        public string CardID { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Memo { get; set; }
    }

}
