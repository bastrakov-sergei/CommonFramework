using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Vexe.Runtime.Types;

namespace Assets.Scripts
{
    public static class ExcInputs
    {
        public const string Acceleration = "Acceleration";
        public const string Clutch = "Clutch";
        public const string Brake = "Brake";
        public const string Handbrake = "Handbrake";
    }

    public abstract class Input
    {
        [SerializeField]
        [Popup(ExcInputs.Acceleration, ExcInputs.Brake, ExcInputs.Clutch, ExcInputs.Handbrake)]
        private string key;

        public string Key
        {
            get { return key; }
        }
    }
}