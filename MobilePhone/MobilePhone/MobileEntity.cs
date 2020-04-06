using Mobile.Case;
using Mobile.CommonObjects;
using Mobile.CommonObjects.Camera;
using Mobile.CommonObjects.Screen;
using Mobile.MobilePhone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        IPS
    }

    public abstract class MobileEntity
    {
        public abstract IPlayback iplayb { get; set; }
        public abstract IOutput ioutput { get; set; }
        public abstract ICharger icharger { get; set; }
        public abstract ICase icase { get; set; }
        public abstract IScreenTouch iscreentouch { get; set; }
        public SMSProvider SMSProvider { get; set; }
        public virtual void Play(object data = null, StringBuilder textboxBuilder = null, RichTextBox textBox = null)
        {
            if (data == null || textboxBuilder == null || textBox == null)
            {
                iplayb.Play(data);
            }
            else
            {
                iplayb.Play(data, textboxBuilder, textBox);
            }
        }
        public virtual void WriteOn(string text = null, RichTextBox textBox = null, StringBuilder textboxBuilder = null)
        {
            if (textBox == null || textboxBuilder == null)
            {
                ioutput.WriteOn(text);
            }
            else
            {
                ioutput.WriteOn(text, textBox,  textboxBuilder);
            }      
        }
        public virtual void Charge(object data = null, StringBuilder textboxBuilder = null, RichTextBox textBox = null)
        {
            if ( data == null ||  textboxBuilder == null ||  textBox == null) {
                icharger.Charge(); 
            }
            else icharger.Charge(data, textboxBuilder, textBox);
        }
        public virtual void SelectCase(object data = null, StringBuilder textboxBuilder = null, RichTextBox textBox = null)
        {
            if (data == null || textboxBuilder == null || textBox == null)
            {
                icase.SelectCase();
            }
            else
            {
                icase.SelectCase(data, textboxBuilder, textBox);
            }
        }
        public virtual void SelectScreenTouch(object data = null, StringBuilder textboxBuilder = null, RichTextBox textBox = null)
        {
            if(data == null || textboxBuilder == null || textBox == null)
            {
                iscreentouch.SelectScreenTouch();
            }
            else
            {
                iscreentouch.SelectScreenTouch(data, textboxBuilder, textBox);
            }
        }
        public abstract Storage Storage { get; set; }
        public abstract MobileTypeConcrete MobileTypes { get; set; }
        public abstract OperatingSystems OperatingSystemType { get; set; }
        public abstract ScreenBase Screen { get; }
        public abstract string MemoryType { get; set; }
        public abstract int SizeOfMemory { get; set; }
        public abstract Screenn ScreenTouch { get; set; }
        public abstract CameraBase Camera { get; }
        public abstract Battery Battery { get; set; }
        public abstract TypeOfConditions TypeOfConditions { get; set; } //new or used
        public abstract Speaker Dynamic { get; }
        public abstract Keyboard Keyboard { get; set; }
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
        private void Show(IScreenImage screenImage, int brightness, string image_size, string drawing, int dpi, int numberOfColors,
            string technologyOfManufacturing)
        {
            Screen.Show(screenImage, brightness, image_size, drawing,  dpi,  numberOfColors,
             technologyOfManufacturing);
        }
      
        public override string ToString()
        {
        var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"Screen Type: {Screen.ToString()} {Screen.Show(vOLEDScreen, 123, "123X580", "drawing", 250, 8, "LCD")}");

            //1st type of retrieving values of properties for displaying
            descriptionBuilder.AppendLine($"Mobile Type = {MobileTypes.ToString()}"); 
            descriptionBuilder.AppendLine($"Operating System Type = {OperatingSystemType.ToString()}");
            descriptionBuilder.AppendLine($"Screen touch Type: {ScreenTouch.ToString()} -> Resolution = {ScreenTouch.Resolution};\n Diagonal = {ScreenTouch.Diagonal}; " +
                $"Number of Simultaneuos Touches = {ScreenTouch.NumberOfTouchesSimultaneously} Type of Screen = {ScreenTouch.TypeOfScreen}");
            descriptionBuilder.AppendLine($"Camera Type: {Camera.ToString()} -> Number of cameras = {Camera.NumberOfCameras}; Pixels = {Camera.Pixel}");
            //descriptionBuilder.AppendLine($"Memory Type: {Memory.ToString()} -> Size of memory = {Memory.SizeOfMemory}Gb");
            descriptionBuilder.AppendLine($"Size of memory = {SizeOfMemory}Gb; Type of Memory = {MemoryType}");
            descriptionBuilder.AppendLine($"Condition Type = {TypeOfConditions.ToString()}");
            descriptionBuilder.AppendLine($"First 2 symbols on Keyboard: {Keyboard.ToString()} -> " +
                    $"Figures: {Keyboard.Figures[0]}, {Keyboard.Figures[1]}; Letters: {Keyboard.Letters[0]}, {Keyboard.Letters[1]}");
            descriptionBuilder.AppendLine($"Manufacturer Brand = {ManufacturerBrands.ToString()}; Country = {CountryOfManufacturers.ToString()}");
            descriptionBuilder.AppendLine($"Memory card: {MemoryCard.ToString()} -> Size = {MemoryCard.Size}Gb");
            descriptionBuilder.AppendLine($"Microphone: {Microphone.ToString()} -> Number of microphones = {Microphone.NumberOfMicrophone}; Type of microphone = {Microphone.TypeOfMicrophone}");
            descriptionBuilder.AppendLine($"Sim Card: {Sim_card.ToString()} -> Operator of phone = {Sim_card.OperatorPhone}; Form of Simcard = " +
                $"{Sim_card.FormFactor}");

            //2nd type of retrieving values of properties for displaying: 
            //returning a full string with values of all properties from Component-classes
            descriptionBuilder.AppendLine($"Battery: {Battery.ToString()}");
            descriptionBuilder.AppendLine($"{Dynamic.ToString()}");  
            return descriptionBuilder.ToString();
        }

        
        
    }
}
