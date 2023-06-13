namespace Lorekeeper.Storage;

public class Location
{
	public Guid Id { get; set; }

	public string? Name { get; set; }

	public List<City>? Cities { get; set; }
}
