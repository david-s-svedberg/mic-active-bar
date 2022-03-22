using CommandLine;

namespace MicActiveBar
{
    static class Program
    {
        static Icon? soundIcon = null;

        [STAThread]
        public static void Main(string[] args)
        {
            Parser.Default.ParseArguments<MABOptions>(args).WithParsed(options =>
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                soundIcon = GraphicsHelper.GetSoundIndicationIcon(options);
                SetupMAB(options);
                Application.Run();
            });
        }

        private static void SetupMAB(MABOptions options)
        {
            NotifyIcon icn = new NotifyIcon();
            SoundHelper.MonitorAudioThreshold(
                options.Threshold, 
                onOver: () => icn.Icon = soundIcon, 
                onUnder: () => icn.Icon = Properties.Resources.no_sound);

            icn.Click += new EventHandler(HandleIconClicked);
            icn.Visible = true;
            icn.Icon = Properties.Resources.no_sound;
        }

        static void HandleIconClicked(object? sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}