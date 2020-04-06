
using Mobile.MobilePhone;
using System;
using System.Collections.Generic;

public class SMSProvider : Storage
{
    public delegate string SMSReceivedDelegate(string message);
    public delegate string FormatDelegate(string text);
    public delegate string FormatDelegateDate(string text, DateTime dateTime);

    public event SMSReceivedDelegate SMSReceived;
    
    public void DoWork(string i)
    {
        for (int n = 0; n < 10; n++)
        {
            System.Threading.Thread.Sleep(250);
            RaiseSMSReceivedEvent(i);
        }
    }


//Event for SMSReceivedDelegate
public bool RaiseSMSReceivedEvent(string message)
    {
        var handler = SMSReceived;
        if (handler != null)
        {
            handler(message);
            return true;
        }
        else
        {
            return false;
        }
    }
    public static string FormatWithTime(string message)
    {
        return $"[{DateTime.Now}] {message}";
    }
    public static string EndWithTime(string message)
    {

        return $"{message} [{DateTime.Now}] \n";
    }
    public static string UpperCase(string message)
    {
        return $"[{DateTime.Now}] {message} \n".ToUpper();
    }
    public static string LowerCase(string message)
    {
        return $"[{DateTime.Now}] {message} \n".ToLower();
    }
}

