using System.Drawing;
using System.Windows.Forms;

namespace AutonomiaMainSystem
{
    internal class Order
    {
        SystemMessages systemMessages = new SystemMessages();
        private int _itemsFound;

        public void UpdateField(ComboBox comboBox, BindingSource bindingSource, string index, string columnName)
        {
            if (comboBox.SelectedIndex != -1 )
            {
                index = comboBox.SelectedValue.ToString();
                bindingSource.Filter = $"[" + columnName + "]='" + index + "'";
            }
        }

        public void Search(DataGridView dataGridView, TextBox searchTextBox)
        {
            if (searchTextBox.Text != "")
            {
                MakeColorOfFindedItems(dataGridView, searchTextBox, Color.White, Color.Black, false);
                MakeColorOfFindedItems(dataGridView, searchTextBox, Color.Black, Color.White, true);

                if (_itemsFound > 0)
                {
                    systemMessages.ShowSuccessFindedItems(_itemsFound);
                }
                else
                {
                    systemMessages.ShowFailFindedItems();
                }

                _itemsFound = 0;
            }
            else
            {
                systemMessages.ShowErrorSearchingMessage();
            }
        }

        public void Clear(DataGridView dataGridView, BindingSource bindingSource, TextBox searchTextBox)
        {
            MakeColorOfFindedItems(dataGridView, searchTextBox, Color.White, Color.Black, false);
            bindingSource.Filter = "";
            searchTextBox.Text = "";

            _itemsFound = 0;
        }

        private void MakeColorOfFindedItems(DataGridView dataGridView, TextBox searchTextBox, Color backColor, Color foreColor, bool isSearching)
        {
            for (int i = 0; i < dataGridView.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView.RowCount; j++)
                {
                    if (isSearching)
                    {
                        if (dataGridView[i, j].Value.ToString().IndexOf(searchTextBox.Text) != -1)
                        {
                            dataGridView[i, j].Style.BackColor = backColor;
                            dataGridView[i, j].Style.ForeColor = foreColor;

                            _itemsFound++;
                        }
                    }
                    else
                    {
                        dataGridView[i, j].Style.BackColor = backColor;
                        dataGridView[i, j].Style.ForeColor = foreColor;
                    }
                }
            }
        }
    }
}
