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
                Title = "Redlands";

                ColorScheme = new ColorScheme()
                {
                    Normal = Terminal.Gui.Attribute.Make(Color.BrightRed, Color.Black),
                    Focus = Terminal.Gui.Attribute.Make(Color.Black, Color.DarkGray),
                    HotNormal = Terminal.Gui.Attribute.Make(Color.BrightRed, Color.Black),
                    HotFocus = Terminal.Gui.Attribute.Make(Color.Black, Color.DarkGray)
                };

                Label firstQuestion = new()
                {
                    Text = "Voc� est� em um escrit�rio fazendo uma entrevista de emprego...\r\n\r\n" +
                    "Helena: Oi, tudo bem ? estamos muito interessados no seu perfil, depois de voc� ter feito a prova\r\n" +
                    "ficamos bem confiantes de que nosso caminhos est�o alinhados!\r\n\r\n\r\n" +
                    "Agora, preciso fazer uma bateria de perguntas que talvez sejam um pouco desconfort�veis, tudo bem ?\r\n",

                    X = Pos.Center(),
                    Y = Pos.Percent(10),

                    ColorScheme = new ColorScheme()
                    {
                        Normal = Terminal.Gui.Attribute.Make(Color.BrightRed, Color.Black)
                    },
                };
             
                //Render on the Window
                Add(
                    firstQuestion
                );
            }
        }
    }
}
