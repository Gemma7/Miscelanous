using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace CustomSequenceOperators.Classes
{
    public static class CustomSequenceOperator
    {
        public static IEnumerable<S> Combine<S>(this IEnumerable<DataRow> first, IEnumerable<DataRow> second,
                                                Func<DataRow, DataRow, S> func)
        {
            using(IEnumerator<DataRow> e1 = first.GetEnumerator(), e2 = second.GetEnumerator())
            {
                while(e1.MoveNext() && e2.MoveNext())
                {
                    yield return func(e1.Current, e2.Current);
                }
            }
        }
    }
}
