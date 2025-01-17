using System;
using System.Collections.Generic;
using System.Linq;

namespace Nethermind.Core.Collections;

public static class EnuberableExtensions
{
    public static void ForEach<T>(this IEnumerable<T> list, Action<T> action)
    {
        list.ToList().ForEach(action);
    }
}
