using System.Threading;
using System.Threading.Tasks;

namespace MessagesWinFormApp
{
    public abstract class ChargeFactory : frmMessageFormatting
    {
        public abstract Task ChargeAsync(CancellationToken token2);
        public abstract void ChargeTask();
    } 
}