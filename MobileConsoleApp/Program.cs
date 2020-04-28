using Mobile;
using Mobile.Case;
using Mobile.Charger;
using Mobile.CommonObjects.Screen;
using Mobile.MobilePhone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static Mobile.MobilePhone.SMSProvider;

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
            PLAYBACK:  string headsetNo = Convert.ToString(Console.ReadLine());
            if (headsetNo != "4" && headsetNo != "1" && headsetNo != "2" && headsetNo != "3")
            {
                Console.WriteLine("Please, enter a valid number!");
                goto PLAYBACK;
            }
            Console.WriteLine("Select charger for phone:");
            Console.WriteLine("1 - Powerbank");
            Console.WriteLine("2 - Charger");
            CHARGENO:  string chargerNo = Convert.ToString(Console.ReadLine());
            if (chargerNo != "1" && chargerNo != "2")
            {
                Console.WriteLine("Please, enter a valid number!");
                goto CHARGENO;
            }
            Console.WriteLine("Select case for mobile:");
            Console.WriteLine("1 - Bookcase");
            Console.WriteLine("2 - ToughCase");
            Console.WriteLine("3 - SlimCase");
            Console.WriteLine("4 - FolioCase");
            Console.WriteLine("5 - WalletCase");
            CASENO: string caseNo = Convert.ToString(Console.ReadLine());
            if (caseNo != "1" && caseNo != "2" && caseNo != "3" && caseNo != "4" && caseNo != "5")
            {
                Console.WriteLine("Please, enter a valid number!");
                goto CASENO;
            }
            Console.WriteLine("Select Screen Touch type of mobile:");
            Console.WriteLine("1 - Multi-touch");
            Console.WriteLine("2 - Single-touch");
            SCREENNO: string screenTouchNo = Convert.ToString(Console.ReadLine());
            if (screenTouchNo != "1" && screenTouchNo != "2")
            {
                Console.WriteLine("Please, enter a valid number!");
                goto SCREENNO;
            }

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
                default:
                    Console.WriteLine("Please, enter number from 1 to 4");
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
                default:
                    Console.WriteLine("Please, enter number from 1 to 2");
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
                default:
                    Console.WriteLine("Please, enter number from 1 to 5");
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
                default:
                    Console.WriteLine("Please, enter number from 1 to 2");
                    break;
            }
            Console.ReadKey();
        }
    }
}
