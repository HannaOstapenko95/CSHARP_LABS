using Mobile.CommonObjects;
using Mobile.CommonObjects.Camera;
using Mobile.CommonObjects.Memory;
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
        public override MobileType MobileType { get { return vMobileType; } }

        private MobileType vMobileType = new MobileType();


        public override MobileTypeConcrete MobileTypes { get { return vMobileTypes; } set { value = vMobileTypes; } }

        private MobileTypeConcrete vMobileTypes = MobileTypeConcrete.Smartphone;


        public override OperatingSystems OperatingSystemType { get { return vOperatingSystems; } set { value = vOperatingSystems; } }

        private OperatingSystems vOperatingSystems = OperatingSystems.IOS;


        public override ScreenBase Screen { get { return vOLEDScreen; } }

        //private readonly OLEDScreen vOLEDScreen = new OLEDScreen();


        public override Screen ScreenTouch { get { return vMultiTouch; } set { value = vMultiTouch; } }

        private readonly MultiTouch vMultiTouch = new MultiTouch("456", 56.34, TypeOfScreens.IPS);


        public override CameraBase Camera { get { return vFrontCamera; } }

        private readonly FrontCamera vFrontCamera = new FrontCamera(1, 16);


        public override MemoryBase Memory { get { return vRAM; } }

        private readonly RAM vRAM = new RAM(8);


        public override Battery Battery { get { return vBattery; } set { } }

        private readonly Battery vBattery = new Battery(234, 456);


        public override Condition Condition { get { return vCondition; } }

        private readonly Condition vCondition = new Condition();


        public override TypeOfConditions TypeOfConditions { get { return vTypeOfConditions; } set { value = vTypeOfConditions; } }

        private TypeOfConditions vTypeOfConditions = TypeOfConditions.New;


        public override Dynamic Dynamic { get { return vDynamic; } }

        private readonly Dynamic vDynamic = new Dynamic(2, 40);


        public override Keyboard Keyboard { get { return vKeyboard; } set { value = vKeyboard; } }
        //char[] figures = { '#', '%' };
        //char[] letters = { 'A', 'B' };

        private readonly Keyboard vKeyboard = new Keyboard() { Figures = new char[] { '#', '%' }, Letters = new char[]{ 'y', 'x' } };


        public override Manufacturer Manufacturer { get { return vManufacturer; } }

        private readonly Manufacturer vManufacturer = new Manufacturer();


        public override ManufacturerBrands ManufacturerBrands { get { return vManufacturerBrands; } set { value = vManufacturerBrands; } }

        private ManufacturerBrands vManufacturerBrands = ManufacturerBrands.Asus;


        public override CountryOfManufacturers CountryOfManufacturers { get { return vCountryOfManufacturers; } set { value = vCountryOfManufacturers; } }

        private CountryOfManufacturers vCountryOfManufacturers = CountryOfManufacturers.USA;


        public override MemoryCard MemoryCard { get { return vMemoryCard; } set { value = vMemoryCard; } }

        private readonly MemoryCard vMemoryCard = new MemoryCard(16);


        public override Microphone Microphone { get { return vMicrophone; } set { value = vMicrophone; } }

        private readonly Microphone vMicrophone = new Microphone(2, TypeOfMicrophone.Digital);


        public override OperatingSystem OperatingSystem { get { return vOperatingSystem; } }

        private readonly OperatingSystem vOperatingSystem = new OperatingSystem();


        public override Sim_card Sim_card { get { return vSim_card; } set { value = vSim_card; } }

        private readonly Sim_card vSim_card = new Sim_card(2);
    }
}
