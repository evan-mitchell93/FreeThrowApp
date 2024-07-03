using SQLite;

namespace FreeThrowTracking.Maui.Models;

//Data model for Athletes
//Eventually will track more than just Free Throws
//Will have players name,team,relative position
//Use players id as foreign key in other tables.

[SQLite.Table("player")]
public class Player
{
    [PrimaryKey, AutoIncrement, SQLite.Column("Id")]
    public int Id { get; set; }
    public String? FirstName { get; set; }

    public String? LastName { get; set; }

    public String? Team { get; set; }

    public String? Position { get; set; }

}