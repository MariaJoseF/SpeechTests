using System;
namespace SpeechTest
{
    public partial class WindowTest : Gtk.Window
    {
        public WindowTest() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }
    }
}
