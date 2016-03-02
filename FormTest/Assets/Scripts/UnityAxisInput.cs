using UnityEngine;

namespace Assets.Scripts
{
    public class UnityAxisInput : AxisInput
    {
        [SerializeField]
        private string axisName;

        public override float Value
        {
            get { return UnityEngine.Input.GetAxis(axisName); }
        }
    }
}