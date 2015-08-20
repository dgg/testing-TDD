using System;

namespace Test.Last.Kata_2
{
	static class StringExtensions
	{
		private static string nullOrAction(this string argument, Func<string> func)
		{
			string result = null;
			if (argument != null)
			{
				result = func();
			}
			return result;
		}

		public static string EmptyIfNull(this string s)
		{
			return s ?? string.Empty;
		}

		public static bool IsEmpty(this string str)
		{
			return string.IsNullOrEmpty(str);
		}

		public static string Left(this string s, int length)
		{
			length = Math.Max(length, 0);
			return s.nullOrAction(() => (s.Length > length) ? s.Substring(0, length) : s);
		}

		/// <summary>
		/// Returns the left part from the first ocurrence of the given substring (without the substring).
		/// </summary>
		/// <remarks>
		/// Features driven by this set of rules:
		/// <list type="bullet">
		/// <item><description>null.LeftFromFirst(*) --> null</description></item>
		/// <item><description>null and string.Empty are always substrings of a not null string</description></item>
		/// /// <item><description>string.Empty only contains itself and null</description></item>
		/// <item><description>*.LeftFromFirst(notFound) --> null</description></item>
		/// </list>
		/// </remarks>
		/// <param name="s"></param>
		/// <param name="substring"></param>
		/// <returns></returns>
		public static string LeftFromFirst(this string s, string substring)
		{
			return s.nullOrAction(() =>
			{
				substring = substring.EmptyIfNull();
				int indexOfSubstringStart = s.IndexOf(substring) >= 0 ?
																		s.IndexOf(substring) : -1;

				return indexOfSubstringStart < 0 ? null : s.Left(indexOfSubstringStart);
			});
		}

		/// <summary>
		/// Returns the left part from the last ocurrence of the given substring (without the substring).
		/// </summary>
		/// <remarks>
		/// Features driven by this set of rules:
		/// <list type="bullet">
		/// <item><description>null.LeftFromLast(*) --> null</description></item>
		/// <item><description>null and string.Empty are always substrings of a not null string</description></item>
		/// /// <item><description>string.Empty only contains itself and null</description></item>
		/// <item><description>*.LeftFromLast(notFound) --> null</description></item>
		/// </list>
		/// </remarks>
		/// <param name="s"></param>
		/// <param name="substring"></param>
		/// <returns></returns>
		public static string LeftFromLast(this string s, string substring)
		{
			return s.nullOrAction(() =>
			{
				substring = substring.EmptyIfNull();
				int indexOfSubstringStart = -1;

				if (substring.IsEmpty())
					indexOfSubstringStart = 0;
				else if (s.LastIndexOf(substring) >= 0)
					indexOfSubstringStart = s.LastIndexOf(substring);

				return indexOfSubstringStart < 0 ? null : s.Left(indexOfSubstringStart);
			});
		}
	}
}
