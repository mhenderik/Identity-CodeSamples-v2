﻿namespace blazor_jwt_validator_dotnet6.Models
{
    public class EncodedToken
    {
        public string? MetadataAddress { get; set; }
        public string? Issuer { get; set; }
        public string? Audience { get; set; }
        public string? Base64Token { get; set; }
    }
}
