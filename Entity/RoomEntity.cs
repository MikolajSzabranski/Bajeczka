using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Sale")]
public class RoomEntity
{
    // [Key]
    // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    // public int RoomId { get; set; }
    //
    // [Column("NumerSali")]
    // public int RoomNumber { get; set; }
    //
    // [Column("LiczbaMiejsc")]
    // public int SeatCount { get; set; }
    //
    // public ICollection<Show> Shows { get; set; }
}