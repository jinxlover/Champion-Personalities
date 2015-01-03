using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;
using LeagueSharp.Common;



namespace ConsoleApplication5
{
    public class Program
    {
        private static List<ChampionQuote> _championQuotes = new List<ChampionQuote>();

        private static void Main(string[] args)
        {

            var rammus = new ChampionQuote("Rammus");
            rammus.AddStartQuote("OK.");
            rammus.AddDeathQuote("Sorry, Ok");
            rammus.AddDeathQuote("Lagging so bad!");
            rammus.AddDeathQuote("My mom is downloading lesbian pron off utorrent, sorry team");
            rammus.AddDeathQuote("Rito plis fix serverino");
            rammus.AddDeathQuote("Omfg, I'm so sorry guys having a really bad game :<");
            rammus.AddDeathQuote("Ugh I'm so bad *Sob*");
            rammus.AddReconnectQuote("I'm back guys, internet is freaking out");
            rammus.AddReconnectQuote("My shit if like literally on fire, sorry guys lol");
            rammus.AddReconnectQuote("Mom turned off my router");
            _championQuotes.Add(rammus);

            var alistar = new ChampionQuote("Alistar");
            alistar.AddStartQuote("No! You can't milk those :D, Ok you can try <3");
            alistar.AddStartQuote("I bet you I could milk those *Wink*");
            alistar.AddReconnectQuote("I'm back guys, internet is freaking out");
            alistar.AddReconnectQuote("Mom turned off my router");
            alistar.AddReconnectQuote("My shit if like literally on fire, sorry guys lol");
            alistar.AddDeathQuote("Ugh I'm so bad *Sob*");
            alistar.AddDeathQuote("Omfg, I'm so sorry guys having a really bad game :<");
            alistar.AddDeathQuote("Rito plis fix serverino");
            alistar.AddDeathQuote("My mom is downloading lesbian pron off utorrent, sorry team");
            alistar.AddDeathQuote("Lagging so bad!");
            _championQuotes.Add(alistar);

            var annie = new ChampionQuote("Annie");
            annie.AddStartQuote("Have you seen my bear tibbers?");
            annie.AddReconnectQuote("I'm back guys, internet is freaking out");
            annie.AddReconnectQuote("Mom turned off my router");
            annie.AddReconnectQuote("My shit if like literally on fire, sorry guys lol");
            annie.AddDeathQuote("Ugh I'm so bad *Sob*");
            annie.AddDeathQuote("Omfg, I'm so sorry guys having a really bad game :<");
            annie.AddDeathQuote("Rito plis fix serverino");
            annie.AddDeathQuote("My mom is downloading lesbian pron off utorrent, sorry team");
            annie.AddDeathQuote("Lagging so bad!");
            _championQuotes.Add(annie);

            var blitzcrank = new ChampionQuote("Blitzcrank");
            blitzcrank.AddStartQuote("Bring me dat Ashe!");
            blitzcrank.AddReconnectQuote("I'm back guys, internet is freaking out");
            blitzcrank.AddReconnectQuote("Mom turned off my router");
            blitzcrank.AddDeathQuote("Ugh I'm so bad *Sob*");
            blitzcrank.AddReconnectQuote("My shit if like literally on fire, sorry guys lol");
            blitzcrank.AddDeathQuote("Omfg, I'm so sorry guys having a really bad game :<");
            blitzcrank.AddDeathQuote("Rito plis fix serverino");
            blitzcrank.AddDeathQuote("My mom is downloading lesbian pron off utorrent, sorry team");
            blitzcrank.AddDeathQuote("Lagging so bad!");
         



            // OTHER STUFF
            CustomEvents.Game.OnGameLoad += Game_OnGameLoad;
              
        }

        private static void Game_OnGameLoad(EventArgs args)
        {
            Game.PrintChat("<font color=\"#1eff00\">Champion Personalities by JinxLover & WorstPing Loaded</font> - <font color=\"#00BFFF\">Loaded</font>");
            var championName = ObjectManager.Player.BaseSkinName;
            if (Game.ClockTime < 50)
            {
                var cq = _championQuotes.Where(c => c.GetChampionName() == championName).First();
                if (cq != null)
                {
                    Utility.DelayAction.Add(5000, () => Game.Say("/all " + cq.GetRandomStartQuote()));
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

        internal void AddendQuote(string p)
        {
            throw new NotImplementedException();
        }
    }
}
