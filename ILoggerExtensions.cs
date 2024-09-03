using System;

namespace OpenSteamClient.Logging;

public static class ILoggerExtensions {
	/// <summary>
	/// Writes a message, of the specified level, adding a line break.
	/// </summary>
	public static void WriteLine(this ILogger logger, LogLevel level, string message)
		=> logger.Write(level, message + Environment.NewLine);

	/// <summary>
	/// Writes data of Info level to the logger. Does not add a line-break.
	/// </summary>
	public static void Write(this ILogger logger, string message)
		=> logger.Write(LogLevel.Info, message);

	/// <summary>
	/// Writes a message of Info level to the logger.
	/// </summary>
	public static void WriteLine(this ILogger logger, string message)
		=> WriteLine(logger, LogLevel.Info, message);

	/// <summary>
	/// Writes a message of Debug level to the logger.
	/// </summary>
	public static void Debug(this ILogger logger, string message)
		=> WriteLine(logger, LogLevel.Debug, message);

	/// <summary>
	/// Writes a message of Debug level to the logger.
	/// </summary>
	public static void Debug(this ILogger logger, string message, params object?[] formatObjs)
		=> WriteLine(logger, LogLevel.Debug, string.Format(message, formatObjs));
	
	/// <summary>
	/// Writes an exception as Debug level to the logger.
	/// </summary>
	public static void Debug(this ILogger logger, Exception e)
		=> WriteLine(logger, LogLevel.Debug, e.ToString());

	/// <summary>
	/// Writes a message of Debug level to the logger.
	/// </summary>
	public static void Trace(this ILogger logger, string message)
		=> WriteLine(logger, LogLevel.Debug, message);

	/// <summary>
	/// Writes a message of Debug level to the logger.
	/// </summary>
	public static void Trace(this ILogger logger, string message, params object?[] formatObjs)
		=> WriteLine(logger, LogLevel.Debug, string.Format(message, formatObjs));

	/// <summary>
	/// Writes an exception as Debug level to the logger.
	/// </summary>
	public static void Trace(this ILogger logger, Exception e)
		=> WriteLine(logger, LogLevel.Debug, e.ToString());

	/// <summary>
	/// Writes a message of Info level to the logger.
	/// </summary>
	public static void Info(this ILogger logger, string message)
		=> WriteLine(logger, LogLevel.Info, message);
	
	/// <summary>
	/// Writes a message of Info level to the logger.
	/// </summary>
	public static void Info(this ILogger logger, string message, params object?[] formatObjs)
		=> WriteLine(logger, LogLevel.Info, string.Format(message, formatObjs));

	/// <summary>
	/// Writes an exception as Info level to the logger.
	/// </summary>
	public static void Info(this ILogger logger, Exception e)
		=> WriteLine(logger, LogLevel.Info, e.ToString());

	/// <summary>
	/// Writes a message of Warning level to the logger.
	/// </summary>
	public static void Warning(this ILogger logger, string message)
		=> WriteLine(logger, LogLevel.Warning, message);
	
	/// <summary>
	/// Writes a message of Warning level to the logger.
	/// </summary>
	public static void Warning(this ILogger logger, string message, params object?[] formatObjs)
		=> WriteLine(logger, LogLevel.Warning, string.Format(message, formatObjs));

	/// <summary>
	/// Writes an exception as Warning level to the logger.
	/// </summary>
	public static void Warning(this ILogger logger, Exception e)
		=> WriteLine(logger, LogLevel.Warning, e.ToString());

	/// <summary>
	/// Writes a message of Error level to the logger.
	/// </summary>
	public static void Error(this ILogger logger, string message)
		=> WriteLine(logger, LogLevel.Error, message);

	/// <summary>
	/// Writes a message of Error level to the logger.
	/// </summary>
	public static void Error(this ILogger logger, string message, params object?[] formatObjs)
		=> WriteLine(logger, LogLevel.Error, string.Format(message, formatObjs));

	/// <summary>
	/// Writes an exception as Error level to the logger.
	/// </summary>
	public static void Error(this ILogger logger, Exception e)
		=> WriteLine(logger, LogLevel.Error, e.ToString());

	/// <summary>
	/// Writes a message of Fatal level to the logger.
	/// </summary>
	public static void Fatal(this ILogger logger, string message)
		=> WriteLine(logger, LogLevel.Fatal, message);

	/// <summary>
	/// Writes a message of Fatal level to the logger.
	/// </summary>
	public static void Fatal(this ILogger logger, string message, params object?[] formatObjs)
		=> WriteLine(logger, LogLevel.Fatal, string.Format(message, formatObjs));

	/// <summary>
	/// Writes an exception as Fatal level to the logger.
	/// </summary>
	public static void Fatal(this ILogger logger, Exception e)
		=> WriteLine(logger, LogLevel.Fatal, e.ToString());
}