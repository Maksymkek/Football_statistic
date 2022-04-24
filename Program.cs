using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4_S_A
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
        static public bool validation = true;
        static public void checkParsing(TextBox box, ref int to_out, string Message)
        {
            if (!Int32.TryParse(box.Text, out to_out))
            {
                MessageBox.Show(Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                box.Clear();
                validation = false;
            }
        }
        static public void checkParsing(TextBox box, int min ,int max, string Message)
        {
            if (box.Text.Length > max || box.Text.Length < min)
            {
                MessageBox.Show(Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                box.Clear();
                validation = false;
            }
            
        }
        static public void checkParsing(TextBox box, ref int to_out, int min, int max, string Message)
        {
            if (!Int32.TryParse(box.Text, out to_out))
            {
                MessageBox.Show(Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                box.Clear();
                validation = false;
            }
            else
            {
                if (to_out> max || to_out < min)
                {
                    MessageBox.Show("Out of range", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    box.Clear();
                    validation = false;
                }
            }
        }
        static public bool checkParsing(string box, ref DateTime dateOrTime)
        {
            if (DateTime.TryParse(box,out dateOrTime))
            {
                return true;
            }
             MessageBox.Show("Incorrect data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}
