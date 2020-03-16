using Mobile;
using Mobile.Case;
using Mobile.Charger;
using Mobile.CommonObjects.Screen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SimCorpMobile mobilePhone = new SimCorpMobile();
            Console.WriteLine(mobilePhone);
            mobilePhone.ioutput = new OutPut();
            StringBuilder consoletextBuilder = new StringBuilder();
            Console.WriteLine("Select playback component:");
            Console.WriteLine("1 - IPhone Headset");
            Console.WriteLine("2 - Samsung Headset");
            Console.WriteLine("3 - Phone Speaker");
            Console.WriteLine("4 - Unofficial Phone Headset");
            string headsetNo = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Select charger for phone:");
            Console.WriteLine("1 - Powerbank");
            Console.WriteLine("2 - Charger");
            string chargerNo = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Select case for mobile:");
            Console.WriteLine("1 - Bookcase");
            Console.WriteLine("2 - ToughCase");
            Console.WriteLine("3 - SlimCase");
            Console.WriteLine("4 - FolioCase");
            Console.WriteLine("5 - WalletCase");
            string caseNo = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Select Screen Touch type of mobile:");
            Console.WriteLine("1 - Multi-touch");
            Console.WriteLine("2 - Single-touch");
            string screenTouchNo = Convert.ToString(Console.ReadLine());

            switch (headsetNo)
            {
                case "1":
                    mobilePhone.iplayb = new iPhoneHeadset(new OutPut());
                    mobilePhone.WriteOn("IPhoneHeadset playback selected" +
                        "\nSet playback to mobile... " +
                        "\nPlay sound in mobile:\n");
                    mobilePhone.Play(mobilePhone);
                    break;
                case "2":
                    mobilePhone.iplayb = new SamsungHeadset(new OutPut());
                    mobilePhone.WriteOn("SamsungHeadset playback selected" +
                        "\nSet playback to mobile... " +
                        "\nPlay sound in mobile:\n");
                    mobilePhone.Play(mobilePhone);
                    break;
                case "3":
                    mobilePhone.iplayb = new PhoneSpeaker(new OutPut());
                    mobilePhone.WriteOn("PhoneSpeaker playback selected" +
                        "\nSet playback to mobile... " +
                        "\nPlay sound in mobile:\n");
                    mobilePhone.Play(mobilePhone);
                    break;
                case "4":
                    mobilePhone.iplayb = new UnofficialPhoneHeadset(new OutPut());
                    mobilePhone.WriteOn("UnofficialPhoneHeadset playback selected" +
                        "\nSet playback to mobile... " +
                        "\nPlay sound in mobile:\n");
                    mobilePhone.Play(mobilePhone);
                    break;
            }
            Console.WriteLine("\n");
            switch (chargerNo)
            {
                case "1":
                    mobilePhone.icharger = new PowerBank(new OutPut());
                    mobilePhone.WriteOn("PowerBank selected for charging:\n");
                    mobilePhone.Charge();
                    break;
                case "2":
                    mobilePhone.icharger = new Charger(new OutPut());
                    mobilePhone.WriteOn("\nTypical Charger selected for charging\nSet charger to Mobile...\nCharge your mobile:\n");
                    mobilePhone.Charge();
                    break;
            }
            Console.WriteLine("\n");
            switch (caseNo)
            {
                case "1":
                    mobilePhone.icase = new BookCase(new OutPut());
                    mobilePhone.WriteOn("Bookcase selected for mobile:\n");
                    mobilePhone.SelectCase();
                    break;
                case "2":
                    mobilePhone.icase = new ToughCase(new OutPut());
                    mobilePhone.WriteOn("ToughCase selected for mobile:\n");
                    mobilePhone.SelectCase();
                    break;
                case "3":
                    mobilePhone.icase = new SlimCase(new OutPut());
                    mobilePhone.WriteOn("SlimCase selected for mobile:\n");
                    mobilePhone.SelectCase();
                    break;
                case "4":
                    mobilePhone.icase = new FolioCase(new OutPut());
                    mobilePhone.WriteOn("FolioCase selected for mobile:\n");
                    mobilePhone.SelectCase();
                    break;
                case "5":
                    mobilePhone.icase = new WalletCase(new OutPut());
                    mobilePhone.WriteOn("WalletCase selected for mobile:\n");
                    mobilePhone.SelectCase();
                    break;
            }
            Console.WriteLine("\n");
            switch (screenTouchNo)
            {
                case "1":
                    mobilePhone.iscreentouch = new MultiTouch(new OutPut());
                    mobilePhone.WriteOn("MultiTouch selected for charging:\n");
                    mobilePhone.SelectScreenTouch();
                    break;
                case "2":
                    mobilePhone.iscreentouch = new SingleTouch(new OutPut());
                    mobilePhone.WriteOn("SingleTouch selected for charging:\n");
                    mobilePhone.SelectScreenTouch();
                    break;
            }
            Console.ReadKey();
        }
    }
}
