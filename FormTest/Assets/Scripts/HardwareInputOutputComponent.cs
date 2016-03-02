using System.Collections.Generic;
using HardwareSignalsLibrary.IO;
using HardwareSignalsLibrary.IO.Hardware;
using UnityEngine;
using Vexe.Runtime.Types;

namespace Assets.Scripts
{
    public class HardwareInputOutputComponent : BetterBehaviour, IInputReader, IOutputWriter
    {
        [SerializeField]
        private HardwareInputOutputConfiguration configuration;

        [SerializeField]
        [Paragraph]
        private string json;

        private IHardwareSignals signals = new EmptyHardwareSignals(2,2,2,2,2);

        private HardwareInputOutput hardwareInputOutput;

        public void Awake()
        {
            hardwareInputOutput = new HardwareInputOutput(signals);
            hardwareInputOutput.SetConfiguration(configuration);
        }

        public void OnEnable()
        {
            hardwareInputOutput.Start();
        }

        public void OnDisable()
        {
            hardwareInputOutput.Stop();  
        }

        public float ReadAnalogInput(string key)
        {
            return ((IInputReader) hardwareInputOutput).ReadAnalogInput(key);
        }

        public bool ReadDigitalInput(string key)
        {
            return ((IInputReader) hardwareInputOutput).ReadDigitalInput(key);
        }

        public void WriteAnalogOuput(string key, float value)
        {
            ((IOutputWriter) hardwareInputOutput).WriteAnalogOuput(key, value);
        }

        public void WriteDigitalOuput(string key, bool value)
        {
            ((IOutputWriter) hardwareInputOutput).WriteDigitalOuput(key, value);
        }

        public void WriteDigitalIndicator(string key, byte value)
        {
            ((IOutputWriter) hardwareInputOutput).WriteDigitalIndicator(key, value);
        }

        [Show]
        public void ToJson()
        {
            json = configuration.ToJson();
        }

        [Show]
        public void FromJson()
        {
            configuration = HardwareInputOutputConfiguration.FromJson(json);
        }
    }        
}