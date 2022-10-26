using MudBlazor;

namespace FakeAuthenticationPrototype.Client.Shared;

public partial class MainLayout
{
    MudTheme SquadsTheme = new MudTheme()
    {
        Palette = new Palette()
        {
            Primary = Colors.Shades.Black,
            Secondary = Colors.Shades.White,
            Tertiary = Colors.Amber.Darken4
        }
    };
}