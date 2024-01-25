using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Seanse")]
public class ShowEntity
{
    // [Key]
    // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    // public int ShowId { get; set; }
    //
    // [Column("DataSeansu")]
    // [DataType(DataType.Date)]
    // public DateTime ShowDate { get; set; }
    //
    // [Column("GodzinaSeansu")]
    // [DataType(DataType.Time)]
    // public TimeSpan ShowTime { get; set; }
    //
    // public int MovieId { get; set; }
    // public Movie Movie { get; set; }
    //
    // public int RoomId { get; set; }
    // public Room Room { get; set; }
    //
    // public ICollection<Ticket> Tickets { get; set; }
}