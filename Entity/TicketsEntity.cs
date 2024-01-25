using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Bilety")]
public class TicketEntity
{
    // [Key]
    // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    // public int TicketId { get; set; }
    //
    // [Column("DataZakupu")]
    // [DataType(DataType.DateTime)]
    // public DateTime PurchaseDate { get; set; }
    //
    // public int ShowId { get; set; }
    // public Show Show { get; set; }
    //
    // public int UserId { get; set; }
    // public ApplicationUser User { get; set; }
}