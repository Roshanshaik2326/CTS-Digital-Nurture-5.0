using System.Reflection;
using log4net;
using log4net.Config;

XmlConfigurator.Configure(new FileInfo("log4net.config"));

ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod()!.DeclaringType);

logger.Info("Application Started");
logger.Debug("Loading configuration...");
logger.Warn("Low disk space.");
logger.Error("Database connection failed.");
logger.Fatal("Unexpected system failure.");

Console.WriteLine("Logging completed successfully.");