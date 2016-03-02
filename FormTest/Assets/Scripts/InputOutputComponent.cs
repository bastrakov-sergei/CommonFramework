using HardwareSignalsLibrary.IO;
using UnityEngine;

namespace Assets.Scripts
{
    public class InputOutputComponent : MonoBehaviour, IInputOutputSystem
    {
        private readonly InputOutputSystem inputOutputSystem = new InputOutputSystem();

        public float ReadAnalogInput(string key)
        {
            return ((IInputReader) inputOutputSystem).ReadAnalogInput(key);
        }

        public bool ReadDigitalInput(string key)
        {
            return ((IInputReader) inputOutputSystem).ReadDigitalInput(key);
        }

        public void WriteAnalogOuput(string key, float value)
        {
            ((IOutputWriter) inputOutputSystem).WriteAnalogOuput(key, value);
        }

        public void WriteDigitalOuput(string key, bool value)
        {
            ((IOutputWriter) inputOutputSystem).WriteDigitalOuput(key, value);
        }

        public void WriteDigitalIndicator(string key, byte value)
        {
            ((IOutputWriter) inputOutputSystem).WriteDigitalIndicator(key, value);
        }

        public IInputReader In
        {
            get { return inputOutputSystem.In; }
            set
            {
                inputOutputSystem.In = value; 
                Debug.Log(value.GetType());
            }
        }

        public IOutputWriter Out
        {
            get { return inputOutputSystem.Out; }
            set
            {
                inputOutputSystem.Out = value;
                Debug.Log(value.GetType());
            }
        }
    }
}