using System;
using BiblioLib.work;
using OuvragesDAL;

namespace BiblioLib
{
    public class OuvragesOpsEventsHandelers
    {
        public void ouvrageLibreEvent(int ouvrageId)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("ouvrageLibreEvent("+ouvrageId+")");
            Console.BackgroundColor = ConsoleColor.Black;
            
            var subscriber = new OuvrageDAO().getFirstOuvrageSubscriber(ouvrageId);
            if (subscriber!=null)
            {
                new SysOperImpl().sendNotif(subscriber, ouvrageId);
            }
        }
    }
}