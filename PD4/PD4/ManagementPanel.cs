namespace PD4
{
    public partial class ManagementPanel : Form
    {
        private string filePath = @"C:\Users\gustu\Desktop\Cryptography\4 Praktinis darbas\PD4\Account Data\FormData.txt";
        private string AccountFilePath = @"C:\Users\gustu\Desktop\Cryptography\4 Praktinis darbas\PD4\Account Data\AccountData.txt";
        private AES AESAlgorithm = new AES();
        private List<string> dataList = new List<string>();

        public ManagementPanel()
        {
            InitializeComponent();

            if (!File.Exists(filePath))
            {
                StreamWriter streamWriter = File.CreateText(filePath);
                streamWriter.Close();
            }
            else
            {
                EncryptAndAppendChanges(AlgorithmMode.Decryptor);

                dataList.Clear();
            }
        }

        private void ManagementPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataList.Clear();

            EncryptAndAppendChanges(AlgorithmMode.Encryptor);

            EncryptRegisteredAccount();

            Environment.Exit(0);
        }

        private void EncryptAndAppendChanges(AlgorithmMode algorithmMode)
        {
            foreach (string line in File.ReadLines(filePath))
            {
                string encryptedData = "";

                if (line == "")
                {
                    dataList.Add(" ");
                    continue;
                }

                if (algorithmMode == AlgorithmMode.Encryptor)
                {
                    encryptedData = Convert.ToBase64String(AESAlgorithm.RunEncryptor(line, "1234567891234567"));
                }
                else
                {
                    encryptedData = AESAlgorithm.RunDecryptor(line, "1234567891234567");
                }

                dataList.Add(encryptedData);
            }

            File.WriteAllText(filePath, string.Empty);

            foreach (string line in dataList)
            {
                File.AppendAllText(filePath, line + Environment.NewLine);
            }
        }

        private void NewPasswordButton_Click(object sender, EventArgs e)
        {
            AddNewPassword newPasswordPanel = new AddNewPassword(filePath);
            newPasswordPanel.Show();
        }

        private void PasswordSearchButton_Click(object sender, EventArgs e)
        {
            PasswordSearchPanel passwordSearchPanel = new PasswordSearchPanel(filePath);
            passwordSearchPanel.Show();
        }

        private void EncryptRegisteredAccount()
        {
            var lineConstructor = File.ReadLines(AccountFilePath);
            string encryptedPassword = Convert.ToBase64String(AESAlgorithm.RunEncryptor(lineConstructor.ElementAt(1), "1234567891234567"));
            string encryptedUsername = Convert.ToBase64String(AESAlgorithm.RunEncryptor(lineConstructor.ElementAt(0), "1234567891234567"));

            File.WriteAllText(AccountFilePath, string.Empty);
            string line = encryptedUsername + Environment.NewLine + encryptedPassword;
            File.AppendAllText(AccountFilePath, line);
        }
    }

    public enum AlgorithmMode
    {
        Encryptor,
        Decryptor
    }
}
