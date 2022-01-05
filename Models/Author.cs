using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BookLibrary.Models
{
    public class Author
    {
        public Author
            (
                string firstName,
                string lastName,
                DateTime dateOfBirth
            )
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.CreatedAt = DateTime.UtcNow;
            this.UpdatedAt = DateTime.UtcNow;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("id"), JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("first_name"), Column("first_name")]
        public string FirstName { get; set; }

        [JsonPropertyName("last_name"), Column("last_name")]
        public string LastName { get; set; }

        [JsonPropertyName("date_of_birth"), Column("date_of_birth")]
        public DateTime DateOfBirth { get; set; }

        [JsonPropertyName("books"), Column("books")]
        public Book[] Books { get; set; }

        [JsonPropertyName("created_at"), Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("updated_at"), Column("updated_at")]
        public DateTime UpdatedAt { get; set; }

    }
}
