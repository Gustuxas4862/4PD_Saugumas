namespace PD4
{
    public partial class NewPasswordPanel : Form
    {
        private PasswordSearchPanel passwordSearchPanel;

        public NewPasswordPanel(PasswordSearchPanel _passwordSearchPanel)
        {
            InitializeComponent();

            passwordSearchPanel = _passwordSearchPanel;
        }

        private void UpdatePasswordButton_Click(object sender, EventArgs e)
        {
            passwordSearchPanel.UpdatePassword(PasswordInputField.Text);
            Hide();
        }
    }
}
