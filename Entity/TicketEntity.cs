using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Bajeczkav2.Controllers;

[Table("bilety")]
public class TicketEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("biletid")]
    public int Id { get; set; }
    
    [Column("datazakupu")]
    [DataType(DataType.DateTime)]
    public DateTime PurchaseDate { get; set; }
    
	[Column("seansid")]   
    public int ShowtimeId { get; set; }
    
    [Column("rodzaj")]   
    public string TicketType { get; set; }
    
    [Column("uzytkownikid")]
    public int UserId { get; set; }
}