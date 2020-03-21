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
//using static Mobile.MobilePhone.SMSProvider;
using static SMSProvider;

namespace MessagesWinFormApp
{
    
    public partial class Form1 : Form
    {
        public readonly FormatDelegate Formatter = new FormatDelegate(FormatWithTime);
        public readonly FormatDelegate Formatter_EndWithTime = new FormatDelegate(EndWithTime);
        public readonly FormatDelegate Formatter_Up = new FormatDelegate(UpperCase);
        public readonly FormatDelegate Formatter_Lower = new FormatDelegate(LowerCase);

        public Form1()
        {
            InitializeComponent();
        }
        private void rtbMessages_TextChanged(object sender, EventArgs e)
        {
            
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
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void rtbMessages_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectionChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                rtbMessages.Clear();
                SMSProvider sms = new SMSProvider();
                sms.SMSReceived += (message) => OnSMSReceived(message);
                sms.DoWork("Message received");
            }
            if (comboBox1.SelectedIndex == 1)
            {
                rtbMessages.Clear();
                SMSProvider sms = new SMSProvider();
                sms.SMSReceived += (message) => OnUpperCase(message);
                sms.DoWork("Message received");
            }
            if (comboBox1.SelectedIndex == 2)
            {
                rtbMessages.Clear();
                SMSProvider sms = new SMSProvider();
                sms.SMSReceived += (message) => OnLowerCase(message);
                sms.DoWork("Message received");
            }
            if (comboBox1.SelectedIndex == 3)
            {
                rtbMessages.Clear();
                SMSProvider sms = new SMSProvider();
                sms.SMSReceived += (message) => OnSMSDateEnd(message);
                sms.DoWork("Message received");   
            }  
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
