using CommandLine;
using MicActiveBar.Properties;

namespace MicActiveBar
{
    internal static class Program
    {
        private static Icon? soundIcon;

        [STAThread]
        private static void Main(string[] args)
        {
            Parser.Default.ParseArguments<MabOptions>(args).WithParsed(options =>
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                soundIcon = GraphicsHelper.GetSoundIndicationIcon(options);
                SetupMab(options);
                Application.Run();
            });
        }

        private static void SetupMab(MabOptions options)
        {
            var icn = new NotifyIcon();
            SoundHelper.MonitorAudioThreshold(
                options.Threshold,
                onOver: () => icn.Icon = soundIcon,
                onUnder: () => icn.Icon = Resources.no_sound);

            icn.Click += HandleIconClicked;
            icn.Visible = true;
            icn.Icon = Resources.no_sound;
        }

        private static void HandleIconClicked(object? sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}