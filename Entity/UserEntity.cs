using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Uzytkownicy")]
public class UserEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("uzytkownikid")]
    public int UserId { get; set; }
    
    [Column("imie")]
    public string FirstName { get; set; }
    [Column("nazwisko")]
    public string LastName { get; set; }
    [Column("login")]
    public string Login { get; set; }
    [Column("haslo")]
    public string Password { get; set; }
    
    [Column("DataUtworzeniaKonta")]
    [DataType(DataType.DateTime)]
    public DateTime AccountCreationDate { get; set; }
    
    [Column("LiczbaZakupionychBiletow")]
    public int PurchasedTicketsCount { get; set; }
    
    // public ICollection<Ticket> Tickets { get; set; }
}