using PSR_GAME;

internal class Program
{
    private static void Main(string[] args)
    {
       Player bot = new Player();
       Player alex = new Player(VARIANTS.SCISSORTS,"alex");
        bot.whoWins(bot,alex);
    }
}