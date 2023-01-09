using Distance.Core;
using System.Collections.Generic;

namespace CursorDistance
{
    public partial class MainForm : Form
    {
        private HookDistanceService service;
        public MainForm()
        {
            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            service = new HookDistanceService();
            service.Notify += DistanceUpdated;
        }

        private async void TurnButton_Click(object sender, EventArgs e)
        {
            if (service.isSubscribed)
            {
                service.Unsubscribe();
                TurnButton.Text = "OFF";
                TurnButton.BackColor = Color.White;
            }
            else
            {
                service.Subscribe();
                TurnButton.Text = "ON";
                TurnButton.BackColor = Color.Green;
            }
        }
        private void DistanceUpdated(DistanceResult result)
        {
            PixelDistanceLabel.Text = (result.Pixels).ToString() + " Pixels";
            MetersDistanceLabel.Text = (result.Pixels * double.Parse(MultiplierTextBox.Text)).ToString() + " Meters";
            AzimuthLabel.Text = result.Azimuth.ToString("#.#") + "º";
            if (frm != null)
            {
                frm.Meters = (int)(result.Pixels * double.Parse(MultiplierTextBox.Text));
                frm.Azimuth = result.Azimuth;
            }               
        }

        private void MultiplierTextBox_TextChanged(object sender, EventArgs e)
        {
            MultiplierTextBox.Text = MultiplierTextBox.Text.Replace(",", ".");
        }
        Overlay? frm;
        private void OverlayButton_Click(object sender, EventArgs e)
        {
            if (frm == null)
            {
                frm = new Overlay();
                frm.isShowAzimuth = IsAzimuthShowingCheckBox.Checked;
                frm.Show();
                OverlayButton.Text = "Overlay ON";
                OverlayButton.BackColor = Color.Green;
            }
            else
            {
                frm.isWorking = false;
                frm.Close();
                frm = null;
                OverlayButton.Text = "Overlay OFF";
                OverlayButton.BackColor = Color.White;
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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (frm != null)
            {
                frm.isWorking = false;
                frm.Close();
            }
        }

        private void MultiplierTextbox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void IsAzimuthShowingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (frm != null)
            {
                frm.isShowAzimuth = IsAzimuthShowingCheckBox.Checked;
            }
        }
    }
}