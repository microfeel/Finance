using System;
using System.Collections.Generic;
using System.Text;

namespace MicroFeel.Finance.Models
{
    /// <summary>
    /// 实体扩展
    /// </summary>
    public static class ModelExtensions
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
        /// <returns></returns>
        public static TModel To<TModel>(this object obj, Action<TModel> acModel) where TModel : class, IFinanceModel, new()
        {
            if (acModel == null)
                throw new ArgumentNullException();
            var model = obj.To<TModel>();
            acModel?.Invoke(model);
            return model;
        }
    }
}
