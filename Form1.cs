using ABI.System;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Security.Policy;

namespace Bypass
{
    public partial class Bypass : Form
    {

        bool s = false;

        bool dragging = false;
        Point dragCursorPoint;
        Point dragFormPoint;

        public Bypass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "\"D:\\Project\\Bypass\\bin\\bypass.bat\"";
                Process[] processes = Process.GetProcessesByName("winws");
                if (s == false)
                {
                    Process.Start(startInfo);
                    s = true;
                }
                else
                {
                    foreach (Process process in processes)
                    {
                        if (Process.GetProcessesByName("winws").Any())
                        {
                            MessageBox.Show("Программа с обходом уже открыта, нажмите OK чтобы закрыть программу");
                            process.Kill();
                            s = false;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка данная программа не открывается", "Error-Bypass", MessageBoxButtons.OK);
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("winws");
            foreach (Process process in processes)
            {
                process.Kill();
            }
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.Aqua;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Transparent;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Yellow;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.MediumSpringGreen;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.Yellow;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.MediumSpringGreen;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //panel2.Visible = false;
            MessageBox.Show("Пока что в разработаке...");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo()
            {
                FileName = "https://github.com/SenejuDev/Bypass",
                UseShellExecute = true
            });
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.Yellow;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.MediumSpringGreen;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo()
            {
                FileName = "https://t.me/BypassDevGit",
                UseShellExecute = true
            });
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.BackColor = Color.Yellow;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.MediumSpringGreen;
        }
    }
}

