﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    public class Microphone
    {
        public int NumberOfMicrophone { get;  } //1-2
        public TypeOfMicrophone TypeOfMicrophone { get; } //digital, analog
        public Microphone(int numberOfMicrophone, TypeOfMicrophone typeOfMicrophone)
        {
            NumberOfMicrophone = numberOfMicrophone;
            TypeOfMicrophone = typeOfMicrophone;
        }
        public override string ToString()
        {
            return "Microphone";
        }
    }
}
