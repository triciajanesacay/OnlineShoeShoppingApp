namespace OnlineShoeShopping.DL
{
    public class Costumer
    {
        private string email;
        private string password;
        public Costumer(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string PassWord
        {
            get { return password; }
            set { password = value; }
        }
    }
}