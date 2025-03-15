namespace FullstackAPI.Models;

	public class Customer
	{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public string? Phone { get; set; }
    public required string Address { get; set; }
    public ICollection<Order>? Orders { get; set; }
}
