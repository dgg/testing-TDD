using System.Collections.Generic;

namespace Testing.TDD.Kata_3
{
	public interface IAlphabetProvider
	{
		IEnumerable<char> Alphabet { get; }
	}
}