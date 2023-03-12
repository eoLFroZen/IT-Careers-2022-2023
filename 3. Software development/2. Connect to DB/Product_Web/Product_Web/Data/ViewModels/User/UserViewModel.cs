namespace Product_Web.Data.ViewModels.User
{
    public class UserViewModel
    {
        public UserViewModel(string id, string email, bool isAdmin)
        {
            Id = id;
            Email = email;
            IsAdmin = isAdmin;
        }

        public string Id { get; set; }

        public string Email { get; set; }

        public bool IsAdmin { get; set; }
    }
}
