namespace OpenSteamClient.Logging;

public enum LogLevel {
	/// <summary>
	/// Debug/spewy information. Can get quite verbose, but might help extra with debugging.
	/// </summary>
	Debug,

	/// <summary>
	/// Basic-level logs. Messages that can be important in some cases, and while debugging.
	/// </summary>
	Info,

	/// <summary>
	/// Might affect user experience or cause slowdowns. Optional tasks failing in the background, etc.
	/// </summary>
	Warning,

	/// <summary>
	/// Will affect user experience. Features might be unavailable, or fail entirely, but could also be recoverable.
	/// </summary>
	Error,

	/// <summary>
	/// The app is unusable. Examples: Null pointer dereferences, missing required APIs, failed startup, corrupted install, etc.
	/// </summary>
	Fatal
}