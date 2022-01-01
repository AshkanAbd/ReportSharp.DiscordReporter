using System.Collections.Generic;

namespace ReportSharp.DiscordReporter.Services.DiscordService
{
    public class DiscordConfig
    {
        public string Token { get; set; }
        public HashSet<ulong> Channels { get; set; }
    }
}