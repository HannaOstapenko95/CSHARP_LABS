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
    public enum MobileTypeConcrete
    {
        Push_button_phone,
        Smartphone
    }
    public enum OperatingSystems
    {
        Androide,
        IOS,
        MeeGo
    }
    public enum TypeOfConditions
    {
        Used,
        New
    }
    public enum ManufacturerBrands
    {
        Apple,
        Samsung,
        LG,
        Asus,
        Acer
    }
    public enum CountryOfManufacturers
    {
        China,
        USA,
        Ukraine,
        France
    }
    public enum TypeOfMicrophone
    {
        Analog,
        Digital
    }
    public enum TypeOfScreens
    {
        SuperAmoled,
        NFC,
        IPS
    }

    public abstract class MobileEntity
    {
        public abstract MobileType MobileType { get; }
        public abstract MobileTypeConcrete MobileTypes { get; set; }
        public abstract OperatingSystem OperatingSystem { get; }
        public abstract OperatingSystems OperatingSystemType { get; set; }
        public abstract ScreenBase Screen { get; }
        public abstract Screen ScreenTouch { get; set; }
        public abstract CameraBase Camera { get; }
        public abstract MemoryBase Memory { get; }
        public abstract Battery Battery { get; set; }
        public abstract Condition Condition { get; }
        public abstract TypeOfConditions TypeOfConditions { get; set; }
        public abstract Dynamic Dynamic { get; }
        public abstract Keyboard Keyboard { get; set; }
        public abstract Manufacturer Manufacturer { get; }
        public abstract ManufacturerBrands ManufacturerBrands { get; set; }
        public abstract CountryOfManufacturers CountryOfManufacturers { get; set; }
        public abstract MemoryCard MemoryCard { get; set; }
        public abstract Microphone Microphone { get; set; }
        public abstract Sim_card Sim_card { get; set; }

        public OLEDScreen vOLEDScreen = new OLEDScreen();

        private void Show(IScreenImage screenImage)
        {
            Screen.Show(screenImage);
        }
        private void Show(IScreenImage screenImage, int brightness, string image_size, string drawing)
        {
            Screen.Show(screenImage, brightness, image_size, drawing);
        }
        public string GetDescription()
        {
        var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"Screen Type: {Screen.ToString()} {Screen.Show(vOLEDScreen, 123, "123X580", "drawing")}");

            //1st type of retrieving values of properties for displaying
            descriptionBuilder.AppendLine($"Mobile Type: {MobileType.ToString()} -> Type = {MobileTypes.ToString()}"); 
            descriptionBuilder.AppendLine($"Operating System: {OperatingSystem.ToString()} -> Type = {OperatingSystemType.ToString()}");
            descriptionBuilder.AppendLine($"Screen touch Type: {ScreenTouch.ToString()} -> Resolution = {ScreenTouch.Resolution}; Diagonal = {ScreenTouch.Diagonal}; Type of Screen {ScreenTouch.TypeOfScreen}");
            descriptionBuilder.AppendLine($"Camera Type: {Camera.ToString()} -> Number of cameras = {Camera.NumberOfCameras}; Pixels = {Camera.Pixel}");
            descriptionBuilder.AppendLine($"Memory Type: {Memory.ToString()} -> Size of memory = {Memory.SizeOfMemory}Gb");
            descriptionBuilder.AppendLine($"Condition: {Condition.ToString()} -> Type = {TypeOfConditions.ToString()}");
            descriptionBuilder.AppendLine($"First 2 symbols on Keyboard: {Keyboard.ToString()} -> " +
                    $"Figures: {Keyboard.Figures[0]}, {Keyboard.Figures[1]}; Letters: {Keyboard.Letters[0]}, {Keyboard.Letters[1]}");
            descriptionBuilder.AppendLine($"Manufacturer: {Manufacturer.ToString()} -> Brand = {ManufacturerBrands.ToString()}; Country = {CountryOfManufacturers.ToString()}");
            descriptionBuilder.AppendLine($"Memory card: {MemoryCard.ToString()} -> Size = {MemoryCard.Size}Gb");
            descriptionBuilder.AppendLine($"Microphone: {Microphone.ToString()} -> Number of microphones = {Microphone.NumberOfMicrophone}; Type of microphone = {Microphone.TypeOfMicrophone}");
            descriptionBuilder.AppendLine($"Sim Card: {Sim_card.ToString()} -> Number of Sim-cards {Sim_card.NumberOfSimCards}");

            //2nd type of retrieving values of properties for displaying: 
            //returning a full string with values of all properties from Component-classes
            descriptionBuilder.AppendLine($"Battery: {Battery.ToString()}");
            descriptionBuilder.AppendLine($"Dynamic: {Dynamic.ToString()}");  
            return descriptionBuilder.ToString();
        }
    }
}
