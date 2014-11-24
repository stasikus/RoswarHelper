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

        public List<string> proxyList = new List<string>();

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

                //Application.DoEvents();

                for (int i = 0; i < LoadList.userDictionary.Count; i++)
                {
                    usersList.Items.Add(LoadList.userDictionary.ElementAt(i).Key);
                    Main.mainWork(i, LoadList.userDictionary.ElementAt(i).Key, LoadList.userDictionary.ElementAt(i).Value, textBox1);
                    //Thread th = new Thread(() => Main.mainWork(i, LoadList.userDictionary.ElementAt(i).Key, LoadList.userDictionary.ElementAt(i).Value));
                    //th.IsBackground = true;
                    //th.SetApartmentState(ApartmentState.MTA);
                    //th.Start();
                    Thread.Sleep(10);
                }

            }
            catch
            {
                MessageBox.Show("Файл не загружен - что-то пошло не так...");
            }
        }

        private void usersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Main.selectedAcc(usersList.SelectedIndex);
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            Main.goTo(usersList.SelectedIndex);
        }

        private void spendGold_25_Click(object sender, EventArgs e)
        {
            Main.spendGold(usersList.SelectedIndex, 0);
        }

        private void spendGold_75_Click(object sender, EventArgs e)
        {
            Main.spendGold(usersList.SelectedIndex, 1);
        }

        
    }
}
