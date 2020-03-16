using Mobile;
using Mobile.Case;
using Mobile.Charger;
using Mobile.CommonObjects.Screen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileWinFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void IphoneHeadset_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void btnApply_Click(object sender, EventArgs e)
        {
            SimCorpMobile mobilePhone = new SimCorpMobile();
            StringBuilder textboxBuilder = new StringBuilder();
            OutPut tex = new OutPut();
           mobilePhone.ioutput = tex;
            if (rdbIphoneHeadset.Checked)
            {
                mobilePhone.iplayb = new iPhoneHeadset(tex);
                mobilePhone.WriteOn("IPhoneHeadset playback selected\nSet playback to Mobile...\nPlay sound in mobile:", 
                    richTextBox1,  textboxBuilder);
                mobilePhone.Play(tex, textboxBuilder, richTextBox1);
            }
            else if (rdbSamsungHeadset.Checked)
            {
                mobilePhone.iplayb = new SamsungHeadset(tex);
                mobilePhone.WriteOn("SamsungHeadset playback selected\nSet playback to Mobile...\nPlay sound in mobile:", 
                    richTextBox1,  textboxBuilder);
                mobilePhone.Play(tex, textboxBuilder, richTextBox1);
            }
            else if (rdbPhoneSpeaker.Checked)
            {
                mobilePhone.iplayb = new PhoneSpeaker(tex);
                mobilePhone.WriteOn("PhoneSpeaker playback selected\nSet playback to Mobile...\nPlay sound in mobile:", 
                    richTextBox1,  textboxBuilder);
                mobilePhone.Play(tex, textboxBuilder, richTextBox1);
            }
            else if (rdbUnofficialPhoneHeadset.Checked)
            {
                mobilePhone.iplayb = new UnofficialPhoneHeadset(tex);
                mobilePhone.WriteOn("UnofficialPhoneHeadset playback selected\nSet playback to Mobile...\nPlay sound in mobile:", 
                    richTextBox1,  textboxBuilder);
                mobilePhone.Play(tex, textboxBuilder, richTextBox1);
            }


            if (rdbPowerBank.Checked)
            {
                mobilePhone.icharger = new PowerBank(tex);
                mobilePhone.WriteOn("\nPowerBank charger selected\nSet charger to Mobile...\nCharge your mobile:", richTextBox1,  textboxBuilder);
                mobilePhone.Charge(mobilePhone, textboxBuilder, richTextBox1);
            }
            else if (rdbCharger.Checked)
            {
                mobilePhone.icharger = new Charger(tex);
                mobilePhone.WriteOn("\nTypical Charger selected for charging\nSet charger to Mobile...\nCharge your mobile:", 
                    richTextBox1,  textboxBuilder);
                mobilePhone.Charge(mobilePhone, textboxBuilder, richTextBox1);
            }

            if (rdbBookCase.Checked)
            {
                mobilePhone.icase = new BookCase(tex);
                mobilePhone.WriteOn("\nBookCase selected", richTextBox1, textboxBuilder);
                mobilePhone.SelectCase(mobilePhone, textboxBuilder, richTextBox1);
            }
            else if (rdbToughCase.Checked)
            {
                mobilePhone.icase = new ToughCase(tex);
                mobilePhone.WriteOn("\nToughCase selected", richTextBox1, textboxBuilder);
                mobilePhone.SelectCase(mobilePhone, textboxBuilder, richTextBox1);
            }
            else if (rdbSlimCase.Checked)
            {
                mobilePhone.icase = new SlimCase(tex);
                mobilePhone.WriteOn("\nSlimCase selected", richTextBox1, textboxBuilder);
                mobilePhone.SelectCase(mobilePhone, textboxBuilder, richTextBox1);
            }
            else if (rdbFolioCase.Checked)
            {
                mobilePhone.icase = new FolioCase(tex);
                mobilePhone.WriteOn("\nFolioCase selected", richTextBox1, textboxBuilder);
                mobilePhone.SelectCase(mobilePhone, textboxBuilder, richTextBox1);
            }
            else if (rdbWalletCase.Checked)
            {
                mobilePhone.icase = new WalletCase(tex);
                mobilePhone.WriteOn("\nWalletCase selected", richTextBox1, textboxBuilder);
                mobilePhone.SelectCase(mobilePhone, textboxBuilder, richTextBox1);
            }


            if (rdbMultiTouch.Checked)
            {
                mobilePhone.iscreentouch = new MultiTouch(tex);
                mobilePhone.WriteOn("\nMultiTouch screen selected", richTextBox1, textboxBuilder);
                mobilePhone.SelectScreenTouch(mobilePhone, textboxBuilder, richTextBox1);
            }
            else if (rdbSingleTouch.Checked)
            {
                mobilePhone.iscreentouch = new SingleTouch(tex);
                mobilePhone.WriteOn("\nSingleTouch screen selected",
                    richTextBox1, textboxBuilder);
                mobilePhone.SelectScreenTouch(mobilePhone, textboxBuilder, richTextBox1);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
