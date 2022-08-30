namespace MixInStyle.Core
{
    internal static class RecordRegistry
    {
        internal static List<Channel> RecordingChannels
        {
            get; set;
        } = new List<Channel>();

        internal static void Add(Channel c)
        {
            RecordingChannels.Add(c);
        }

        internal static void Remove(Channel c)
        {
            RecordingChannels.Remove(c);
        }
    }
}
