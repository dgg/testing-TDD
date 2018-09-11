using System.Linq;
using Vertica.Utilities.Extensions.EnumerableExt;

namespace Test.Last.Kata_3
{
	public class AlphabeticalBucket<T> where T : IAlphabeticallyAggregable
	{
		public AlphabeticalBucket() { }

		public AlphabeticalBucket(char letter, T[] aggregables) : this((char?)letter, aggregables) { }

		private AlphabeticalBucket(char? letter, T[] aggregables)
		{
			Initial = letter;
			Aggregables = aggregables ?? new T[0];
		}

		public char? Initial { get; set; }
		public T[] Aggregables { get; set; }
		public bool IsEmpty { get { return !Aggregables.EmptyIfNull().Any(); } }

		public static AlphabeticalBucket<T> Overflow(T[] aggregables)
		{
			return new AlphabeticalBucket<T>(null, aggregables);
		}
	}
}