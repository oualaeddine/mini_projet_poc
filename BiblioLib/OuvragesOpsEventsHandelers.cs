using BiblioLib.work;
using OuvragesDAL;

namespace BiblioLib
{
    public class OuvragesOpsEventsHandelers
    {
        public void ouvrageLibreEvent(int ouvrageId)
        {
            var subscriber = new OuvrageDAO().getFirstOuvrageSubscriber(ouvrageId);
            new SysOperImpl().sendNotif(subscriber, ouvrageId);
        }
    }
}