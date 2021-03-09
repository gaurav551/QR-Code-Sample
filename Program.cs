using System;
using System.Collections.Generic;
using System.Drawing;

namespace Delegates
{          
    class Program
    {      
        public delegate void CreateQr(string qrText);
        public delegate string ReadQr(Bitmap bitmap);
        static void Main(string[] args)
        { 
            CreateQr create = QrCodeExample.GenerateQR; 
            create("Gaurav Acharya");
            ReadQr read =  QrCodeExample.DecodeQrCode;
            string text = read(new Bitmap("QrDemo.jpg"));
            System.Console.WriteLine(text);
         
         
        }  
      
           
    }       
           
}          
           