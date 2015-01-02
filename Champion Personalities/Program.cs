using System;
using System.Collections.Generic;
using System.Linq;
using LeagueSharp;
using LeagueSharp.Common;

namespace Champion_Personalities
{
    public class Program
    {
        private static List<ChampionQuote> _championQuotes = new List<ChampionQuote>();

        private static void Main(string[] args)
        {
            
            // PUT CHAMPION QUOTES HERE

            // Rammus
            var rammus = new ChampionQuote("Rammus");
            rammus.AddStartQuote("OK.");
            rammus.AddDeathQuote("Sorry, Ok");
            rammus.AddDeathQuote
            _championQuotes.Add(rammus);

            // Leblanc
            var leblanc = new ChampionQuote("Leblanc");
            leblanc.Add("I'm over here, Now I'm over here, Can't hit what you can't see!");
            _championQuotes.Add(leblanc);

            // OTHER STUFF
            CustomEvents.Game.OnGameLoad += Game_OnGameLoad;
            CustomEvents.Game.OnGameEnd += Game_OnGameEnd;
        }

        private static void Game_OnGameLoad(EventArgs args)
		{
            Game.PrintChat("<font color=\"#1eff00\">Champion Personalities by JinxLover & WorstPing Loaded</font> - <font color=\"#00BFFF\">Loaded</font>");
            var championName = ObjectManager.Player.BaseSkinName;
			if(Game.ClockTime < 50)
			{
				var cq = _championQuotes.Where(c => c.GetChampionName() == championName).First();
				if(cq != null)
				{
					Utility.DelayAction.Add(5000, () => Game.Say("/all "+cq.GetRandomStartQuote()));
				}
			}
		}
    }

    public class ChampionQuote
    {
        private readonly string _championName;

        private readonly List<string> _startQuotes;
        private readonly List<string> _deathQuotes;
        private readonly List<string> _reconnectQuotes;
        private readonly List<string> _endQuotes;

        private readonly Random random;

        public ChampionQuote(string championName)
        {
            _championName = championName;
            random = new Random();
        }

        public string GetChampionName()
        {
            return _championName;
        }

        public void AddStartQuote(string quote)
        {
            _startQuotes.Add(quote);
        }

        public string GetRandomStartQuote()
        {
            return _startQuotes[random.Next(0, _startQuotes.Length)];
        }

        public void AddDeathQuote(string quote)
        {
            _deathQuotes.Add(quote);
        }

        public string GetRandomDeathQuote()
        {
            return _deathQuotes[random.Next(0, _deathQuotes.Length)];
        }

        public void AddReconnectQuote(string quote)
        {
            _reconnectQuotes.Add(quote);
        }

        public string GetRandomReconnectQuote()
        {
            return _reconnectQuotes[random.Next(0, _reconnectQuotes.Length)];
        }

        public void AddEndQuote(string quote)
        {
            _endQuotes.Add(quote);
        }

        public string GetRandomEndQuote()
        {
            return _endQuotes[random.Next(0, _endQuotes.Length)];
        }
    }
}
