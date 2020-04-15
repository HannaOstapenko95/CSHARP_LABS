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
   
    public partial class frmMessageFormatting : Form
    {
        public readonly FormatDelegate Formatter = new FormatDelegate(FormatWithTime);
        public readonly FormatDelegate Formatter_EndWithTime = new FormatDelegate(EndWithTime);
        public readonly FormatDelegate Formatter_Up = new FormatDelegate(UpperCase);
        public readonly FormatDelegate Formatter_Lower = new FormatDelegate(LowerCase);
  
        public frmMessageFormatting()
        {
            InitializeComponent();
            InitializeComboBoxWithUsers();
            FormatListView();
            ShowMessages(Storage.GenerateMessagesList());

        }
        
        private void FormatListView()
        {
            lstView.Columns.Add("User", 100);
            lstView.Columns.Add("Message", 230);
            lstView.Columns.Add("Time", 200);
            lstView.View = View.Details;
            btnSearch.Enabled = false;
        }
        private void InitializeComboBoxWithUsers()
        {
            foreach (var user in Enum.GetValues(typeof(Users)))
            {
                cmbUser.Items.Add(user);
            }
        }
        //public string OnSMSReceived(string message)
        //{
        //    if (InvokeRequired)
        //    {
        //        Invoke(new SMSProvider.SMSReceivedDelegate(OnSMSReceived), message);
        //        return message;
        //    }
        //    string formattedMessage = Formatter($"{message}{Environment.NewLine}");
        //    rtbMessages.AppendText(formattedMessage);
        //    return formattedMessage;
        //}

        public string OnSMSDateEnd(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new SMSProvider.SMSReceivedDelegate(OnSMSDateEnd), message);
                return message;
            }
            string formattedMessage = Formatter_EndWithTime($"{message}");
            rtbMessages.AppendText(formattedMessage);
            return formattedMessage;
        }
        public string OnUpperCase(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new SMSProvider.SMSReceivedDelegate(OnUpperCase), message);
                return message;
            }
            string formattedMessage = Formatter_Up($"{message}");
            rtbMessages.AppendText(formattedMessage);
            return formattedMessage;
        }
        public string OnLowerCase(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new SMSProvider.SMSReceivedDelegate(OnLowerCase), message);
                return message;
            }
            string formattedMessage = Formatter_Lower($"{message}");

            rtbMessages.AppendText(formattedMessage);
            return formattedMessage;
        }
        private void ShowMessages(IEnumerable<Message> messages)
        {
            lstView.Items.Clear();
            foreach (Message message in messages)
            {
                lstView.Items.Add(new ListViewItem(new[] { message.User.ToString(), message.Text, message.ReceivingTime.ToString() }));
                Controls.Add(lstView);
            }
        }
        private void rtbMessages_TextChanged_1(object sender, EventArgs e)
        {
            rtbMessages.Update();
        }

        public async Task DoWorkAsync(string i)
        {

            System.Threading.Thread.Sleep(200);
            RaiseSMSReceivedEvent(i);
        }
        //public async Task DoWork(CancellationToken token)
        //{

        //    for (int n = 0; n < 10; n++)
        //    {
        //        token.ThrowIfCancellationRequested();
        //        await Timer("hel");
        //        System.Threading.Thread.Sleep(250);
        //        RaiseSMSReceivedEvent("mes");
        //    }
        //}
       
    
        public string OnSMSReceived(string message)
        {

            if (InvokeRequired)
            {
                Invoke(new SMSProvider.SMSReceivedDelegate(OnSMSReceived), message);
                return message;
            }
            string formattedMessage = Formatter($"{message}{Environment.NewLine}");
            rtbMessages.AppendText(formattedMessage);
            return formattedMessage;
        }


        public event SMSReceivedDelegate SMSReceived;
        public bool RaiseSMSReceivedEvent(string message)
        {
            var handler = SMSReceived;
            if (handler != null)
            {
                handler(message);
                return true;
            }
            else
            {
                return false;
            }
        }
        private void cmbSelectFormat_SelectionChanged(object sender, EventArgs e)
        {
            if (cmbSelectFormat.SelectedIndex == 0)
            {
                //rtbMessages.Clear();
                //SMSProvider sms = new SMSProvider();
                //sms.SMSReceived += (message) => OnSMSReceived(message);
                //Thread myThread = new Thread(new ThreadStart(sms.DoWork));
                //myThread.Start();
                //sms.DoWork("Message received");
            }
            //if (cmbSelectFormat.SelectedIndex == 1)
            //{
            //    rtbMessages.Clear();
            //    SMSProvider sms = new SMSProvider();
            //    sms.SMSReceived += (message) => OnUpperCase(message);
            //    sms.DoWork("Message received");
            //}
            //if (cmbSelectFormat.SelectedIndex == 2)
            //{
            //    rtbMessages.Clear();
            //    SMSProvider sms = new SMSProvider();
            //    sms.SMSReceived += (message) => OnLowerCase(message);
            //    sms.DoWork("Message received");
            //}
            //if (cmbSelectFormat.SelectedIndex == 3)
            //{
            //    rtbMessages.Clear();
            //    SMSProvider sms = new SMSProvider();
            //    sms.SMSReceived += (message) => OnSMSDateEnd(message);
            //    sms.DoWork("Message received");   
            //}  
        }
        public List<Message> OnSMSAdded(List<Message> messages, Users user, string message, DateTime dateTime)
        {
            SMSProvider sms = new SMSProvider();
            if (InvokeRequired)
            {
                Invoke(new Storage.SMSAddedDelegate(OnSMSAdded), user, message, dateTime);
                return null;
            }
            List<Message> messagesUpdated = sms.AddMessage(messages, user, message, dateTime);
            ShowMessages(messagesUpdated);
            return messagesUpdated;
        }
        public List<Message> OnSMSRemoved(List<Message> messages, Users user, string message, DateTime dateTime)
        {
            SMSProvider sms = new SMSProvider();
            if (InvokeRequired)
            {
                Invoke(new Storage.SMSRemovedDelegate(OnSMSRemoved), user, message, dateTime);
                return null;
            }
            List<Message> messagesUpdated = sms.RemoveMessage(messages, user, message, dateTime);
            ShowMessages(messagesUpdated);
            return messagesUpdated;
        }
        public List<Message> SearchByUser(string user)
        {
            List<Message> message = Storage.GenerateMessagesList();
            if (cmbUser.Text != null)
            {
                foreach (var u in Enum.GetValues(typeof(Users)))
                {
                    if (user != "All")
                    {
                        if (user == u.ToString())
                        {
                            var queryShow = message.Where(ee => ee.User.ToString() == u.ToString());
                            ShowMessages(queryShow);
                        }
                    }
                    else
                    {
                        ShowMessages(message);
                    }
                }
            }
            if (user == "All")
            {
                return message;
            }
            else
            {
                var query = message.Where(ee => ee.User.ToString() == user);
                return query.ToList();
            }
        }
        public ICollection<Message> SearchByText(string text)
        {
            List<Message> message = Storage.GenerateMessagesList();
            var query = message.Where(ee => ee.Text.Contains(text));
            ShowMessages(query);
            return query.ToList();
        }

        public List<Message> SearchByDate(DateTime dateFrom, DateTime dateTo)
        {
            List<Message> message = Storage.GenerateMessagesList();
            var query = message.Where(ee => (ee.ReceivingTime.Date <= dateTo) && (ee.ReceivingTime.Date >= dateFrom));
            ShowMessages(query);
            return query.ToList();
        }

        private void rdbAnd_CheckedChanged(object sender, EventArgs e)
        {
            btnSearch.Enabled = true;
        }

        public ICollection<Message> CheckFileringLogic(bool andChecked, bool orChecked, string text, string user, DateTime from, DateTime to)
        {
            List<Message> message = Storage.GenerateMessagesList();
            if (andChecked)
            {
                HashSet<Message> set1 = SearchByText(text).ToHashSet();
                HashSet<Message> set2 = SearchByUser(user).ToHashSet();
                HashSet<Message> set3 = SearchByDate(from, to).ToHashSet();
                var intersecTextUser = set1.Intersect(set2, new MessageComparer());
                var intersecTextUserDate = intersecTextUser.Intersect(set3, new MessageComparer());
                ShowMessages(intersecTextUserDate);
                return intersecTextUserDate.ToList();
            }
            else if (orChecked)
            {
                HashSet<Message> set1 = SearchByText(text).ToHashSet();
                HashSet<Message> set2 = SearchByUser(user).ToHashSet();
                HashSet<Message> set3 = SearchByDate(from, to).ToHashSet();
                var unionTextUser = set1.Union(set2, new MessageComparer());
                var unionTextUserDate = unionTextUser.Union(set3, new MessageComparer());
                ShowMessages(unionTextUserDate);
                return unionTextUserDate.ToList();
            }
            else
            {
                return message;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CheckFileringLogic(rdbAnd.Checked, rdbOr.Checked, txtbSearch.Text, cmbUser.Text, dtpFrom.Value, dtpTo.Value);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Storage stor = new Storage();
            stor.SMSAdded += (messages, user, message, dateTime) => OnSMSAdded(messages, user, message, dateTime);
            stor.AddSMS(Storage.GenerateMessagesList(), Users.Hanna, "Do not smoke!", DateTime.Now);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Storage stor = new Storage();
            stor.SMSRemoved += (messages, user, message, dateTime) => OnSMSRemoved(messages, user, message, dateTime);
            stor.RemoveSMS(Storage.GenerateMessagesList(), Users.Hanna, "Do not smoke!", DateTime.Now);
        }
        private void rdbOr_CheckedChanged(object sender, EventArgs e)
        {
            btnSearch.Enabled = true;
        }

        private void cmbSelectFormat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private async Task<Task> GenerateMessageTask(CancellationToken token)
        {
            Task t1 = new Task(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    if (token.IsCancellationRequested) { return; }
                    DoWorkAsync("Message received");
                }
            });
            return t1;
        }
        int i = 0;
        CancellationTokenSource cancelTokenSource;
        public async void btnStart_Click(object sender, EventArgs e)
        {
            CancellationToken token;
            cancelTokenSource = new CancellationTokenSource();
            if (rtbMessages.Text == "" && i > 0)
            {
                cancelTokenSource = new CancellationTokenSource();
                token = cancelTokenSource.Token;
            }
            else { token = cancelTokenSource.Token; }
            if (cmbSelectFormat.SelectedIndex == 0)
            {
                SMSReceived += (message) => OnSMSReceived(message);
                Task t1 = await GenerateMessageTask(token);
                t1.Start();
            }
            else if (cmbSelectFormat.SelectedIndex == 1)
            {
                SMSReceived += (message) => OnUpperCase(message);
                var t1 = await GenerateMessageTask(token);
                t1.Start();
            }
            else if (cmbSelectFormat.SelectedIndex == 2)
            {
                SMSReceived += (message) => OnLowerCase(message);
                var t1 = await GenerateMessageTask(token);
                t1.Start();
            }
            else if (cmbSelectFormat.SelectedIndex == 3)
            {
                SMSReceived += (message) => OnSMSDateEnd(message);
                var t1 = await GenerateMessageTask(token);
                t1.Start();
            }
            else
            {
                MessageBox.Show("Select Format for Messages!");
            }
        }

        private async void btnStop_Click(object sender, EventArgs e)
        {
            cancelTokenSource.Cancel();
            i = 1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbMessages.Clear();
        }

        
        private async void frmMessageFormatting_Load(object sender, EventArgs e)
        {
            btnStopCharge.Enabled = false;
            btnCharge.Enabled = false;
            await DisCharge();
            btnCharge.Enabled = true;
            btnStopCharge.Enabled = false;
        }
        public int OnUpdateProgressBar(int i)
        {

            if (InvokeRequired)
            {
                Invoke(new UpdateProgressBarDelegate(OnUpdateProgressBar), i);
            }
            prbCharge.PerformStep();
            lblProgress.Text = $"{i} %";
            return i;
        }
    
        public bool RaiseUpdateProgressBar(int i)
        {
            var handler = UpdProgressBar;
            if (handler != null)
            {
                handler(i);
                return true;
            }
            else
            {
                return false;
            }
        }
        public int DoUpdateProgressBar(int i)
        {
            RaiseUpdateProgressBar(i);
            return i;
        }
        public Task DoUpdateProgressBarTask(int i)
        {
            Task t = new Task(() =>
            {
                RaiseUpdateProgressBar(i);
            });

            return t;
        }
        CancellationTokenSource cancelTokenSrc;
        public CancellationToken token2;
        public delegate int UpdateProgressBarDelegate(int i);
        public event UpdateProgressBarDelegate UpdProgressBar;
        public async Task<int> ChargeAsync(CancellationToken token2)
        {
            Battery battery = new Battery();
            battery.Charge = 1;
            for (int i = 0; i <= 100; i++)
            {
                if (token2.IsCancellationRequested) { return battery.Charge; }
                await Task.Delay(40);
                DoUpdateProgressBar(i);
                battery.Charge += 1;
            }
            return battery.Charge;
        }

        private async void btnCharge_Click(object sender, EventArgs e)
        {
            string message = "Do you want to charge battery with Threads? \n\n(press 'No' to use Tasks)";
            string title = "Choose method of charging";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            btnCharge.Enabled = false;
            cancelTokenSrc = new CancellationTokenSource();
            token2 = cancelTokenSrc.Token;
            btnStopCharge.Enabled = true;

            ChargeFactory factory = null;

            if (result == DialogResult.Yes) //Using ASYNC/AWAIT
            {
                prbCharge.Value = 1;
                prbCharge.Step = 1;

                //Variant 1 - does not work
                //**************************
                //If invoke ChargeAsync in separate class (ThreadFactory) - it does not work correctly..
                //factory = new ThreadFactory();
                //UpdProgressBar += (i) => OnUpdateProgressBar(i);
                //factory.ChargeAsync(token2);
                ////Discharge automatically when Charge = 100
                //if (prbCharge.Value == 100)
                //{
                //    btnStopCharge.Enabled = false;
                //    await DisCharge();
                //}
                //**************************

                //Variant 2 - works
                //**************************
                //If copy the content of ThreadFactory in thic class - works correctly.
                UpdProgressBar += (i) => OnUpdateProgressBar(i);
                await ChargeAsync(token2);
                //Discharge automatically when Charge = 100
                if (prbCharge.Value == 100)
                {
                    btnStopCharge.Enabled = false;
                    await DisCharge();
                }
                //**************************
            }
            else  //Using Tasks
            {
                //**************************
                //Variant 1 - works
                //**************************
                btnStopCharge.Enabled = false;
                Task t1 = new Task(ChargeTask);
                t1.Start();
                Task t2 = t1.ContinueWith(DisChargeTask);
                t2.Wait();
                //***************************

                //Variant 2 - does not work
                //**************************
                //If invoke ChargeAsync in separate class (TaskFactory) - it does not work correctly..
                //factory = new TaskFactory();
                //UpdProgressBar += (i) => OnUpdateProgressBar(i);
                //factory.ChargeTask();
                ////Discharge automatically when Charge = 100
                //if (prbCharge.Value == 100)
                //{
                //    btnStopCharge.Enabled = false;
                //    await DisCharge();
                //}
            }
            if (prbCharge.Value == 100)
            {
                btnStopCharge.Enabled = false;
                await DisCharge();
            }
            btnCharge.Enabled = true;
        }

        private async void btnStopCharge_Click(object sender, EventArgs e)
        {
            cancelTokenSrc.Cancel();
            await Task.Delay(2000);
            await DisChargeFrom(40);
            btnStopCharge.Enabled = false;
        }

        delegate void SetChargeDelegate();
        public async void ChargeTask()
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
                        Battery battery = new Battery();
                        prbCharge.Step = 1;
                        lblProgress.Text = "";
                        battery.Charge += 1;
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
        public async Task DisCharge()
        {
            Battery battery = new Battery();
            prbCharge.Step = -1;
            battery.Charge = 100;
            prbCharge.Value = 100;
            for (int i = 100; i > 0; i--)
            {
                prbCharge.PerformStep();
                await Task.Delay(10);
                lblProgress.Text = $"{i} %";
            }
        }
        delegate void SetDisChargeDelegate(Task t);
        public async void DisChargeTask(Task t)
        {
            for (int i = 100; i > 0; i--)
            {
                await Task.Delay(150);
                if (!InvokeRequired)
                {
                    prbCharge.Step = -1;
                    prbCharge.PerformStep();
                    lblProgress.Text = $"{i} %";
                }
                else
                {
                    try
                    {
                        Invoke(new SetDisChargeDelegate(DisChargeTask));
                    }
                    catch (Exception)
                    {
                        return;
                    }
                }
            }
        }
        public async void DisChargeTask()
        {
            for (int i = 100; i > 0; i--)
            {
                await Task.Delay(150);
                if (!InvokeRequired)
                {
                    prbCharge.Step = -1;
                    prbCharge.PerformStep();
                    lblProgress.Text = $"{i} %";
                }
                else
                {
                    try
                    {
                        Invoke(new SetDisChargeDelegate(DisChargeTask));
                    }
                    catch (Exception)
                    {
                        return;
                    }
                }
            }
        }
        private async Task DisChargeFrom(int charge)
        {
            Battery battery = new Battery();
            prbCharge.Step = -1;
            battery.Charge = charge;
            prbCharge.Value = charge;
            for (int i = charge; i > 0; i--)
            {
                prbCharge.PerformStep();
                await Task.Delay(10);
                lblProgress.Text = $"{i} %";
            }
        }
        
    }

   
}
