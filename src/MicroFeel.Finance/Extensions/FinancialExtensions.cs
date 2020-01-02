using MicroFeel.Finance.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MicroFeel.Finance
{
    /// <summary>
    /// 
    /// </summary>
    public static class FinancialExtensions
    {
        /// <summary>
        /// 实体转换
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static TModel To<TModel>(this object obj) where TModel : class, IFinanceModel, new()
        {
            var model = new TModel();
            var sourceType = obj.GetType();
            var targetPropertyInfos = typeof(TModel).GetProperties();
            foreach (var property in targetPropertyInfos)
            {
                var tmpProperty = sourceType.GetProperty(property.Name);
                if (tmpProperty != null)
                    property.SetValue(model, tmpProperty.GetValue(obj, null), null);
            }
            return model;
        }

        /// <summary>
        /// 实体转换
        /// </summary>
        /// <remarks>指定属性进行赋值，一般是因为两个对象的属性名称不同所致，只需要指定不同的属性即可，相同的属性会完成自动赋值</remarks>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="obj"></param>
        /// <param name="acModel"></param>
        /// <param name="autoAssign">自动赋值，默认true</param>
        /// <returns></returns>
        public static TModel To<TModel>(this object obj, Action<TModel> acModel, bool autoAssign = true) where TModel : class, IFinanceModel, new()
        {
            if (acModel == null)
                throw new ArgumentNullException();
            var model = autoAssign ? obj.To<TModel>() : new TModel();
            acModel?.Invoke(model);
            return model;
        }

        /// <summary>
        /// 获取特性值
        /// </summary>
        /// <typeparam name="TAttrbute"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToAttrString<TAttrbute>(this Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            var attribute = fi.GetCustomAttributes(typeof(TAttrbute), false).FirstOrDefault();
            if (attribute != null)
                return attribute.ToString();
            return value.ToString();
        }

        /// <summary>
        /// 获取特性值
        /// </summary>
        /// <typeparam name="TAttrbute"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToAttrString(this Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            var attribute = fi.GetCustomAttributes(typeof(FinancialAttribute), false).FirstOrDefault();
            if (attribute != null)
                return attribute.ToString();
            return value.ToString();
        }
        /// <summary>
        /// 获取特性值
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToDescriptionString(this Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            var attribute = fi.GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault() as DescriptionAttribute;
            if (attribute != null)
                return attribute.Description;
            return value.ToString();
        }
    }
}
