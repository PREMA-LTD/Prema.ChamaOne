using Microsoft.Extensions.Options;
using Prema.ChamaOne.Infrastructure.AppSettings;
using Telegram.Bot;

namespace Prema.ChamaOne.Infrastructure.Telegram
{
    public class TelegramBot
    {
        private readonly TelegramBotSettings telegramBotSettings;

        private static TelegramBotClient bot;

        public TelegramBot(IOptionsMonitor<TelegramBotSettings> _telegramBotSettings)
        {
            telegramBotSettings = _telegramBotSettings.CurrentValue;
        }

        public TelegramBot()
        {
        }

        public void SendMessage(string message)
        {
            bot = new TelegramBotClient(telegramBotSettings.TelegramToken);
            foreach (int chatId in telegramBotSettings.TelegramChatId)
            {
                bot.SendTextMessageAsync(chatId, message);
            }
        }
    }
}
