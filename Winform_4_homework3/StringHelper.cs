using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Winform_4_homework3
{
    public static class StringHelper
    {
        /// <summary>
        /// string转int的扩展方法
        /// </summary>
        /// <param name="val"></param>
        /// <returns>成功返回int值, 失败返回null</returns>
        public static int? ToInt(this string val)
        {
            if(int.TryParse(val, out int oVal))
                return oVal;
            else 
                return null;
        }

        /// <summary>
        /// string转decimal的扩展方法
        /// </summary>
        /// <param name="val"></param>
        /// <returns>成功返回decimal值, 失败返回null</returns>
        public static decimal? ToDecimal(this string val)
        {
            if (decimal.TryParse(val, out decimal oVal))
                return oVal;
            else
                return null;
        }

        /// <summary>
        /// string转泛型的扩展方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="val"></param>
        /// <returns>成功返回T值, 失败返回null</returns>
        public static T? ToGeneric<T>(this string val) where T : struct
        {
            // 知识点1: out参数使用: MakeByRefType()
            MethodInfo m = typeof(T).GetMethod("TryParse", new Type[] {typeof(string), typeof(T).MakeByRefType()});

            // 知识点2: 调用参数里有out时, 传入数组, 可在数组中获取到out值
            var args = new object[] { val, null };
            var isSuccess = (bool)m.Invoke(null, args);
            if (isSuccess)
                return (T)args[1];
            else
                return null;
        }

    }
}
