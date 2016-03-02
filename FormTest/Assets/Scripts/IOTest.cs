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
            float input = ioComponent.ReadAnalogInput(ExcInputKeys.Acceleration);
            GUILayout.Label(ExcInputKeys.Acceleration + ": " + input);

            input = ioComponent.ReadAnalogInput(ExcInputKeys.Brake);
            GUILayout.Label(ExcInputKeys.Brake + ": " + input);

            input = ioComponent.ReadAnalogInput(ExcInputKeys.Clutch);
            GUILayout.Label(ExcInputKeys.Clutch + ": " + input);

            input = ioComponent.ReadAnalogInput(ExcInputKeys.Handbrake);
            GUILayout.Label(ExcInputKeys.Handbrake + ": " + input);

            if (GUILayout.Button("Send"))
            {
                ioComponent.WriteAnalogOuput("out", Random.value);
            }
        }
    }
}