using MixInStyle.Core;
using NAudio.Wave;
using Pref = MixInStyle.Core.Settings;

namespace MixInStyle
{
    public partial class Channel : UserControl
    {
        public Channel()
        {
            InitializeComponent();
            PopulateBoxes();
        }

        private void PopulateBoxes()
        {
            inputSelector.Items.Clear();
            outputSelector.Items.Clear();
            foreach (var e in AudioDevices.GetInputDevices())
            {
                inputSelector.Items.Add(e.ProductName);
            }

            foreach (var e in AudioDevices.GetOutputDevices())
            {
                outputSelector.Items.Add(e.ProductName);
            }
        }

        internal WaveIn In;
        internal WaveOut Out;
        internal BufferedWaveProvider Provider;
        internal WaveFileWriter Writer;


        internal void LoadPlayback()
        {
            try
            {
                In.StopRecording();
                Out.Stop();
                In.Dispose();
                Out.Dispose();
                Provider.ClearBuffer();
                volumeBar.Value = 0;
            }

            catch
            {

            }

            In = new WaveIn()
            {
                DeviceNumber = inputSelector.SelectedIndex,
                WaveFormat = new WaveFormat(rate: Pref.Preferences().SampleRate, bits: Pref.Preferences().Bits, channels: Pref.Preferences().Channel),
                BufferMilliseconds = Pref.Preferences().BufferMS
            };

            Out = new WaveOut();
            Out.DeviceNumber = outputSelector.SelectedIndex;
            Out.Volume = 0.5f;

            Provider = new BufferedWaveProvider(In.WaveFormat);
            Provider.ReadFully = true;
            Out.Init(Provider);
            Out.Play();

            In.DataAvailable += In_DataAvailable;
            In.StartRecording();

        }

        private void In_DataAvailable(object? sender, WaveInEventArgs e)
        {
            Provider.AddSamples(e.Buffer, 0, e.BytesRecorded);

            float maxValue = Pref.Preferences().Threshold;
            int peakValue = 0;
            int bytesPerSample = Pref.Preferences().BPS;
            for (int index = 0; index < e.BytesRecorded; index += bytesPerSample)
            {
                int value = BitConverter.ToInt16(e.Buffer, index);
                peakValue = Math.Max(peakValue, value);
            }

            Console.WriteLine(peakValue);
            volumeBar.Value = (int)(((int)(peakValue / maxValue)) * (volKnob.Value / 100f));

        }

        private void recordToggle_Click(object sender, EventArgs e)
        {
            if (recordToggle.ForeColor == recordToggle.r)
            {
                if (inputSelector.Text == "" || outputSelector.Text == "")
                {
                    inputSelector.SelectedIndex = 0;
                    outputSelector.SelectedIndex = 0;
                }
                LoadPlayback();
                RecordRegistry.Add(this);
            }
            else
            {
                RecordRegistry.Remove(this);
                In.StopRecording();
                Out.Stop();
                In.Dispose();
                Out.Dispose();
                Provider.ClearBuffer();
                volumeBar.Value = 0;
            }
        }

        private void inputSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (recordToggle.ForeColor == recordToggle.r)
            {
                try
                {
                    In.StopRecording();
                    Out.Stop();
                    In.Dispose();
                    Out.Dispose();
                    Provider.ClearBuffer();
                    volumeBar.Value = 0;
                    LoadPlayback();
                }
                catch
                {

                }
            }
        }

        private void outputSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (recordToggle.ForeColor == recordToggle.r)
            {
                try
                {
                    In.StopRecording();
                    Out.Stop();
                    In.Dispose();
                    Out.Dispose();
                    Provider.ClearBuffer();
                    volumeBar.Value = 0;
                    LoadPlayback();
                }

                catch
                {

                }
            }
        }

        private void volKnob_ValueChanged(object Sender)
        {
            try
            {
                Out.Volume = volKnob.Value / 100f;
            }
            catch
            {

            }
        }
    }
}
