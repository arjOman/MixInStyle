using MixInStyle.Core;

namespace MixInStyle
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            try
            {
                Application.Run(new Mixer());
            }

            catch (Exception ex)
            {
                Clipboard.SetText(ex.ToString());
                if (MessageBox.Show("It looks like we ran into problem. The issue might be with corrupted settings or unseen bug. The error description has been copied to your clipboard. Do you wish to re-open the program after resetting the settings?", "Fatal RE", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    Core.Settings.Reset();
                    Application.Restart();
                }
                else
                {

                }
            }
        }
    }
}