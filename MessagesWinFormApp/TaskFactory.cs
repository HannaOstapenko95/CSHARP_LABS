using System;
using System.Threading;
using System.Threading.Tasks;

namespace MessagesWinFormApp
{
    internal class TaskFactory : ChargeFactory
    {
        public override Task ChargeAsync(CancellationToken token2)
        {
            throw new System.NotImplementedException();
        }
        public delegate void SetChargeDelegate();
        public override async void ChargeTask()
        {
            for (int i = 0; i <= 100; i++)
            {
                await Task.Delay(40);
                if (!InvokeRequired)
                {
                    if (i == 100)
                    {
                        return;
                    }
                    else
                    {
                        prbCharge.Step = 1;
                        lblProgress.Text = "";
                        // lblProgress.Text = $"{i} %";
                        prbCharge.PerformStep();
                    }
                }
                else
                {
                    try
                    {
                        Invoke(new SetChargeDelegate(ChargeTask));
                        if (i == 100)
                        {
                            return;
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }
    }
}