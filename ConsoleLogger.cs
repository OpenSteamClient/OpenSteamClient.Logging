namespace OpenSteamClient.Logging;

/// <summary>
/// Extremely simple logger that just puts everything through to the C# in built Console API.
/// Doesn't support fancy stuff like newline splitting or async logging.
/// </summary>
public sealed class ConsoleLogger : ILogger
{
	private readonly string name;

	public ConsoleLogger(string name)
	{
		this.name = name;
	}

	public void Write(LogLevel level, string data)
		=> Console.Write(string.Format("[{0} {1}: {2}] {3}", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss.ff"), name, level.ToString(), data));
}