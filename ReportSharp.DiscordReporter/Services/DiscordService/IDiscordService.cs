using System.Collections.Generic;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.Entities;

namespace ReportSharp.DiscordReporter.Services.DiscordService
{
    public interface IDiscordService
    {
        public DiscordClient GetDiscordClient();
        public HashSet<DiscordChannel> GetChannels();
        public Task SendMessage(string content);
    }
}