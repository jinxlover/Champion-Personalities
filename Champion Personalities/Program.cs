using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;
using LeagueSharp.Common;
using SharpDX;

namespace Champion_Personalities
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += Game_OnGameLoad;
        }

        static void Game_OnGameLoad(EventArgs args)
        {
            string say = "";
            if (Game.ClockTime < 15)
            {

                switch (ObjectManager.Player.ChampionName)
                {
                    case "Rammus":
                        say = "Ok.";
                        break;

                    case "Leblanc":
                        say = "I'm over here, Now I'm over here, Can't hit what you can't see!";
                        break;

                    case "Garen":
                        say = "For Demacia! and for the Crowngaurds!";
                        break;
                    case "Annie":
                        say = "Tibbers? Tibbers? Has anyone seen my bear Tibbers?";
                        break;
                    case "Aatrox":
                        say = "My blade will taste war on this day.";
                        break;
                    case "Ahri":
                        say = "Nine-Tailed fox? What is this! Naruto!?";
                        break;
                    case "Akali":
                        say = "Too many noobs on the dancefloor ^So many noobs^";
                        break;
                    case "Alistar":
                        say = "You can't milk those! Well, Maybe if you ask nicely";
                        break;
                    case "Amumu":
                        say = "Sometimes when noone's looking I smile. Tell noone of this.";
                        break;
                    case "Anivia":
                        say = "No, My name is not Elsa!";
                        break;
                    case "Ashe":
                        say = "No, I will not bring you 'Dat Ashe'";
                        break;
                    case "Azir":
                        say = "Oppa Pidgeon Style!";
                        break;
                    case "Blitzcrank":
                        say = "3 Laws of robotics be damned, Bring me dat ASS!";
                        break;
                    case "Brand":
                        say = "It's getting hot in here, So take off all your clothes!";
                        break;
                    case "Braum":
                        say = "You say a shield isn't a weapon? Come a little closer and say that.";
                        break;
                    case "Caitlyn":
                        say = "You wanna see a Hat trick? *Pulls a rabbit out of her hat* Hah! Bet you didn't expect that";
                        break;
                    case "Cassiopeia":
                        say = "FunFact: My sister is Katarina! #Jelly";
                        break;
                    case "Cho'Gath":
                        say = "OMNOMNOMNOMNOMNOMNOMNOMNOM, Mmmm Quite good sir.";
                        break;
                    case "Corki":
                        say = "Press {R} or {Z} twice to do a barrel roll!";
                        break;
                    case "Darius": //Honestly Couldn't think of something here lel
                        say = "Has anyone seen my brother Draven? He stole one of my axes!";
                        break;
                    case "Diana":
                        say = "Embrace the Moon!";
                        break;
                    case "Dr. Mundo":
                        say = "Mundo Mundo's where he Mundo's";
                        break;
                    case "Draven":
                        say = "Welcome to the League of Draaaaaaaaaaaaaaven";
                        break;
                    case "Elise":
                        say = "Is this my web? Then I don't feel safe here.";
                        break;
                    case "Evelynn":
                        say = "I'm hot to trot, Take a spin boys";
                        break;
                    case "Ezreal":
                        say = "Who needs a ma- Uh guys, I think I'm lost.";
                        break;
                    case "Fiddlesticks":
                        say = "You will FEAR me and DREAD my PRESENCE, heh get it?";
                        break;
                    case "Fiora":
                        say = "I may be a grand duelist but I am also a grand ballerina!";
                        break;
                    case "Fizz":
                        say = "Hey look at me playing fizz, I must be a diamond fizz main guise watch out";
                        break;
                    case "Galio":
                        say = "You know what my friends call my eyes? The Death Star.";
                        break;
                    case "Gangplank":
                        say = "Wanna know how my roger got so jolly? Vigorous masturbation.";
                        break;
                    case "Gragas":
                        say = "I'll drink you under the table Skrub then quickscope ur nan";
                        break;
                    case "Gnar":
                        say = "RAAAAAAAAAAAAAAAAAAAWR";
                        break;
                    case "Graves":
                        say = "Riot took my cigar, so I'm gonna take your life.";
                        break;
                    case "Hecarim":
                        say = "My little pony is my favorite show, So many hot babes.";
                        break;
                    case "Heimerdinger":
                        say = "Heim Heim Heim Heim Heim Heim Nye the Science Guy";
                        break;
                    case "Irelia":
                        say = "When the Defeat screen comes up I promise you you're gonna be screaming NERF IRELIA!";
                        break;





                        }
             } Utility.DelayAction.Add(5000, () => Game.Say( "/All  " +  say ));
        }
    }
}
