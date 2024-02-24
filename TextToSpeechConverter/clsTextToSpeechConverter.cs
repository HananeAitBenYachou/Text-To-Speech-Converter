using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace TextToSpeechConverter
{
    public class clsTextToSpeechConverter
    {
        public SynthesizerState state => _Synthesizer.State;

        private SpeechSynthesizer _Synthesizer;

        public clsTextToSpeechConverter()
        {
            _Synthesizer = new SpeechSynthesizer();
        }

        public HashSet<string> GetAvailableLanguages()
        {
            return _Synthesizer.GetInstalledVoices().Select(voice => voice.VoiceInfo.Culture.DisplayName).ToHashSet(); 
        }

        public HashSet<string> GetVoicesForLanguage(string selectedLangugae)
        {
            return _Synthesizer.GetInstalledVoices()
                .Where(voice => voice.VoiceInfo.Culture.DisplayName.Equals(selectedLangugae))
                .Select(voice => voice.VoiceInfo.Name).ToHashSet();
        }

        public void ConvertTextToSpeech(string text, string selectedVoice , int rate)
        {
            _Synthesizer.Rate = rate;
            _Synthesizer.SelectVoice(selectedVoice);
            _Synthesizer.SpeakAsync(text);
        }

        public void SetSpeechRate(int rate)
        {
            _Synthesizer.Rate = rate;

        }

        public void Resume()
        {
            if(_Synthesizer.State == SynthesizerState.Paused)
                _Synthesizer.Resume();
        }

        public void Pause()
        {
            if (_Synthesizer.State == SynthesizerState.Speaking)
                _Synthesizer.Pause();
        }

        public void Stop()
        {
            _Synthesizer.SpeakAsyncCancelAll();
        }
    }
}
