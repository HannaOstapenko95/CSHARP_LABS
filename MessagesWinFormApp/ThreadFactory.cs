using Mobile;
using System.Threading;
using System.Threading.Tasks;
using Mobile;
using Mobile.MobilePhone;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using static MessagesWinFormApp.ThreadFactory;
using static SMSProvider;
using Message = Mobile.MobilePhone.Message;
namespace MessagesWinFormApp
    
{
    public class ThreadFactory : ChargeFactory
    {
        public override  async Task ChargeAsync(CancellationToken token2)
        {
            Battery battery = new Battery();
            UpdProgressBar += (i) => OnUpdateProgressBar(i);
            battery.Charge = 1;
            for (int i = 0; i <= 100; i++)
            {
                if (token2.IsCancellationRequested) { }
                await Task.Delay(20);
                DoUpdateProgressBar(i);
                battery.Charge += 1;
            }
        }

        public override void ChargeTask()
        {
            throw new NotImplementedException();
        }

        public int DoUpdateProgressBar(int i)
        {
            RaiseUpdateProgressBar(i);
            return i;
        }
    }
}