using MixInStyle.Core;
using NAudio.Wave;
using System.Runtime.Serialization.Formatters.Binary;
using Pref = MixInStyle.Core.Settings;

namespace MixInStyle
{
    public partial class Mixer : Form
    {
        public Mixer()
        {
            InitializeComponent();
            PopulateMixer();
        }


        private void PopulateMixer()
        {
            int last = -50;
            for (int i = 0; i < 100; i++)
            {
                var v = new Channel() { Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left, Location = new Point(last += 50, 0) };
                v.Index.Text = (i + 1).ToString();
                channelPanel.Controls.Add(v);
            }
        }

        string path;
        private void recordBTN_Click(object sender, EventArgs e)
        {
            if (recordBTN.BackColor == Color.Red)
            {
                recordBTN.BackColor = Color.FromArgb(50, 50, 50);
                recordBTN.ForeColor = Color.Red;
                recordBTN.Text = "Stop";

                foreach (var v in channelPanel.Controls)
                {
                    var h = v as Channel;
                    h.recordToggle.Enabled = false;
                }

                FolderBrowserDialog sfd = new();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    path = sfd.SelectedPath + "//MixInStyle " + DateTime.Now.ToShortDateString().Replace('/', '_') + " " + DateTime.Now.ToShortTimeString().Replace(':', '-') + "//";
                    Directory.CreateDirectory(path);
                }

                else
                {
                    recordBTN.BackColor = Color.Red;
                    recordBTN.ForeColor = Color.White;
                    recordBTN.Text = "Record";

                    foreach (var v in channelPanel.Controls)
                    {
                        var h = v as Channel;
                        h.recordToggle.Enabled = true;
                    }
                }

                List<WaveFileWriter> writers = new List<WaveFileWriter>();
                int i = 0;
                foreach (Channel h in RecordRegistry.RecordingChannels)
                {
                    h.In.StopRecording();
                    h.Out.Stop();
                    h.Provider.ClearBuffer();

                    h.In = new WaveIn();
                    h.In.WaveFormat = new WaveFormat(Pref.Preferences().SampleRate, Pref.Preferences().Channel);
                    h.In.DeviceNumber = h.inputSelector.SelectedIndex;
                    h.In.DataAvailable += In_DataAvailable;
                    h.Writer = new WaveFileWriter(path + "Channel " + h.Index.Text + ".wav", h.In.WaveFormat);
                    h.In.StartRecording();
                    i++;


                    void In_DataAvailable(object? sender, WaveInEventArgs e)
                    {
                        h.Out.Volume = (h.volKnob.Value / 100f);
                        h.Writer.Write(e.Buffer, 0, e.BytesRecorded);

                        float maxValue = Pref.Preferences().Threshold;
                        int peakValue = 0;
                        int bytesPerSample = Pref.Preferences().BPS;
                        for (int index = 0; index < e.BytesRecorded; index += bytesPerSample)
                        {
                            int value = BitConverter.ToInt16(e.Buffer, index);
                            peakValue = Math.Max(peakValue, value);
                        }

                        Console.WriteLine(peakValue);
                        h.volumeBar.Value = (int)(((int)(peakValue / maxValue)) * (h.volKnob.Value / 100f));
                    }
                }

            }

            else
            {
                foreach (Channel h in RecordRegistry.RecordingChannels)
                {
                    h.In.StopRecording();
                    h.Writer.Dispose();
                }

                recordBTN.BackColor = Color.Red;
                recordBTN.ForeColor = Color.White;
                recordBTN.Text = "Record";

                var mixer = new WaveMixerStream32 { AutoStop = true };

                foreach (var t in Directory.GetFiles(path))
                {
                    var wav = new WaveFileReader(t);
                    mixer.AddInputStream(new WaveChannel32(wav));
                }


                WaveFileWriter.CreateWaveFile(path + "Recording.wav", new Wave32To16Stream(mixer));

                foreach (var v in channelPanel.Controls)
                {
                    var h = v as Channel;
                    h.recordToggle.Enabled = true;
                }
            }
        }

        private void coffee_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", "/c start https://www.buymeacoffee.com/arjoman");
        }


        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Settings().ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog sfd = new();
            sfd.Filter = @"MixInStyle Preset | *.mxn";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Cursor = Cursors.WaitCursor;
                try
                {
                    var p = (Preset)(new BinaryFormatter().Deserialize(new FileStream(sfd.FileName, FileMode.Open)));
                    bool missing = false;
                    for (int i = 0; i < p.Count; i++)
                    {
                        var h = (Channel)(channelPanel.Controls[i]);
                        h.inputSelector.SelectedItem = p[i].Item1;
                        h.outputSelector.SelectedItem = p[i].Item2;
                        h.volKnob.Value = p[i].Item3;

                        if ((h.inputSelector.SelectedItem != p[i].Item1 && h.inputSelector.SelectedItem == null) ||
                        (h.outputSelector.SelectedItem != p[i].Item2 && h.outputSelector.SelectedItem == null))
                        {
                            missing = true;
                        }
                    }
                    if (missing)
                    {
                        MessageBox.Show("The opened preset uses devices which are unavailable or has been disconnected", "Unavailable/Disconnected Devices", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch
                {
                    MessageBox.Show("The opened preset is corrupted", "Bad Preset", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                Cursor = Cursors.Default;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new();
            sfd.Filter = @"MixInStyle Preset | *.mxn";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Preset p = new();

                foreach (Channel c in channelPanel.Controls)
                {
                    p.Add(new Tuple<string, string, int>((string)c.inputSelector.SelectedItem, (string)c.outputSelector.SelectedItem, c.volKnob.Value));
                }
                FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate);
                new BinaryFormatter().Serialize(fs, p);
                fs.Close();
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            foreach (Channel c in channelPanel.Controls)
            {
                c.inputSelector.SelectedItem = null;
                c.outputSelector.SelectedItem = null;
                c.volKnob.Value = 50;

                c.volumeBar.Value = 0;
                
                c.In?.StopRecording();
                c.Out?.Stop();

                c.recordToggle.BackColor = c.recordToggle.r;
                c.recordToggle.ForeColor = c.recordToggle.s;
            }
            Cursor = Cursors.Default;
        }
    }
}