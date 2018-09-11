using System.Collections.Generic;
using Vertica.Utilities;

namespace Test.Last.Kata_3
{
	internal class DefaultAlphabetProvider : IAlphabetProvider
	{
		private readonly Range<char> _AToZ;

		public DefaultAlphabetProvider()
		{
			_AToZ = new Range<char>('A', 'Z');
		}

		public IEnumerable<char> Alphabet
		{
			get
			{
				return _AToZ.Generate(c => (char)(c + 1));
			}
		}
	}
}