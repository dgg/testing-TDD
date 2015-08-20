using System.Collections.Generic;

namespace Test.Last.Kata_3
{
	public interface IAlphabetProvider
	{
		IEnumerable<char> Alphabet { get; }
	}
}