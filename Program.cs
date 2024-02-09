using NLog;

var logger = LogManager.GetCurrentClassLogger();

logger.Info("Hello, World!");

LogManager.Shutdown();
