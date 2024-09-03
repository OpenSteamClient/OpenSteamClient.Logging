namespace OpenSteamClient.Logging;

/// <summary>
/// Extremely simple logger that just puts everything through to the CLR Console API.
/// </summary>
public sealed class ConsoleLogger : ILogger
{
	public void Write(LogLevel level, string data)
		=> Console.Write($"[{DateTime.Now} {level}]: {data}");
}