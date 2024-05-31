using Terminal.Gui;
using static Supabase.Gotrue.Constants;

namespace Redlands.Application.Windows
{
    public class RegisterWindow : Window
    {
        public RegisterWindow()
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

                var titleLabel = new Label()
                {
                    Text = "Create your account",
                    X = Pos.Center(),
                    ColorScheme = new ColorScheme()
                    {
                        Normal = Terminal.Gui.Attribute.Make(Color.BrightRed, Color.Black)
                    },

                };

                var lblEmail = new Label()
                {
                    Text = "Email",
                    Y = Pos.Top(titleLabel) + 3,
                    X = Pos.Center(),
                };

                var txtEmail = new TextField("")
                {
                    X = Pos.Center(),
                    Y = Pos.Top(lblEmail) + 2,
                    Width = Dim.Percent(35),
                };

                var lblPassword = new Label()
                {
                    Text = "Password",
                    X = Pos.Center(),
                    Y = Pos.Top(txtEmail) + 2
                };

                var txtPassword = new TextField("")
                {
                    Secret = true,
                    X = Pos.Center(),
                    Y = Pos.Top(lblPassword) + 2,
                    Width = Dim.Percent(35),
                };

                var btnRegister = new Button()
                {
                    Text = "Register",
                    Y = Pos.Bottom(lblPassword) + 3,
                    X = Pos.Center(),
                    IsDefault = true,
                };

                btnRegister.Clicked += async () =>
                {
                    try
                    {
                        Supabase.Gotrue.Session? session = await Program.supabase.Auth.SignUp(SignUpType.Email, txtEmail.Text.ToString() ?? string.Empty, txtPassword.Text.ToString() ?? string.Empty) ?? null;

                        MessageBox.Query("Logging In", "Login Successful", "Ok");
                        //Terminal.Gui.Application.Run<>();
                    }
                    catch (Exception)
                    {
                        MessageBox.ErrorQuery("Logging In", "Invalid Credentials", "Ok");
                    }
                };

                Add(
                    titleLabel,
                    lblEmail,
                    txtEmail,
                    lblPassword,
                    txtPassword,
                    btnRegister
                );
            }
        }
    }
}