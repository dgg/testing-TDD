using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Vertica.Utilities_v4.Extensions.EnumerableExt;
using Vertica.Utilities_v4.Patterns;

namespace Testing.TDD.Kata_3
{
	public class AlphabeticalAggregator
	{
		private readonly CultureInfo _language;
		private readonly IAlphabetProvider _provider;

		public AlphabeticalAggregator(CultureInfo language) : this(language, new DefaultAlphabetProvider()) { }

		public AlphabeticalAggregator(CultureInfo language, IAlphabetProvider provider)
		{
			_language = language;
			_provider = provider;
		}

		public AlphabeticalBucket<T>[] Aggregate<T>(IEnumerable<T> unordered) where T : IAlphabeticallyAggregable
		{
			var links = _provider.Alphabet.Select(c => new AlphabeticLink<T>(c, _language))
				// important!, otherwise a different instance of link will be returned when getting the bucket for the link
				.ToArray();
			var overflow = new OverflowLink<T>();
			var chain = ChainOfResponsibility.Empty<T>()
				.Chain(links)
				.Chain(overflow);

			unordered
				.EmptyIfNull()
				.OrderBy(d => d.DisplayName, StringComparer.Create(_language, false))
				.ForEach(chain.Handle);

			AlphabeticalBucket<T>[] buckets = links
				.Select(l => l.AsBucket())
				.Concat(new[] { overflow.AsBucket() })
				.ToArray();

			return buckets;
		}

		class AlphabeticLink<T> : ChainOfResponsibilityLink<T> where T : IAlphabeticallyAggregable
		{
			private readonly char _handledInitial;
			private readonly CultureInfo _language;
			private readonly Queue<T> _aggregables;

			public AlphabeticLink(char handledInitial, CultureInfo language)
			{
				_handledInitial = handledInitial;
				_language = language;

				_aggregables = new Queue<T>();
			}

			public override bool CanHandle(T context)
			{
				char initial = context.Initial(_language);
				return initial.Equals(_handledInitial);
			}

			protected override void DoHandle(T context)
			{
				_aggregables.Enqueue(context);
			}

			public AlphabeticalBucket<T> AsBucket()
			{
				return new AlphabeticalBucket<T>(_handledInitial, _aggregables.ToArray());
			}
		}

		class OverflowLink<T> : ChainOfResponsibilityLink<T> where T : IAlphabeticallyAggregable
		{
			private readonly Queue<T> _aggregables;

			public OverflowLink()
			{
				_aggregables = new Queue<T>();
			}

			public override bool CanHandle(T context)
			{
				return true;
			}

			protected override void DoHandle(T context)
			{
				_aggregables.Enqueue(context);
			}

			public AlphabeticalBucket<T> AsBucket()
			{
				return AlphabeticalBucket<T>.Overflow(_aggregables.ToArray());
			}
		}
	}

}