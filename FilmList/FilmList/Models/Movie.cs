namespace FilmList.Models
{
    public class Movie
    {
        public string Title { get; set; } = string.Empty;
        public string Year { get; set; } = string.Empty;
        public string imdbID { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Poster { get; set; } = string.Empty;
        public string Rated {  get; set; } = string.Empty;
        public string Runtime { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Language { get; set; } = string.Empty;
        public string Actors { get; set; } = string.Empty;
        public string Director { get; set; } = string.Empty;
        public List<Ratings> Ratings { get; set; } = new();
    }
}
