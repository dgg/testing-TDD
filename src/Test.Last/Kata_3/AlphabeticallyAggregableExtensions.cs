using System.Globalization;
using Vertica.Utilities.Extensions.StringExt;

namespace Test.Last.Kata_3
{
	internal static class AlphabeticallyAggregableExtensions
	{
		public static char Initial(this IAlphabeticallyAggregable aggregable, CultureInfo language)
		{
			char initial = '\0';
			if (aggregable != null && aggregable.DisplayName.IsNotEmpty())
			{
				initial = language.TextInfo.ToUpper(aggregable.DisplayName[0]);
			}
			return initial;
		}
	}
}