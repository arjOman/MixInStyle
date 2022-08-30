using Newtonsoft.Json;

namespace MixInStyle.Core
{
    [Serializable]
    internal class Preferences
    {
        public short Channel { get; set; } = 2;
        public int SampleRate { get; set; } = 44100;
        public int Bits { get; set; } = 16;
        public int BufferMS { get; set; } = 50;

        public int Threshold { get; set; } = 250;
        public int BPS { get; set; } = 2;
    }

    internal static class Settings
    {
        static string path = AppDomain.CurrentDomain.BaseDirectory + "//Preferences.json";
        internal static Preferences Preferences()
        {
            if (!File.Exists(path))
                File.WriteAllText(path, JsonConvert.SerializeObject(new Preferences()));
            return JsonConvert.DeserializeObject<Preferences>(File.ReadAllText(path));
        }
        internal static bool Preferences(Preferences s)
        {
            try
            {
                File.WriteAllText(path, JsonConvert.SerializeObject(s));
                return true;
            }
            catch
            {
                return false;
            }
        }
        internal static void Reset()
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(new Preferences()));
        }
    }
}
