using HardwareSignalsLibrary.IO;
using UnityEngine;
using Vexe.Runtime.Types;

namespace Assets.Scripts
{
    [RequireComponent(typeof(InputOutputComponent))]
    public class InputOutputSwitcherComponent : BetterBehaviour
    {
        [SerializeField]
        private InputOutputComponent inputOutputComponent;

        [SerializeField]
        private IInputReader[] availableReaders;

        [SerializeField]
        private IOutputWriter[] availableWriters;

        private int currentReader = -1;
        private int currentWriter = -1;

        public void OnEnable()
        {
            if (inputOutputComponent == null)
            {
                inputOutputComponent = GetComponent<InputOutputComponent>();
            }

            if (inputOutputComponent == null)
            {
                gameObject.SetActive(false);
                return;
            }

            SetNextReader();
            SetNextWriter();
        }

        public void Update()
        {
            if (UnityEngine.Input.GetKeyDown(KeyCode.Q))
            {
                SetNextReader();
            }
        }

        private void SetNextReader()
        {
            currentReader++;
            if (availableReaders.Length <= currentReader)
            {
                currentReader = 0;
            }

            inputOutputComponent.In = availableReaders[currentReader];
        }

        private void SetNextWriter()
        {
            currentWriter++;
            if (availableWriters.Length <= currentWriter)
            {
                currentWriter = 0;
            }

            inputOutputComponent.Out = availableWriters[currentReader];
        }
    }
}