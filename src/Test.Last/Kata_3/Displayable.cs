namespace Testing.TDD.Kata_3
{
	public class Displayable : IAlphabeticallyAggregable
	{
		public Displayable() { }

		public Displayable(string id, string displayName)
		{
			Id = id;
			DisplayName = displayName;
		}

		public string Id { get; set; }
		public string DisplayName { get; set; }
	}
}