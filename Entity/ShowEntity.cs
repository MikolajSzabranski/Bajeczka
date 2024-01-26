using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("seanse")]
public class ShowEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("seansid")]
    public int Id { get; set; }
    
    [Column("dataseansu")]
    [DataType(DataType.DateTime)]
    public DateTime ShowDate { get; set; }
    
    [Column("godzinaseansu")]
    [DataType(DataType.Time)]
    public TimeSpan ShowTime { get; set; }
    
    [Column("filmid")]
    public int MovieId { get; set; }
    
    //public Movie Movie { get; set; }
    
    //public int RoomId { get; set; }
    //public Room Room { get; set; }
    
    //public ICollection<Ticket> Tickets { get; set; }
}