using MixInStyle.Core;

namespace MixInStyle
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            p = Core.Settings.Preferences();

            if (p.Channel == 1)
                monoRD.Checked = true;
            else
                stereoRD.Checked = true;
            smplCmb.SelectedItem = p.SampleRate.ToString();
            bitsCmb.SelectedItem = p.Bits.ToString();
            buffermsUpDown.Value = p.BufferMS;
            bpsCmb.SelectedItem = p.BPS.ToString();
            thresholdBox.Value = p.Threshold;
        }

        Preferences p;

        private void coffee_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", "/c start https://www.buymeacoffee.com/arjoman");
        }

        private void monoRD_CheckedChanged(object sender, EventArgs e)
        {
            p.Channel = 1;
        }

        private void stereoRD_CheckedChanged(object sender, EventArgs e)
        {
            p.Channel = 2;
        }

        private void smplCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            p.SampleRate = Convert.ToInt32(smplCmb.Items[smplCmb.SelectedIndex]);
        }

        private void bitsCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            p.Bits = Convert.ToInt32(bitsCmb.Items[bitsCmb.SelectedIndex]);
        }

        private void buffermsUpDown_ValueChanged(object sender, EventArgs e)
        {
            p.BufferMS = (int)buffermsUpDown.Value;
        }

        private void bpsCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            p.BPS = Convert.ToInt32(bpsCmb.Items[bpsCmb.SelectedIndex]);
        }

        private void thresholdBox_ValueChanged(object sender, EventArgs e)
        {
            p.Threshold = (int)thresholdBox.Value;
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Core.Settings.Preferences(p);
            foreach (Channel c in RecordRegistry.RecordingChannels)
            {
                c.LoadPlayback();
            }
        }
    }
}
