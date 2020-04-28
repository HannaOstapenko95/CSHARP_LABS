
using Mobile.MobilePhone;
using System;
using System.Collections.Generic;

public class SMSProvider : Storage
{
    public delegate string SMSReceivedDelegate(string message);
    //public delegate string SMSReceivedDelegate();
    public delegate string FormatDelegate(string text);
    public delegate string FormatDelegateDate(string text, DateTime dateTime);
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

