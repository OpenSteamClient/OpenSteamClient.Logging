namespace OpenSteamClient.Logging;

/// <summary>
/// Simple logger API that supports log levels.
/// Most of the expected logger functionality is in ILoggerExtensions.
/// </summary>
public interface ILogger {
	/// <summary>
	/// Writes data of the specified level to the logger. Does not add a line-break.
	/// </summary>
	public void Write(LogLevel level, string data);
}