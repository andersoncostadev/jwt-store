using System.Text.RegularExpressions;
using JwtStore.Core.Contexts.SharedContext.Extensions;
using JwtStore.Core.Contexts.SharedContext.ValueObjects;

namespace JwtStore.Core.Contexts.AccountContext.ValueObjects;

public partial class Email : ValueObject
{
    private const string Pattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
    
    protected Email()
    {
    }
    public Email(string address)
    {
        if (string.IsNullOrWhiteSpace(address))
            throw new ArgumentException("Invalid email address");

        Address = address.Trim().ToLower();
        
        if (Address.Length < 5)
            throw new ArgumentException("Invalid email address");
        
        if (!EmailRegex().IsMatch(Address))
            throw new ArgumentException("Invalid email address");
    }
    
    public string Address { get; }
    
    public Verification Verification { get; private set; } = new();
    
    public void RequestVerification() => Verification = new Verification();
    
    public string Hash => Address.ToBase64();
    
    public static implicit operator string(Email email) => email.ToString();
    
    public static implicit operator Email(string address) => new(address);
    
    public override string ToString() => Address;
    
    [GeneratedRegex(Pattern)]
    private static partial Regex EmailRegex();
}




