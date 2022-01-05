using System.Text.Json.Serialization;

namespace BookLibrary.DTO
{
    public class CreateOrUpdateAuthorDTO
    {
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        [JsonPropertyName("date_of_birth")]
        public DateTime DateOfBirth { get; set; }
    }
}
