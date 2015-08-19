using System;
using System.Collections.Generic;

namespace Testing.TDD.Kata_1
{
	public class MajorAndMinorEquality : IEqualityComparer<Version>
	{
		public bool Equals(Version x, Version y)
		{
			if (!ReferenceEquals(x, y) && (ReferenceEquals(null, y) || ReferenceEquals(x, null))) return false;
			if (ReferenceEquals(x, y)) return true;
			return x.Major.Equals(y.Major) && x.Minor.Equals(y.Minor);
		}

		public int GetHashCode(Version obj)
		{
			unchecked
			{
				return obj != null ? (obj.Major * 397) ^ obj.Minor : 0;
			}
		}
	}
}
