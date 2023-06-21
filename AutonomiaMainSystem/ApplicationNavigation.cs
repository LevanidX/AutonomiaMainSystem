using System.Windows.Forms;

namespace AutonomiaMainSystem
{
    internal class ApplicationNavigation
    {
        public void OpenNewWindow(Form currentWindow, Form newWindow)
        {
            currentWindow.Hide();
            newWindow.Show();
        }

        public void OpenMainMenu(Form currentWindow)
        {
            MainMenu mainMenu = new MainMenu();

            currentWindow.Close();
            mainMenu.Show();
        }
    }
}
