using NAudio.Wave;

namespace MixInStyle.Core
{
    internal class AudioDevices
    {
        internal static IEnumerable<WaveInCapabilities> GetInputDevices()
        {
            for (int deviceID = 0; deviceID < WaveIn.DeviceCount; deviceID++)
            {
                yield return WaveIn.GetCapabilities(deviceID);
            }
        }

        internal static IEnumerable<WaveOutCapabilities> GetOutputDevices()
        {
            for (int deviceID = 0; deviceID < WaveOut.DeviceCount; deviceID++)
            {
                yield return WaveOut.GetCapabilities(deviceID);
            }
        }
    }
}
