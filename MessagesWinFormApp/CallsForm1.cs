using Mobile;
using Mobile.MobilePhone;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessagesWinFormApp
{
    public partial class frmCalls : Form
    {
        public delegate List<Call> CallReceivedDelegate();
        public event CallReceivedDelegate CallReceived;
        public frmCalls()
        {
            InitializeComponent();
            FormatListView();
            GroupHistoryByUser();
        }
        private void GroupHistoryByUser()
        {
            List<Call> listCalls = GenerateCalls();
            List<Call> hannaIncom = new List<Call>();
            List<Call> hannaOutg = new List<Call>();
            List<Call> dmytroIncom = new List<Call>();
            List<Call> dmytroOutg = new List<Call>();
            List<Call> helenIncom = new List<Call>();
            List<Call> helenOutg = new List<Call>();
            for (int i = 0; i < listCalls.Count; i++)
            {
                List<SimCorpMobile> mobilesList = new List<SimCorpMobile>();
                if (listCalls[i].Equals(new Call(new Contact(Users.Hanna, mobilesList), Direction.Incoming)))
                {
                    hannaIncom.Add(listCalls[i]);
                }
                else if (listCalls[i].Equals(new Call(new Contact(Users.Hanna, mobilesList), Direction.Outgoing)))
                {
                    hannaOutg.Add(listCalls[i]);
                }
                else if (listCalls[i].Equals(new Call(new Contact(Users.Dmytro, mobilesList), Direction.Incoming)))
                {
                    dmytroIncom.Add(listCalls[i]);
                }
                else if (listCalls[i].Equals(new Call(new Contact(Users.Dmytro, mobilesList), Direction.Outgoing)))
                {
                    dmytroOutg.Add(listCalls[i]);
                }
                else if (listCalls[i].Equals(new Call(new Contact(Users.Helen, mobilesList), Direction.Incoming)))
                {
                    helenIncom.Add(listCalls[i]);
                }
                else if (listCalls[i].Equals(new Call(new Contact(Users.Helen, mobilesList), Direction.Outgoing)))
                {
                    helenOutg.Add(listCalls[i]);
                }
            }
            hannaIncom[0].GroupCall = "User: " + hannaIncom[0].Contact.User.ToString() +
            " Direction: " + hannaIncom[0].CallDirection.ToString();
            var hannaIncomSorted = from u in hannaIncom 
                                   orderby u.CallTime descending 
                                   select u;
            var hannaIncParent = new TreeNode(hannaIncom[0].GroupCall.ToString());
            trV.Nodes.Add(hannaIncParent);
            foreach (var item in hannaIncomSorted)
            {
                hannaIncParent.Nodes.
                Add("User: " + item.Contact.User.ToString() +
                " Call time: " + item.CallTime.ToString() + " \n" +
                " Direction: " + item.CallDirection.ToString());
            }
            var hannaOutgSorted = from u in hannaOutg
                                  orderby u.CallTime descending
                                  select u;
            hannaOutg[0].GroupCall = "User: " + hannaOutg[0].Contact.User.ToString() +
            " Direction: " + hannaOutg[0].CallDirection.ToString();
            var hannaOutgParent = new TreeNode(hannaOutg[0].GroupCall.ToString());
            trV.Nodes.Add(hannaOutgParent);
            foreach (var item in hannaOutgSorted)
            {
                hannaOutgParent.Nodes.
                Add("User: " + item.Contact.User.ToString() +
                " Call time: " + item.CallTime.ToString() + " \n" +
                " Direction: " + item.CallDirection.ToString());
            }
            var helenIncomSorted = from u in helenIncom
                                   orderby u.CallTime descending
                                   select u;
            helenIncom[0].GroupCall = "User: " + helenIncom[0].Contact.User.ToString() +
            " Direction: " + helenIncom[0].CallDirection.ToString();
            var helenIncomParent = new TreeNode(helenIncom[0].GroupCall.ToString());
            trV.Nodes.Add(helenIncomParent);
            foreach (var item in helenIncomSorted)
            {
                helenIncomParent.Nodes.
                Add("User: " + item.Contact.User.ToString() +
                " Call time: " + item.CallTime.ToString() + " \n" +
                " Direction: " + item.CallDirection.ToString());
            }
            var helenOutgSorted = from u in helenOutg
                                  orderby u.CallTime descending
                                  select u;
            helenOutg[0].GroupCall = "User: " + helenOutg[0].Contact.User.ToString() +
            " Direction: " + helenOutg[0].CallDirection.ToString();
            helenOutg.Sort();
            var helenOutgParent = new TreeNode(helenOutg[0].GroupCall.ToString());
            trV.Nodes.Add(helenOutgParent);
            foreach (var item in helenOutgSorted)
            {
                helenOutgParent.Nodes.
                Add("User: " + item.Contact.User.ToString() +
                " Call time: " + item.CallTime.ToString() + " \n" +
                " Direction: " + item.CallDirection.ToString());
            }
            var dmytroIncomSorted = from u in dmytroIncom
                                    orderby u.CallTime descending
                                    select u;
            dmytroIncom[0].GroupCall = "User: " + dmytroIncom[0].Contact.User.ToString() +
            " Direction: " + dmytroIncom[0].CallDirection.ToString();
            dmytroIncom.Sort();
            var dmytroIncomParent = new TreeNode(dmytroIncom[0].GroupCall.ToString());
            trV.Nodes.Add(dmytroIncomParent);
            foreach (var item in dmytroIncomSorted)
            {
                dmytroIncomParent.Nodes.
                Add("User: " + item.Contact.User.ToString() +
                " Call time: " + item.CallTime.ToString() + " \n" +
                " Direction: " + item.CallDirection.ToString());
            }
            var dmytroOutgSorted = from u in dmytroOutg
                                    orderby u.CallTime descending
                                    select u;
            dmytroOutg[0].GroupCall = "User: " + dmytroOutg[0].Contact.User.ToString() +
            " Direction: " + dmytroOutg[0].CallDirection.ToString();
            var dmytroOutgParent = new TreeNode(dmytroOutg[0].GroupCall.ToString());
            trV.Nodes.Add(dmytroOutgParent);
            foreach (var item in dmytroOutgSorted)
            {
                dmytroOutgParent.Nodes.
                Add("User: " + item.Contact.User.ToString() +
                " Call time: " + item.CallTime.ToString() + " \n" +
                " Direction: " + item.CallDirection.ToString());
            }
        }
        private async void FormatListView()
        {
            lstViewCalls.Columns.Add("Contact", 100);
            lstViewCalls.Columns.Add("Call Time", 230);
            lstViewCalls.Columns.Add("Direction", 200);
            lstViewCalls.View = View.Details;
            CallReceived += () => OnCallReceived();
            Task t1 = await GenerateCallTask();
            t1.Start();
        }
        public List<Call> OnCallReceived()
        {
            List<Call> listCalls = GenerateCalls();
            if (InvokeRequired)
            {
                Invoke(new CallReceivedDelegate(OnCallReceived));
                return listCalls;
            }
           
            listCalls.Sort();
            var sortedDescendingList = from u in listCalls
                                   orderby u.CallTime descending
                                   select u;
            ShowMessages(sortedDescendingList);
            return sortedDescendingList.ToList();
        }
        private async Task<Task> GenerateCallTask()
        {
            Task t1 = new Task(() =>
            {
                    DoWorkAsync();
            });
            return t1;
        }
        public async Task DoWorkAsync()
        {

            System.Threading.Thread.Sleep(200);
            RaiseCallReceivedEvent();
        }
        public bool RaiseCallReceivedEvent()
        {
            var handler = CallReceived;
            if (handler != null)
            {
                handler();
                return true;
            }
            else
            {
                return false;
            }
        }
        private static List<Call> GenerateCalls()
        {
            List<Call> listCalls = new List<Call>();
            SimCorpMobile mobilePhone = new SimCorpMobile();
            List<SimCorpMobile> mobilesList = new List<SimCorpMobile>();
            listCalls.Add(new Call(new Contact(Users.Hanna, mobilesList), new DateTime(2010, 1, 1, 4, 0, 15), Direction.Incoming));
            listCalls.Add(new Call(new Contact(Users.Hanna, mobilesList), new DateTime(2011, 1, 1, 4, 0, 15), Direction.Incoming));
            listCalls.Add(new Call(new Contact(Users.Hanna, mobilesList), new DateTime(2012, 1, 1, 4, 0, 15), Direction.Outgoing));
            listCalls.Add(new Call(new Contact(Users.Hanna, mobilesList), new DateTime(2001, 1, 1, 4, 0, 15), Direction.Outgoing));
            listCalls.Add(new Call(new Contact(Users.Dmytro, mobilesList), new DateTime(2015, 1, 1, 4, 0, 15), Direction.Outgoing));
            listCalls.Add(new Call(new Contact(Users.Dmytro, mobilesList), new DateTime(2009, 1, 1, 4, 0, 15), Direction.Outgoing));
            listCalls.Add(new Call(new Contact(Users.Helen, mobilesList), new DateTime(2016, 1, 1, 4, 0, 15), Direction.Outgoing));
            listCalls.Add(new Call(new Contact(Users.Helen, mobilesList), new DateTime(2017, 1, 1, 4, 0, 15), Direction.Incoming));
            listCalls.Add(new Call(new Contact(Users.Helen, mobilesList), new DateTime(2005, 1, 1, 4, 0, 15), Direction.Incoming));
            listCalls.Add(new Call(new Contact(Users.Dmytro, mobilesList), new DateTime(2008, 1, 1, 4, 0, 15), Direction.Incoming));
            return listCalls;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void ShowMessages(IEnumerable<Call> calls)
        {
            lstViewCalls.Items.Clear();
            foreach(Call call in calls)
            {
                Task.Delay(50000);
                lstViewCalls.Items.Add(new ListViewItem(new[] { call.Contact.User.ToString(), call.CallTime.ToString(), call.CallDirection.ToString() }));
                 Controls.Add(lstViewCalls);
            }
        }

        private void trV_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
