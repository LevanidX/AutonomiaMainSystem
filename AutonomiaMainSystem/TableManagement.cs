using AutonomiaMainSystem.AUTONOMIADataSetTableAdapters;
using System.Data;
using System.Windows.Forms;

namespace AutonomiaMainSystem
{
    internal class TableManagement
    {
        SystemMessages systemMessages = new SystemMessages();

        public void AddNewItem(BindingSource bindingSource)
        {
            bindingSource.AddNew();
        }

        public void SaveNewItem(Form thisForm, BindingSource bindingSource, 
            TableAdapterManager tableAdapterManager, AUTONOMIADataSet aUTONOMIADataSet)
        {
            try
            {
                thisForm.Validate();
                bindingSource.EndEdit();
                tableAdapterManager.UpdateAll(aUTONOMIADataSet);

                systemMessages.ShowSuccessMessage();

                AddNewItem(bindingSource);
            }
            catch (NoNullAllowedException)
            {
                systemMessages.ShowWarningNoNullAllowedMessage();
            }
        }
    }
}
