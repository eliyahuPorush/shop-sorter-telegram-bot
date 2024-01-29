using ShopSorter;
using Telegram.Bot;

var telegramToken = Environment.GetEnvironmentVariable("TELEGRAM_BOT_TOKEN");
var openaiToken = Environment.GetEnvironmentVariable("OPENAI_API_KEY");

if (telegramToken is null || openaiToken is null)
{
        throw new Exception("either telegram/openai tokens are missing");
}
var botClient = new TelegramBotClient(telegramToken);

botClient.StartReceiving(TelegramBotHandler.UpdateHandler, TelegramBotHandler.ErrorHandler);

Console.WriteLine("Shop Sorter app start successfully");
Console.ReadKey();

