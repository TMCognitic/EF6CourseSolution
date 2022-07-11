using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EF6CourseSolution.Context
{
    internal static class StringExtensions
    {
        internal static byte[]? Hash(this string? value)
        {
            if (value is null)
                return null;

            byte[] bytes = Encoding.Default.GetBytes(value);
            return SHA512.HashData(bytes);
        }
    }
}
