using AppointmentApp.Core.Data;
using AppointmentApp.Core.Localization;
using AppointmentApp.Core.Models;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace AppointmentApp.UserInterface
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            CultureInfo systemCulture = CultureInfo.InstalledUICulture;

            Thread.CurrentThread.CurrentUICulture = systemCulture;
            InitializeComponent();

            this.Text = Resources.LoginTitle;
            loginLabel.Text = Resources.LoginTitle;
            usernameLabel.Text = Resources.UsernameLabel;
            passwordLabel.Text = Resources.PasswordLabel;
            loginButton.Text = Resources.LoginButton;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show(
                    Resources.LoginErrorEmptyUsername,
                    Resources.LoginErrorLabel,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                   Resources.LoginErrorEmptyPassword,
                   Resources.LoginErrorLabel,
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);

                return;
            }

            try
            {
                User? user = UserRepository.VerifyLogin(username, password);
                if (user == null)
                {
                    MessageBox.Show(
                        Resources.LoginErrorInvalidCredentials,
                        Resources.LoginErrorLabel,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                this.Hide();
                LogLogin(username);
                MainForm mainForm = new(user);
                mainForm.ShowDialog();
                this.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    $"{Resources.DatabaseError}: {ex.Message}",
                    Resources.LoginErrorLabel,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
        }

        private static void LogLogin(string username)
        {
            // AppointmentApp\UserInteface\bin\Debug\net8.0\Logs\Login_History.txt
            string logDir = Path.Combine(Application.StartupPath, "Logs");

            Directory.CreateDirectory(logDir);

            string logfilePath = Path.Combine(logDir, "Login_History.txt");

            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string logEntry = $"{timestamp} - {username}";

            File.AppendAllText(logfilePath, logEntry + Environment.NewLine);
        }
    }
}
