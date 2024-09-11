namespace OpenSteamClient.Logging;

/// <summary>
/// Creates ConsoleLoggers. The name is not supported.
/// </summary>
public sealed class ConsoleLoggerFactory : ILoggerFactory
{
	public ILogger CreateLogger(string name)
		=> new ConsoleLogger();
}