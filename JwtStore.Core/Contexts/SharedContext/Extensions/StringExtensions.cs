using System.Text;

namespace JwtStore.Core.Contexts.SharedContext.Extensions;

public static class StringExtensions
{
    public static string ToBase64(this string value) => Convert.ToBase64String(Encoding.ASCII.GetBytes(value));
}