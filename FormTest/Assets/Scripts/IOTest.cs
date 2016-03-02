using HardwareSignalsLibrary.IO;
using UnityEngine;

namespace Assets.Scripts
{
    public class IOTest : MonoBehaviour
    {
        [SerializeField]
        private IInputOutputSystem ioComponent;

        public void Start()
        {
            if (ioComponent == null)
            {
                ioComponent = FindObjectOfType<InputOutputComponent>();
            }

            if (ioComponent == null)
            {
                gameObject.SetActive(false);
            }
        }

        public void OnGUI()
        {
            float input = ioComponent.ReadAnalogInput(ExcInputs.Acceleration);
            GUILayout.Label(ExcInputs.Acceleration + ": " + input);

            input = ioComponent.ReadAnalogInput(ExcInputs.Brake);
            GUILayout.Label(ExcInputs.Brake + ": " + input);

            input = ioComponent.ReadAnalogInput(ExcInputs.Clutch);
            GUILayout.Label(ExcInputs.Clutch + ": " + input);

            input = ioComponent.ReadAnalogInput(ExcInputs.Handbrake);
            GUILayout.Label(ExcInputs.Handbrake + ": " + input);

            if (GUILayout.Button("Send"))
            {
                ioComponent.WriteAnalogOuput("out", Random.value);
            }
        }
    }
}