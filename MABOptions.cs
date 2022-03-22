using CommandLine;

namespace MicActiveBar
{
    internal class MabOptions
    {
        [Option('d', "darken", Default = 0.8f, HelpText = "Sets the darkened tint of the sound indication icon")]
        public float Darken { get; set; }

        [Option('t', "threshold", Default = 0.01f, HelpText = "Sets the darkened tint of the sound indication icon")]
        public float Threshold { get; set; }
    }
}