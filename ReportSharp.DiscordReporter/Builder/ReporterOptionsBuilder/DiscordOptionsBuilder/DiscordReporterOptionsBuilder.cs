using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using ReportSharp.Builder.ReporterOptionsBuilder;
using ReportSharp.DiscordReporter.Services.DiscordService;

namespace ReportSharp.DiscordReporter.Builder.ReporterOptionsBuilder.DiscordOptionsBuilder
{
    public class DiscordReporterOptionsBuilder :
        IDataReporterOptionsBuilder<Reporters.DiscordReporter.DiscordReporter>,
        IExceptionReporterOptionsBuilder<Reporters.DiscordReporter.DiscordReporter>,
        IRequestReporterOptionsBuilder<Reporters.DiscordReporter.DiscordReporter>
    {
        private readonly HashSet<ulong> _channelIds = new HashSet<ulong>();
        private string _token;

        public void Build(IServiceCollection serviceCollection)
        {
            serviceCollection.Configure<DiscordConfig>(config => {
                config.Token = _token;
                config.Channels = _channelIds;
            });

            serviceCollection.AddSingleton<IDiscordService, DiscordService>();
        }

        public DiscordReporterOptionsBuilder SetToken(string token)
        {
            _token = token;
            return this;
        }

        public DiscordReporterOptionsBuilder AddChannelId(ulong channelId)
        {
            _channelIds.Add(channelId);
            return this;
        }
    }
}