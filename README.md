## ReportSharp.DiscordReporter-1.0.5:

### Description:

DiscordReporter for [ReportSharp](https://www.nuget.org/packages/ReportSharp) package

### Dependencies:

ReportSharp 1.0.5 or later

Dotnet Core 3.1 or later

### Usage:

#### Note:

You need to install and configure [ReportSharp](https://www.nuget.org/packages/ReportSharp/) `1.0.5` or later to use
this package.

### Dotnet 5 or below:

1) Add following lines to `ConfigureServices` method in `Startup` class:

```c#
services.AddReportSharp(options => {
    options.ConfigReportSharp(configBuilder =>
        configBuilder.SetWatchdogPrefix("/")
    );
    // For request reporter
    options.AddRequestReporter(() => new DiscordReporterOptionsBuilder()
        .SetToken("DiscordToken")
        .AddChannelId(discordChannelId)
    );
    // For exception reporter
    options.AddExceptionReporter(() => new DiscordReporterOptionsBuilder()
        .SetToken("DiscordToken")
        .AddChannelId(discordChannelId)
    );
    // For data reporter
    options.AddDataReporter(() => new DiscordReporterOptionsBuilder()
        .SetToken("DiscordToken")
        .AddChannelId(discordChannelId)
    );
    // For request, exception and data reporter
    options.AddReporter<DiscordReporter,DiscordReporterOptionsBuilder>(
        () => new DiscordReporterOptionsBuilder()
            .SetToken("DiscordToken")
            .AddChannelId(discordChannelId)
    );
});
```

##### Note: if you want to it for all reporters, you can use only `AddReporter` method.

2) Add following lines to `Configure` method in `Startup` class:

```c#
app.UseReportSharp(configure => {
    configure.UseReportSharpMiddleware<ReportSharpMiddleware>();
});
```

### Dotnet 6 or later:

1) Add following lines to `services` section, before `builder.Build()` line:

```c#
services.AddReportSharp(options => {
    options.ConfigReportSharp(configBuilder =>
        configBuilder.SetWatchdogPrefix("/")
    );
    // For request reporter
    options.AddRequestReporter(() => new DiscordReporterOptionsBuilder()
        .SetToken("DiscordToken")
        .AddChannelId(discordChannelId)
    );
    // For exception reporter
    options.AddExceptionReporter(() => new DiscordReporterOptionsBuilder()
        .SetToken("DiscordToken")
        .AddChannelId(discordChannelId)
    );
    // For data reporter
    options.AddDataReporter(() => new DiscordReporterOptionsBuilder()
        .SetToken("DiscordToken")
        .AddChannelId(discordChannelId)
    );
    // For request, exception and data reporter
    options.AddReporter<DiscordReporter,DiscordReporterOptionsBuilder>(
        () => new DiscordReporterOptionsBuilder()
            .SetToken("DiscordToken")
            .AddChannelId(discordChannelId)
    );
});
```

##### Note: if you want to it for all reporters, you can use only `AddReporter` method.

2) Add following lines to `Configure` section, somewhere after `builder.Build()` line and before `app.Run()` line:

```c#
app.UseReportSharp(configure => {
    configure.UseReportSharpMiddleware<ReportSharpMiddleware>();
});
```

### Donation:

#### If you like it, you can support me with `USDT`:

1) `TJ57yPBVwwK8rjWDxogkGJH1nF3TGPVq98` for `USDT TRC20`
2) `0x743379201B80dA1CB680aC08F54b058Ac01346F1` for `USDT ERC20`

