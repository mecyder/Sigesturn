using System.Speech.Synthesis;

namespace BLL
{
    public static class talk
    {
        public static void talkin(object text)
        {
            SpeechSynthesizer ssynth = new SpeechSynthesizer();
            ssynth.SetOutputToDefaultAudioDevice();
            ssynth.Volume = 100;
            ssynth.Rate = 0;

            ssynth.Speak(text.ToString());
        }
    }
}