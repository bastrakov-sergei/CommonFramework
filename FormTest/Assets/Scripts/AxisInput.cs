using UnityEngine;

namespace Assets.Scripts
{
    public abstract class AxisInput : Input
    {
        public abstract float Value { get; }    
    }
}