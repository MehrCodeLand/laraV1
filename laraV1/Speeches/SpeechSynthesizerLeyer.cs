using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace laraV1.Speeches
{
    public class SpeechSynthesizerLeyer
    {
        SpeechSynthesizer speek = new SpeechSynthesizer();

        private int MainSpeekerVolum;
        public int SpeekerVolume { 
            get { return MainSpeekerVolum; } 
            set {
                
                if(value >= 0 || value <= 100)
                {
                    MainSpeekerVolum = value;
                    speek.Volume = value;
                }

                MainSpeekerVolum = 100;
                speek.Volume = 100;
            }
        }
        public void SetOutPut()
        {
            speek.SetOutputToDefaultAudioDevice();
        }
        public void SelectGenderVoice( bool IsMale)
        {
            if(IsMale == true)
            {
                speek.SelectVoice("Microsoft David Desktop");
            }

            speek.SelectVoice("Microsoft Zira Desktop");
        }
    }
}
