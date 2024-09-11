namespace OpenSteamClient.Logging;

/// <summary>
/// Creates loggers.
/// </summary>
public interface ILoggerFactory {
	/// <summary>
	/// Create a logger with the specified name.
	/// </summary>
	public ILogger CreateLogger(string name);
}