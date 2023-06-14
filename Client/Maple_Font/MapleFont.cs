using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Client.Forms
{
    public class FontManager
    {
        private static FontManager instance = new FontManager();
        public PrivateFontCollection privateFont = new PrivateFontCollection();
        public static FontFamily[] fontFamilys
        {
            get
            {
                return instance.privateFont.Families;
            }
        }
        public FontManager()
        {
            AddFontFromMemory();
        }
        private void AddFontFromMemory()
        {
            List<byte[]> fonts = new List<byte[]>();
            fonts.Add(Properties.Resources.Maplestory_Bold);
            fonts.Add(Properties.Resources.Maplestory_Light);
            foreach (byte[] font in fonts)
            {
                IntPtr fontBuffer = Marshal.AllocCoTaskMem(font.Length);
                Marshal.Copy(font, 0, fontBuffer, font.Length);
                privateFont.AddMemoryFont(fontBuffer, font.Length);
                Marshal.FreeHGlobal(fontBuffer);
            }
        }
    }
}
