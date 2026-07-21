using NLog;

var logger = LogManager.GetCurrentClassLogger();

logger.Info("Application Started");
logger.Debug("Loading configuration...");
logger.Warn("Low disk space.");
logger.Error("Database connection failed.");
logger.Fatal("Unexpected system failure.");

Console.WriteLine("NLog demonstration completed.");