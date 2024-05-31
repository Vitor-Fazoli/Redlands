using Terminal.Gui;
using static Supabase.Gotrue.Constants;

namespace Redlands.Application.Windows
{
    public class InitWindow : Window
    {
        public InitWindow()
        {
            if (Program.supabase is null)
            {
                MessageBox.ErrorQuery("Error", "Supabase connection failed", "Ok");
                Terminal.Gui.Application.RequestStop();
            }
            else
            {

            }
        }
    }
}
