using Distance.Core;
using System.Collections.Generic;

namespace CursorDistance
{
    public partial class Form1 : Form
    {
        private HookDistanceService service;
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            service = new HookDistanceService();
            //await web.Run();
            service.Notify += DistanceUpdated;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (service.isSubscribed)
            {
                service.Unsubscribe();
                button1.Text = "OFF";
                button1.BackColor = Color.White;
            }
            else
            {
                service.Subscribe();
                button1.Text = "ON";
                button1.BackColor = Color.Green;
            }
        }
        private void DistanceUpdated(DistanceResult result)
        {
            label2.Text = (result.Pixels).ToString("#") + " Pixels";
            label1.Text = (result.Pixels * double.Parse(textBox1.Text)).ToString("#") + " Meters";
            label6.Text = result.Azimuth.ToString("#.#") + "º";
            if (frm != null)
                frm.meters = (result.Pixels * double.Parse(textBox1.Text)).ToString("#");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Replace(",", ".");
        }
        Overlay? frm;
        private void button2_Click(object sender, EventArgs e)
        {
            if (frm == null)
            {
                frm = new Overlay();
                frm.Show();
                button2.Text = "Overlay ON";
                button2.BackColor = Color.Green;
            }
            else
            {
                frm.isWorking = false;
                frm.Close();
                frm = null;
                button2.Text = "Overlay OFF";
                button2.BackColor = Color.White;
            }
        }

        private void LeftMouseButtonCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            service.EnableLeftClick = LeftMouseButtonCheckbox.Checked;
        }

        private void RightMouseButtonCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            service.EnableRightClick = RightMouseButtonCheckbox.Checked;
        }

        private void MiddleMouseButtonCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            service.EnableMiddleClick = MiddleMouseButtonCheckbox.Checked;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (frm != null)
            {
                frm.isWorking = false;
                frm.Close();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}