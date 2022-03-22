using NAudio.Wave;

namespace MicActiveBar
{
    internal static class SoundHelper
    {

        internal static float GetMaxAudioLevel(int numberOfBytes, byte[] buffer)
        {
            float max = 0;
            // interpret as 16 bit audio
            for (int index = 0; index < numberOfBytes; index += 2)
            {
                short sample = (short)((buffer[index + 1] << 8) |
                                        buffer[index + 0]);
                // to floating point
                var sample32 = sample / 32768f;
                // absolute value 
                if (sample32 < 0) sample32 = -sample32;
                // is this the max value?
                if (sample32 > max) max = sample32;
            }

            return max;
        }

        internal static void MonitorAudioThreshold(float threshold, Action onOver, Action onUnder)
        {
            var waveIn = new WaveInEvent();
            waveIn.DataAvailable += (s, a) =>
            {
                var max = GetMaxAudioLevel(a.BytesRecorded, a.Buffer);
                if (max > threshold)
                {
                    onOver();
                }
                else
                {
                    onUnder();
                }
            };
            waveIn.StartRecording();
        }
    }
}