using Terminal.Gui;
using static Supabase.Gotrue.Constants;

namespace Redlands.Application.Windows
{
    public class LoginWindow : Window
    {
        public LoginWindow()
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

                Label titleLabel = new()
                {
                    Text = "Login",
                    X = Pos.Center(),
                    ColorScheme = new ColorScheme()
                    {
                        Normal = Terminal.Gui.Attribute.Make(Color.BrightRed, Color.Black)
                    },

                };

                Label lblUsername = new()
                {
                    Text = "Username",
                    Y = Pos.Top(titleLabel) + 3,
                    X = Pos.Center(),
                };

                TextField txtUsername = new("")
                {
                    X = Pos.Center(),
                    Y = Pos.Top(lblUsername) + 2,
                    Width = Dim.Percent(35),
                };

                Label lblPassword = new()
                {
                    Text = "Password",
                    X = Pos.Center(),
                    Y = Pos.Top(txtUsername) + 2
                };

                TextField txtPassword = new("")
                {
                    Secret = true,
                    X = Pos.Center(),
                    Y = Pos.Top(lblPassword) + 2,
                    Width = Dim.Percent(35),
                };

                CheckBox checkSavePassword = new()
                {
                    Text = "Save Password",
                    X = Pos.Center(),
                    Y = Pos.Top(txtPassword) + 2
                };

                // Create login button
                Button btnLogin = new()
                {
                    Text = "Login",
                    Y = Pos.Top(checkSavePassword) + 2,
                    X = Pos.Center(),
                    IsDefault = true,
                };

                Button btnCreateAccount = new()
                {
                    Text = "Create Account",
                    Y = Pos.Top(btnLogin) + 2,
                    X = Pos.Center()
                };

                btnLogin.Clicked += async () =>
                {
                    try
                    {
                        Supabase.Gotrue.Session? session = await
                        Program.supabase.Auth.SignIn
                        (
                            SignInType.Email,
                            txtUsername.Text.ToString() ?? string.Empty,
                            txtPassword.Text.ToString() ?? string.Empty
                        ) ?? null;

                        MessageBox.Query("Login", "Successful", "Ok");
                        Terminal.Gui.Application.Run<InitWindow>();
                    }
                    catch (Exception)
                    {
                        txtUsername.Text = "";
                        txtPassword.Text = "";
                        txtUsername.SetFocus();
                        MessageBox.ErrorQuery("Login", "Invalid Credentials", "Ok");
                    }
                };

                btnCreateAccount.Clicked += () =>
                {
                    Terminal.Gui.Application.Run<RegisterWindow>();
                };

                //Render on the Window
                Add(
                    titleLabel,
                    lblUsername,
                    txtUsername,
                    lblPassword,
                    txtPassword,
                    checkSavePassword,
                    btnLogin,
                    btnCreateAccount
                );
            }
        }
    }
}
