using System;
using UnityEngine;
using Vexe.Runtime.Types;

namespace Assets.Scripts
{
    [Serializable]
    public class UnityInputButtonInput : ButtonInput
    {
        [SerializeField]
        private KeyCode keyCode;
        [SerializeField]
        private ButtonReadMode readMode;   

        public override bool Value
        {
            get
            {
                switch (readMode)
                {
                    case ButtonReadMode.Default:
                        return UnityEngine.Input.GetKey(keyCode);
                    case ButtonReadMode.OnDown:
                        return UnityEngine.Input.GetKeyDown(keyCode);
                    case ButtonReadMode.OnUp:
                        return UnityEngine.Input.GetKeyUp(keyCode);
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}