using Mobile.Case;
using Mobile.CommonObjects;
using Mobile.CommonObjects.Camera;
using Mobile.CommonObjects.Screen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mobile
{
    public class SimCorpMobile : MobileEntity
    {
        public override IPlayback iplayb { get; set; }
        public override IOutput ioutput { get; set; }
        public override ICharger icharger { get; set; }
        public override ICase icase { get; set; }
        public override IScreenTouch iscreentouch { get; set; }

        public override MobileTypeConcrete MobileTypes { get { return vMobileTypes; } set { value = vMobileTypes; } }

        private MobileTypeConcrete vMobileTypes = MobileTypeConcrete.Smartphone;

        public override OperatingSystems OperatingSystemType { get { return vOperatingSystems; } set { value = vOperatingSystems; } }

        private OperatingSystems vOperatingSystems = OperatingSystems.IOS;

        public override ScreenBase Screen { get { return vOLEDScreen; } }

        public override Screenn ScreenTouch { get { return vMultiTouch; } set { value = vMultiTouch; } }

        private readonly MultiTouch vMultiTouch = new MultiTouch("456", 56.34, 2, TypeOfScreens.IPS);

        public override CameraBase Camera { get { return vFrontCamera; } }

        private readonly FrontCamera vFrontCamera = new FrontCamera(1, 16);
        public override string MemoryType { get; set; } = "RAMM";
        public override int SizeOfMemory { get; set; } = 128;
        public override Battery Battery { get { return vBattery; } set { } }

        private readonly Battery vBattery = new Battery(234, 456);
        public override TypeOfConditions TypeOfConditions { get { return vTypeOfConditions; } set { value = vTypeOfConditions; } }

        private TypeOfConditions vTypeOfConditions = TypeOfConditions.New;
        public override Speaker Dynamic { get { return vDynamic; } }

        private readonly Speaker vDynamic = new Speaker(2, 40);
        public override Keyboard Keyboard { get { return vKeyboard; } set { value = vKeyboard; } }

        private readonly Keyboard vKeyboard = new Keyboard() { Figures = new char[] { '#', '%' }, Letters = new char[]{ 'y', 'x' } };

        public override ManufacturerBrands ManufacturerBrands { get { return vManufacturerBrands; } set { value = vManufacturerBrands; } }

        private ManufacturerBrands vManufacturerBrands = ManufacturerBrands.Asus;

        public override CountryOfManufacturers CountryOfManufacturers { get { return vCountryOfManufacturers; } set { value = vCountryOfManufacturers; } }

        private CountryOfManufacturers vCountryOfManufacturers = CountryOfManufacturers.USA;

        public override MemoryCard MemoryCard { get { return vMemoryCard; } set { value = vMemoryCard; } }

        private readonly MemoryCard vMemoryCard = new MemoryCard(16);

        public override Microphone Microphone { get { return vMicrophone; } set { value = vMicrophone; } }

        private readonly Microphone vMicrophone = new Microphone(2, TypeOfMicrophone.Digital);
        public override Sim_card Sim_card { get { return vSim_card; } set { value = vSim_card; } }

        private readonly Sim_card vSim_card = new Sim_card("Life", "Nano Sim");

        //public override void SelectComponent(string i)
        //{
           
            
        //    //string i = Convert.ToString(Console.ReadLine());

        //    iPhoneHeadset iphone = new iPhoneHeadset();
        //    SamsungHeadset samsphone = new SamsungHeadset();
        //    ConsoleOutput output = new ConsoleOutput();


        //    switch (i)
        //    {
        //        case "1":
        //            Console.WriteLine("IPhoneHeadset selected");
        //            Console.WriteLine("Play sound in mobile");
        //            iphone.Play(iphone);

        //            iPhoneHeadset iphone2 = new iPhoneHeadset(output);
        //            iphone2.Play(iphone2);
        //            output.Write("iPhoneHeadset choosed");
        //            break;
        //        case "2":
        //            Console.WriteLine("SamsungHeadset selected");
        //            Console.WriteLine("Play sound in mobile");
        //            samsphone.Play(samsphone);
        //            output.Write("SamsungHeadset choosed");
        //            break;
        //    }

        }
    }

