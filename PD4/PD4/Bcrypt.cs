namespace PD4
{
    internal class Bcrypt
    {
        public string HashPassword(string _password)
        {
            return BCrypt.Net.BCrypt.HashPassword(_password);
        }

        public bool ValidatePassword(string _password, string _hash)
        {
            return BCrypt.Net.BCrypt.Verify(_password, _hash);
        }
    }
}
