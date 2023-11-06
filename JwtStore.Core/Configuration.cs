namespace JwtStore.Core;

public static class Configuration
{
    public static SecretsConfiguration Secrets { get; set; } = new SecretsConfiguration();
    public static EmailConfiguration Email { get; set; } = new EmailConfiguration();
    public static SendGridConfiguration SendGrid { get; set; } = new SendGridConfiguration();
    public static DataBaseConfiguration Database { get; set; } = new DataBaseConfiguration();
    
    public class DataBaseConfiguration
    {
        public string ConnectionString { get; set; } = string.Empty;
    }
    
    public class EmailConfiguration
    {
        public string DefaultFromEmail { get; set; } = "anderson@costa.com";
        public string DefaultFromName { get; set; } = "andersoncosta.com";
    }
    
    public class SendGridConfiguration
    {
        public string ApiKey { get; set; } = string.Empty;
    }
    
    public class SecretsConfiguration
    {
        public string ApiKey { get; set; } = string.Empty;
        public string JwtPrivateKey { get; set; } = string.Empty;
        public string PasswordSaltKey { get; set; } = string.Empty;
    }
}