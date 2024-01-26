using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("bilety")]
public class TicketEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("biletid")]
    public int Id { get; set; }
    //
    // [Column("datazakupu")]
    // [DataType(DataType.DateTime)]
    // public DateTime PurchaseDate { get; set; }
    //
    // [Column("seansid")]   
    // public int ShowId { get; set; }
    //
    // [Column("uzytkownikid")]
    // public int UserId { get; set; }
}