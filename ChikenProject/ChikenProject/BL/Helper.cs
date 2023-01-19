using System.Windows.Forms;

namespace TheChicken.BL
{
    class Helper
    {
        public static void MessageDataBase(string Message)
        {
            MessageBox.Show(Message, "DataBase Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static bool MessageSave()
        {
            if (MessageBox.Show("Submit SuccessFully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool MessageEdit()
        {
            if (MessageBox.Show("Update SuccessFully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                return true;
            }

            return false;

        }
        public static void MessageDelete()
        {
            MessageBox.Show("Delete SuccessFully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void MessageSelectRow()
        {
            MessageBox.Show("Plese Select Row", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static bool DeleteDecesion()
        {
            if (MessageBox.Show("Are you sure? you want to delete this.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void MessageCustomError(string Message)
        {
            MessageBox.Show(Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void MessageShowCustome(string Message)
        {
            MessageBox.Show(Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void Authorit_Insert()
        {
            MessageBox.Show("You have not permission to insert", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void Authorit_Delete()
        {
            MessageBox.Show("You have not permission to Delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void Authorit_Update()
        {
            MessageBox.Show("You have not permission to Update", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
