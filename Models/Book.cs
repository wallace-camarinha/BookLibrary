using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BookLibrary.Models
{
    public class Book
    {
        public Book
            (
                string title,
                string description,
                short releaseMonth,
                short releaseYear,
                string? publisher,
                short? numberOfPages,
                Guid? authorId
            )
        {
            this.Id = Guid.NewGuid();
            this.Title = title;
            this.Description = description;
            this.ReleaseMonth = releaseMonth;
            this.ReleaseYear = releaseYear;
            this.Publisher = publisher;
            this.NumberOfPages = numberOfPages;
            this.AuthorId = authorId;
            this.CreatedAt = DateTime.UtcNow;
            this.UpdatedAt = DateTime.UtcNow;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("id"), JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("title"), Column("title")]
        public string Title { get; set; }

        [JsonPropertyName("description"), Column("description")]
        public string Description { get; set; }

        [JsonPropertyName("release_month"), Column("release_month")]
        public short ReleaseMonth { get; set; }

        [JsonPropertyName("release_year"), Column("release_year")]
        public short ReleaseYear { get; set; }

        [JsonPropertyName("publisher"), Column("publisher")]
        public string? Publisher { get; set; }

        [JsonPropertyName("number_of_pages"), Column("number_of_pages")]
        public short? NumberOfPages { get; set; }

        [ForeignKey("Author"), JsonPropertyName("author_id"), Column("author_id")]
        public Guid? AuthorId { get; set; }

        [JsonPropertyName("author")]
        public Author Author { get; set; }

        [JsonPropertyName("created_at"), Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("updated_at"), Column("updated_at")]
        public DateTime UpdatedAt { get; set; }


    }
}
