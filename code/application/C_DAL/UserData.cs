namespace application.C_DAL
{
    /// <summary>
    /// Represents the data of users as declared in the DB. Cannot be instanciated
    /// </summary>

    public abstract class UserData
    {
        public UserData(int id, string firstName, string lastName, string email, string phone)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
        }

        public int Id { get; }
        public string FirstName { get; } = string.Empty;
        public string LastName { get; } = string.Empty;
        public string Email { get; } = string.Empty;
        public string Phone { get; } = string.Empty;

    }
}
