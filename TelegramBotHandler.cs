using ChatGPT.Net;
using ChatGPT.Net.DTO.ChatGPT;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace ShopSorter;

public static class TelegramBotHandler
{
    private static Dictionary<string, string> _categories = new()
    {
        {"Dairy Products", "מוצרי חלב"},
        {"Toiletries", "טואלטיקה"},
        {"Fruits and Vegetables", "פירות וירקות"},
        {"Staples", "מוצרי יסוד"},
        {"Sweets", "מתוקים"},
        {"Baby Products", "תינוקות"},
        {"Beverages", "משקאות"},
        {"Hygiene", "היגיינה"},
        {"Housewares", "כלי בית"},
        {"Spices", "תבלינים"},
        {"Dried Fruits", "פירות יבשים"}
    };
    public static async Task UpdateHandler(ITelegramBotClient bot, Update update, CancellationToken token)
    {
        var message = update.Message;
        if (message is not null && !message.Text.Equals("/start"))
        {
            var openaiToken = Environment.GetEnvironmentVariable("OPENAI_API_KEY");
            var openai = new ChatGpt(openaiToken);
            var answer = await openai.Ask($"take this shopping list: {message.Text} " +
                                          $"( is this does not look like shopping list to you, please respond with the message: This is not seems like a shopping list, please provide one.)," +
                                          $" and sort it by supermarket categories. " +
                                          $"note that orders: 1. please provide the answer in Hebrew only!, 2. take the categories titles from this list {_categories}");
            await bot.SendTextMessageAsync(message.Chat.Id, answer);
        }
    }

    public static async Task ErrorHandler(ITelegramBotClient bot, Exception exception, CancellationToken token)
    {
        
    }
}