using System.Collections.Generic;
using System.Linq;
using HardwareSignalsLibrary.IO;
using UnityEngine;
using Vexe.Runtime.Types;

namespace Assets.Scripts
{
    public class KeyboardInput : BetterBehaviour, IInputReader
    {
        [SerializeField] 
        [Display(Seq.LineNumbers | Seq.PerItemRemove, FormatMethod = "ToDisplayString")] 
        [PerItem] 
        private List<AxisInput> axisInputs = new List<AxisInput>();
        [SerializeField] 
        [Display(Seq.LineNumbers | Seq.PerItemRemove, FormatMethod = "ToDisplayString")] 
        [PerItem]
        private List<ButtonInput> buttonInputs = new List<ButtonInput>();

        public float ReadAnalogInput(string key)
        {
            AxisInput unityAxisInput = axisInputs.FirstOrDefault(reader => reader != null && reader.Key == key);

            if (unityAxisInput != null)
            {
                return unityAxisInput.Value;
            }

            return 0.0f;
        }

        public bool ReadDigitalInput(string key)
        {
            ButtonInput buttonInput = buttonInputs.FirstOrDefault(reader => reader != null && reader.Key == key);

            if (buttonInput != null)
            {
                return buttonInput.Value;
            }

            return false;
        }

        private string ToDisplayString(Input input)
        {
            return input != null ? input.Key : "Emtpy";
        }
    }
}