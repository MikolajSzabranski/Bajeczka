namespace Bajeczkav2;

using System;

public class Movie
{
    public int Id { get; init; }
    public string Title { get; set; }
    public string Genre { get; set; }
    public DateTime ReleaseDate { get; set; }
    
    public Movie(int id, string title, string genre, DateTime releaseDate)
    {
        Id = id;
        Title = title;
        Genre = genre;
        ReleaseDate = releaseDate;
    }
}