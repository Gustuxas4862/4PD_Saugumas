using System.Text;

namespace PD4
{
    public partial class AddNewPassword : Form
    {
        private string filePath;
        private AES AESAlgorithm = new AES();
        private List<string> dataList = new List<string>();

        public AddNewPassword(string _filePath)
        {
            InitializeComponent();

            filePath = _filePath;
        }

        private void SaveDataButton_Click(object sender, EventArgs e)
        {
            if (!isEmpty(NameInputField.Text, PasswordInputField.Text, URLLinkInputField.Text, AdditionInfoInputField.Text))
            {
                if (canCreateName(NameInputField.Text))
                {
                    string encryptedPassword = Convert.ToBase64String(AESAlgorithm.RunEncryptor(PasswordInputField.Text, "1234567891234567"));

                    string line = Environment.NewLine + encryptedPassword + Environment.NewLine + NameInputField.Text + Environment.NewLine + URLLinkInputField.Text + Environment.NewLine + AdditionInfoInputField.Text + Environment.NewLine;
                    File.AppendAllText(filePath, line);

                    MessageBox.Show("Form data succesfully saved!");
                }
                else
                {
                    MessageBox.Show("Name already exists in the system!");
                }
            }
            else
            {
                MessageBox.Show("All empty input fields must be filled!");
            }

            dataList.Clear();
        }

        private void RandomPasswordButton_Click(object sender, EventArgs e)
        {
            PasswordInputField.Text = GenerateRandomPassword();
        }

        private string GenerateRandomPassword()
        {
            int passwordLength = 0;
            string validSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            passwordLength = rnd.Next(8, 20);
            while (0 < passwordLength--)
            {
                res.Append(validSymbols[rnd.Next(validSymbols.Length)]);
            }

            return res.ToString();
        }

        private bool canCreateName(string name)
        {
            foreach (string line in File.ReadLines(filePath))
            {
                if (line == name)
                {
                    return false;
                }
            }

            return true;
        }

        public bool isEmpty(string username, string password, string url, string additionalInfo)
        {
            if (!username.Equals("") && !password.Equals("") && !url.Equals("") && !additionalInfo.Equals(""))
            {
                return false;
            }

            return true;
        }
    }
}
