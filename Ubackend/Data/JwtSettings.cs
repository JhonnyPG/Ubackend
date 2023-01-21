namespace Ubackend.Data
{
    public class JwtSettings
    {
        public bool ValidateIssuerSigningkey { get; set; }
        public string IssuerSigningkey  { get; set; } = string.Empty;
        public bool ValidateIssuer { get; set; } = true;
        public string? ValidIssuer { get; set; } 

        public bool ValidateAudiencie  { get; set; } = true;
        public string? ValidAudience  { get; set; }
        public bool RequiredExperationTime { get; set; } 
        public bool ValidateLifetime { get; set; } = true;

    }
}
