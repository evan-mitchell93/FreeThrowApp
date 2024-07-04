using SQLite;

namespace FreeThrowTracking.Maui.Models;

//Data model for Athletes
//Eventually will track more than just Free Throws
//Will have players name,team,relative position
//Use players id as foreign key in other tables.

[SQLite.Table("team")]
public class Team
{
    [PrimaryKey, AutoIncrement, SQLite.Column("Id")]
    public int Id { get; set; }
    
    public String? Name { get; set; }

    public String? HeadCoach { get; set; }

    public String? AssistantCoach1 { get; set; }

    public String? AssistantCoach2 { get; set; }

}