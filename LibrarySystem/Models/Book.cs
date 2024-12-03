namespace LibrarySystem.Models;

public record Book
{
    public int BookId { get; init; }
    public required string BookName { get; init; }
}
