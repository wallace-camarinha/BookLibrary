using System.Text.Json.Serialization;

namespace BookLibrary.DTO
{
    public class CreateOrUpdateBookDTO
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("release_month")]
        public short ReleaseMonth { get; set; }

        [JsonPropertyName("release_year")]
        public short ReleaseYear { get; set; }

        [JsonPropertyName("publisher")]
        public string? Publisher { get; set; }

        [JsonPropertyName("number_of_pages")]
        public short? NumberOfPages { get; set; }

        [JsonPropertyName("author_id")]
        public Guid AuthorId { get; set; }
    }
}
