using MyCdCollection.Models;
using Microsoft.EntityFrameworkCore;
namespace MyCdCollection.Data {
public class CdContext: DbContext{
    public CdContext(DbContextOptions<CdContext> options) : base(options) {

    }
  
//Knyter an till modellen och Namnet är det namnet som tabellen får i databasen
public DbSet<Album> Album {get; set;}
public DbSet<Artist> Artist {get; set;}
public DbSet<User> User {get; set;}
}
}