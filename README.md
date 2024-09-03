# OpenSteamClient.Logging
OpenSteamClient's own logging system.
Provides a simple `ILogger` type, which OpenSteamClient libraries use for logging.
You can implement `ILogger` yourself, or use `ConsoleLogger`, however it does not support log levels.