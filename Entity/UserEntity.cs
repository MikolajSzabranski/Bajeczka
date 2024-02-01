using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("uzytkownicy")]
public class UserEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("uzytkownikid")]
    public int Id { get; set; }
    
    [Column("imie")]
    public string FirstName { get; set; }
    [Column("nazwisko")]
    public string LastName { get; set; }
    [Column("login")]
    public string Login { get; set; }
    [Column("haslo")]
    public string Password { get; set; }
    [Column("typ_konta")]
    public string AccountType { get; set; }
    
//    [Column("datautworzeniakonta")]
  //  [DataType(DataType.DateTime)]
    //public DateTime AccountCreationDate { get; set; }
    
  //  [Column("LiczbaZakupionychBiletow")]
    //public int PurchasedTicketsCount { get; set; }
    
    // public ICollection<Ticket> Tickets { get; set; }
}