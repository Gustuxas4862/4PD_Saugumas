namespace PD4
{
    public partial class LoginPanel : Form
    {
        string filePath = @"C:\Users\gustu\Desktop\Cryptography\4 Praktinis darbas\PD4\Account Data\AccountData.txt";
        private AES AESAlgorithm = new AES();

        public LoginPanel()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Bcrypt bcryptAlgorithm = new Bcrypt();

            var lineConstructor = File.ReadLines(filePath);
            string decryptedUsername = AESAlgorithm.RunDecryptor(lineConstructor.ElementAt(0), "1234567891234567");
            string decryptedPassword = AESAlgorithm.RunDecryptor(lineConstructor.ElementAt(1), "1234567891234567");
            bool verifyPassword = bcryptAlgorithm.ValidatePassword(PasswordInputField.Text, decryptedPassword);

            if (verifyPassword && decryptedUsername == UsernameInputField.Text)
            {
                File.WriteAllText(filePath, string.Empty);
                string line = decryptedUsername + Environment.NewLine + decryptedPassword;
                File.AppendAllText(filePath, line);

                ManagementPanel managementPanel = new ManagementPanel();
                managementPanel.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password!");
            }
        }

        private void LoginPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
