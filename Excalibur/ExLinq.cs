using System;
using System.Collections.Generic;

namespace Excalibur
{
    public static class ExLinq
    {
        /// <summary>
        /// 自定义去重
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="src"></param>
        /// <param name="selector">委托方法，需要传入一个泛型参数，返回原类型对象。泛型参数用于内部去重的依据</param>
        /// <remarks>这里可以看一下new 的用法</remarks>
        /// <seealso cref="https://docs.microsoft.com/zh-cn/dotnet/csharp/language-reference/keywords/new-operator"/>
        /// <returns></returns>
        public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> src,
           Func<TSource, TKey> selector)
        {
            HashSet<TKey> keys = new HashSet<TKey>();

            foreach (TSource source in src)
            {
                if (keys.Add(selector(source)))
                {
                    yield return source;
                }
            }
        }
    }
}