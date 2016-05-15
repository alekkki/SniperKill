using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace Test_Sniper
{
    public static class CustomFont
    {
        public static Font sizeFont { get; set; }
        public static Font styleFont { get; set; }
        public static Font statusFont { get; set; }
        public static Font smallFont { get; set; }
        public static Font difficultyFont { get; set; }
        public static Font mediumFont { get; set; }
        public static Font menuFont { get; set; }
        public static Font largeFont { get; set; }
        public static Font titleFont { get; set; }
        public static PrivateFontCollection font;

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        static CustomFont()
        {
            setFont();
            sizeFont = new Font(font.Families[0], 15.0F, FontStyle.Regular);
            styleFont = new Font(font.Families[0], 17.0F, FontStyle.Regular);
            statusFont = new Font(font.Families[0], 20.0F, FontStyle.Regular);
            smallFont = new Font(font.Families[0], 22.0F, FontStyle.Regular);
            difficultyFont = new Font(font.Families[0], 24.0F, FontStyle.Regular);
            mediumFont = new Font(font.Families[0], 26.0F, FontStyle.Regular);
            menuFont = new Font(font.Families[0], 28.0F, FontStyle.Regular);
            largeFont = new Font(font.Families[0], 40.0F, FontStyle.Regular);
            titleFont = new Font(font.Families[0], 56.0F, FontStyle.Regular);
        }

        /// <summary>
        /// Method for setting the font in the Menu
        /// </summary>
        private static void setFont()
        {
            font = new PrivateFontCollection();
            byte[] fontData = Properties.Resources.cs_regular;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            font.AddMemoryFont(fontPtr, Properties.Resources.cs_regular.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.cs_regular.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);
        }
    }
}
