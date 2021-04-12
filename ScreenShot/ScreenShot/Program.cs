using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;


namespace ScreenShot
{
    class Program
    {
        private static int counter = 0;
        static void Main(string[] args)
        {
            while (true)
            {
                Thread.Sleep(3000);
                makeScreenShot();
            }
        }
        static private void makeScreenShot()
        {
            Bitmap bmp = new Bitmap(
                Screen.PrimaryScreen.Bounds.Width, 
                Screen.PrimaryScreen.Bounds.Height);

            Graphics g = Graphics.FromImage(bmp);

            g.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size);

            bmp.Save($"{counter}.png");
            counter++;
        }

        //wysyłanie maili

        //wczytywanie zmiennych z pliku
    }
}
