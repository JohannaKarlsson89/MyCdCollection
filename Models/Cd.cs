using System.ComponentModel.DataAnnotations;
namespace MyCdCollection
{
    //Artist is the principal entity to Album
    public class Artist
    {
        public int ArtistId { get; set; }
        [Required(ErrorMessage = "Add an artist")]
        [Display(Name = "Artist: ")]
        public string? ArtistName { get; set; }
        [Required(ErrorMessage = "Add a origin country")]
        [Display(Name = "Origin country: ")]
        public string? OriginCountry { get; set; }
        [Required(ErrorMessage = "Add year of birth")]
        [Display(Name = "Year of birth: ")]
        public string? YearOfBirth { get; set; }
        //Koppling till Album
        public List<Album>? Album { get; set; }
    }
    //Album is the dependent entity to Artist
    //Album is the principal entity to User
    public class Album
    {
        public int AlbumId { get; set; }
        [Required(ErrorMessage = "Add album name")]
        [Display(Name = "Album name: ")]
        public string? AlbumName { get; set; }
        [Required(ErrorMessage = "Add published year")]
        [Display(Name = "Published: ")]
        public string? YearPublished { get; set; }
        // Principal Key (Primary key)
        [Required(ErrorMessage = "Add an artist")]
        [Display(Name = "Artist: ")]
        //koppling till artist
        public int ArtistId { get; set; }
        public Artist? Artist { get; set; }
        //koppling till user
        public List<User>? User { get; set; }
    }

    //User is the dependent entity to album

    public class User
    {

        public int UserId { get; set; }
        [Required(ErrorMessage = "Add a name")]
        [Display(Name = "Rented by: ")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "Add a date")]
        [Display(Name = "Date rented: ")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? StartDate { get; set; }

        [Required(ErrorMessage = "Add a return")]
        [Display(Name = "Date it will be returned: ")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? EndDate { get; set; }
         [Required(ErrorMessage = "Add a album")]
        //Koppling till album
        [Display(Name = "Album name: ")]
        public int AlbumId { get; set; }
        public Album? Album { get; set; }

    }
}

// dotnet aspnet-codegenerator controller -name ArtistController -m Artist -dc CdContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries

// dotnet aspnet-codegenerator controller -name AlbumController -m Album -dc CdContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries

// dotnet aspnet-codegenerator controller -name UserController -m User -dc CdContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries

// dotnet ef migrations add AddUserTable