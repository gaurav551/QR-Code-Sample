using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;
using System.Drawing;

namespace Delegates
{
    public class QrCodeExample
    {
        public static void GenerateQR(string text)
        {
            //generate qr code
            var qrcodeWriter = new BarcodeWriter();

            qrcodeWriter.Format = BarcodeFormat.QR_CODE;
            qrcodeWriter.Options.Height = 400;
            qrcodeWriter.Options.Width = 400;

            qrcodeWriter.Write(text)
                        .Save("QrDemo.jpg");
            Console.WriteLine("Qr code is generated");

           

          
        }
         //read the qr code
        public static string DecodeQrCode(Bitmap bitmap)
        {
            
            var qrcodeReader = new BarcodeReader();
            var qrcodeResult = qrcodeReader.Decode(bitmap);

            
            Console.WriteLine($"barcode format: {qrcodeResult.BarcodeFormat}");
            Console.WriteLine("Qr code read successfully");
            return qrcodeResult.Text;
        }
    }
}