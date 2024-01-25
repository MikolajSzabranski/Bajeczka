using System;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("filmy")]
public class MovieEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("filmid")]
    public int Id { get; set; }

    [Column("datapremiery")]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    [Column("obraz")]
    public string Image { get; set; }
    
    [Column("tytul")]
    public string Title { get; set; }

    // public ICollection<Show> Shows { get; set; }
    public MovieEntity(string Image, string Title, DateTime ReleaseDate)
    {
		//this.Id = null;
        this.ReleaseDate = ReleaseDate;
        this.Image = Image;
        this.Title = Title;
    }
}