using UnityEngine;

namespace Assets.Scripts
{
    public class UnityFakeAxisInput : AxisInput
    {
        [SerializeField]
        private KeyCode positiveKeyCode;
        [SerializeField]
        private KeyCode negativeKeyCode;

        public override float Value
        {
            get { return AxisEmulate(positiveKeyCode, negativeKeyCode); }
        }

        private static float AxisEmulate(KeyCode positive, KeyCode negative)
        {
            if (UnityEngine.Input.GetKey(positive))
            {
                return 1.0f;
            }
            if (UnityEngine.Input.GetKey(negative))
            {
                return -1.0f;
            }
            return 0.0f;
        }
    }
}