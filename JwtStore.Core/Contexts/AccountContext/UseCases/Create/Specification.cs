using Flunt.Notifications;
using Flunt.Validations;

namespace JwtStore.Core.Contexts.AccountContext.UseCases.Create;

public static class Specification
{
    public static Contract<Notification> Ensure(Request request) => new Contract<Notification>()
        .Requires()
        .IsLowerThan(request.Name.Length, 160, "Name", "Name must be less than 160 characters")
        .IsGreaterThan(request.Name.Length, 3, "FirstName", "FirstName must be less than 3 characters")
        .IsLowerThan(request.Password.Length, 40, "Password", "Password must be less than 40 characters")
        .IsGreaterThan(request.Password.Length, 8, "Password", "Password must be greater than 8 characters")
        .IsEmail(request.Email, "Email", "Email is invalid");
}