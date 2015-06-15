using System.Globalization;
using Vertica.Utilities_v4.Extensions.StringExt;

namespace Testing.TDD.Kata_3
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