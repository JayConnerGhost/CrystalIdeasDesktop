namespace Crystal_Ideas_Desktop.Models
{
    public interface IRegisterProfileModel
    {
        string Email { get; set; }
        string LastName { get; set; }
        string FirstName { get; set; }
        string Password { get; set; }
    }
}