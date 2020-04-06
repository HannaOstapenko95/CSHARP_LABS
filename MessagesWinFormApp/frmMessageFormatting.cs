using Mobile.MobilePhone;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private void rtbMessages_TextChanged_1(object sender, EventArgs e)
        {
            rtbMessages.Update();
        }
        private void ShowMessages(IEnumerable<Message> messages)
        {
            lstView.Items.Clear();
            foreach (Message message in messages)
            {
                lstView.Items.Add(new ListViewItem(new[] { message.User.ToString(), message.Text, message.ReceivingTime.ToString()}));
                Controls.Add(lstView);
            }
        }
        private void cmbSelectFormat_SelectionChanged(object sender, EventArgs e)
        {
            if (cmbSelectFormat.SelectedIndex == 0)
            {
                rtbMessages.Clear();
                SMSProvider sms = new SMSProvider();
                sms.SMSReceived += (message) => OnSMSReceived(message);
                sms.DoWork("Message received");
            }
            if (cmbSelectFormat.SelectedIndex == 1)
            {
                rtbMessages.Clear();
                SMSProvider sms = new SMSProvider();
                sms.SMSReceived += (message) => OnUpperCase(message);
                sms.DoWork("Message received");
            }
            if (cmbSelectFormat.SelectedIndex == 2)
            {
                rtbMessages.Clear();
                SMSProvider sms = new SMSProvider();
                sms.SMSReceived += (message) => OnLowerCase(message);
                sms.DoWork("Message received");
            }
            if (cmbSelectFormat.SelectedIndex == 3)
            {
                rtbMessages.Clear();
                SMSProvider sms = new SMSProvider();
                sms.SMSReceived += (message) => OnSMSDateEnd(message);
                sms.DoWork("Message received");   
            }  
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
            stor.SMSAdded += (messages, user, message, dateTime) => OnSMSAdded(messages, user,message,  dateTime);
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
    }

}
