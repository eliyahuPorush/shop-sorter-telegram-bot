# Supermarket Shopping List Sorter Bot

Welcome to the Supermarket Shopping List Sorter Bot! This bot helps you organize your shopping list based on supermarket categories. Developed using **.NET 8** and integrating the power of the **OpenAI GPT API**, this bot streamlines your shopping experience by categorizing items efficiently.

## Features

- **Telegram Bot Integration**: Seamlessly interacts with Telegram for easy access and usability.
- **Shopping List Sorting**: Sorts your shopping list into supermarket categories for a more organized shopping experience.
- **Language Support**: Currently supports the Hebrew language.

## Prerequisites

Before using the bot, ensure you have the following installed:

- .NET 8 SDK or higher
- Telegram account (to interact with the bot)

## Installation

To set up the Supermarket Shopping List Sorter Bot:

1. Clone this repository to your local machine:

    ```
    git clone https://github.com/your-username/supermarket-shopping-bot.git
    ```

2. Navigate to the project directory:

    ```
    cd supermarket-shopping-bot
    ```

3. Install dependencies:

    ```
    dotnet restore
    ```

4. Set environment variables for your Telegram bot token and OpenAI API key:

   - **Telegram Bot Token**: Set an environment variable named `TELEGRAM_BOT_TOKEN` with your Telegram bot token.
   - **OpenAI GPT API Key**: Set an environment variable named `OPENAI_API_KEY` with your OpenAI GPT API key.

   Example (Linux/macOS):

   ```bash
   export TELEGRAM_BOT_TOKEN=your-telegram-bot-token
   export OPENAI_API_KEY=your-openai-api-key
   ```
   Example (Windows):

   ```cmd
   set TELEGRAM_BOT_TOKEN=your-telegram-bot-token
   set OPENAI_API_KEY=your-openai-api-key
   ```

5. Compile the application:

    ```
    dotnet build
    ```

6. Run the application:

    ```
    dotnet run
    ```

## Usage

1. Start a conversation with the [bot](https://t.me/shopSorter_bot) on Telegram.
2. Send your shopping list in Hebrew to the bot.
3. The bot will process your list and sort it into appropriate supermarket categories.
4. Review the sorted list and proceed with your shopping accordingly.

## Contributing

Contributions are welcome! If you find any bugs or have suggestions for improvement, please feel free to open an issue or create a pull request.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
