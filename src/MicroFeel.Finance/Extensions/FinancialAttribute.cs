using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MicroFeel.Finance
{
    /// <summary>
    /// 
    /// </summary>
    public class FinancialAttribute : Attribute
    { }
    /// <summary>
    /// 财务请求特性
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class FinancialPathAttribute : FinancialAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="path">请求路径（不包含action）</param>
        public FinancialPathAttribute(string path)
        {
            this.Path = path;
        }
        /// <summary>
        /// 请求路径（不包含action）
        /// </summary>
        public string Path { get; set; }

        public override string ToString()
        {
            return this.Path;
        }
    }

    /// <summary>
    /// 财务请求特性
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class FinancialActionAttribute : FinancialAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"> action </param>
        public FinancialActionAttribute(string action)
        {
            this.Action = action;
        }
        /// <summary>
        /// action
        /// </summary>
        public string Action { get; set; }

        public override string ToString()
        {
            return this.Action;
        }
    }

    /// <summary>
    /// 类库名称
    /// </summary>
    public class FinancialAssemblyNameAttribute : Attribute
    {
        public string AssemblyName { get; set; }

        public FinancialAssemblyNameAttribute(string assemblyname)
        {
            this.AssemblyName = assemblyname;
        }

        public override string ToString()
        {
            return this.AssemblyName;
        }
    }

    /// <summary>
    /// 类库名称
    /// </summary>
    public class FinancialTypeNameAttribute : Attribute
    {
        public string TypeName { get; set; }

        public FinancialTypeNameAttribute(string typename)
        {
            this.TypeName = typename;
        }

        public override string ToString()
        {
            return this.TypeName;
        }
    }
}
