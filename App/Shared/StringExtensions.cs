﻿using System.Diagnostics.CodeAnalysis;

namespace Tellurian.Trains.Planning.App.Shared
{
    public static class StringExtensions
    {
        public static bool HasValue([AllowNull] this string? me) => !string.IsNullOrEmpty(me);
    }
}
