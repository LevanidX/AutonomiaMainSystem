using System.Windows.Forms;

namespace AutonomiaMainSystem
{
    internal class SystemMessages
    {
        public void ShowWarningNoNullAllowedMessage()
        {
            MessageBox.Show(
                "Все поля должны быть заполнены!",
                "СИСТЕМА АВТОНОМИЯ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        public void ShowSuccessMessage()
        {
            MessageBox.Show(
                "Успешно!",
                "СИСТЕМА АВТОНОМИЯ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public void ShowSuccessFindedItems(int findedItems)
        {
            MessageBox.Show(
                "По вашему запросу найдено результатов - " + findedItems + ".",
                "СИСТЕМА АВТОНОМИЯ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public void ShowFailFindedItems()
        {
            MessageBox.Show(
                "По вашему запросу результатов не найдено!",
                "СИСТЕМА АВТОНОМИЯ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public void ShowErrorSearchingMessage()
        {
            MessageBox.Show(
                "Запрос не был введен в текстовое поле!",
                "СИСТЕМА АВТОНОМИЯ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
