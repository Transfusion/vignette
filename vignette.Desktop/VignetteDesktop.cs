using System.Reflection;
using osu.Framework.Platform;

namespace vignette.Desktop
{
    public class VignetteDesktop : VignetteGame
    {
        public override void SetHost(GameHost host)
        {
            base.SetHost(host);

            switch (host.Window)
            {
                // Legacy osuTK Window
                case OsuTKDesktopWindow desktopGameWindow:
                    desktopGameWindow.SetIconFromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream(GetType(), "logo.ico"));
                    desktopGameWindow.Title = Name;
                    break;

                // SDL2 Window
                case SDL2DesktopWindow desktopWindow:
                    desktopWindow.Title = Name;
                    break;
            }
        }
    }
}