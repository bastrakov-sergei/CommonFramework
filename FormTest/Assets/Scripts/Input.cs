using System;
using UnityEngine;
using Vexe.Runtime.Types;

namespace Assets.Scripts
{
    public abstract class Input
    {
        [SerializeField]
        [Popup("InputKeys.Array")]
        [Display(Order = 0)]
        private string key;

        public string Key
        {
            get { return key; }
        }
    }
}