namespace OpenSteamClient.Logging;

/// <summary>
/// Creates ConsoleLoggers.
/// </summary>
public sealed class ConsoleLoggerFactory : ILoggerFactory
{
	public ILogger CreateLogger(string name)
		=> new ConsoleLogger(name);
}