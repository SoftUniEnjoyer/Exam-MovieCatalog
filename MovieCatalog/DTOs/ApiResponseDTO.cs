using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MovieCatalog.DTOs
{
    internal class ApiResponseDTO
    {
        [JsonPropertyName("msg")]
        public string Msg { get; set; }
             // comment
        [JsonPropertyName("movie")]
        public MovieDTO Movie { get; set; } = new MovieDTO();
    }
}