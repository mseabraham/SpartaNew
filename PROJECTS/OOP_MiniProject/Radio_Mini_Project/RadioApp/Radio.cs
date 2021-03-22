using System.Media;

namespace RadioApp
{
    public class Radio
    {

        private int _channel = 1;
        private bool _on; 
        

        public int Channel { 
            get { return _channel; }
            set {
                if (_on is true)
                {
                    if ((value >= 1)&& (value <= 4))
                    {
                        _channel = value;
                    }
                }
            } 
        }

        public Radio(){ _on = false;}

        public string Play()
        {
           if (_on is true)
            {
                return $"Playing channel {_channel}";
            }
            else
            {
                return "Radio is off";
            }
            
        }

        public void TurnOff() { _on = false; }


        public void TurnOn() { _on = true; }

       

       
    }
}