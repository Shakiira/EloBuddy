using System;
using EloBuddy;
using EloBuddy.SDK.Events;

namespace JustMute
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Loading.OnLoadingComplete += Game_OnStart;
        }

        private static void Game_OnStart(EventArgs args)
        {
            Chat.Say("/mute all");

        }
    }
}
