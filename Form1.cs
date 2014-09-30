using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoswarHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static Dictionary<int, int> webBrowsersDic = new Dictionary<int, int>();


        private DialogResult STAShowDialog(FileDialog dialog)
        {
            DialogState state = new DialogState();
            state.dialog = dialog;
            System.Threading.Thread t = new System.Threading.Thread(state.ThreadProcShowDialog);
            t.SetApartmentState(System.Threading.ApartmentState.STA);
            t.Start();
            t.IsBackground = true;
            t.Join();
            return state.result;
        }

        private void loadListBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String pathLocation = String.Empty;
                OpenFileDialog frm = new OpenFileDialog();
                frm.InitializeLifetimeService();
                frm.Filter = "Config Files (*.txt)|*.txt";
                frm.Title = "Browse Config file";
                DialogResult dialRes = STAShowDialog(frm);

                if (dialRes == DialogResult.OK)
                    pathLocation = frm.FileName;

                string path;
                if (pathLocation != "")
                {
                    path = pathLocation;
                    LoadList.loadUsersList(path);
                }

                for (int i = 0; i < LoadList.userDictionary.Count; i++)
                {
                    usersList.Items.Add(LoadList.userDictionary.ElementAt(i).Key);
                }

            }
            catch
            {
                MessageBox.Show("Файл не загружен - что-то пошло не так...");
            }
        }

        
    }
}
