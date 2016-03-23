using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Dow.Intune.Services
{
    public class PropertyExtractor
    {
        public static string ExtractPropertyName<T>(Expression<Func<T>> propertyExpression)
        {
            if (propertyExpression == null)
                throw new ArgumentNullException("propertyExpression");
            MemberExpression memberExpression = propertyExpression.Body as MemberExpression;
            if (memberExpression == null)
                throw new ArgumentException("Expression body is not a member access expression", "propertyExpression");
            PropertyInfo propertyInfo = memberExpression.Member as PropertyInfo;
            if (propertyInfo == (PropertyInfo)null)
                throw new ArgumentException("Expression body is not a property access expression", "propertyExpression");
            if (propertyInfo.GetGetMethod(true).IsStatic)
                throw new ArgumentException("Expression body is a static property access expression", "propertyExpression");
            else
                return memberExpression.Member.Name;
        }
    }
}
