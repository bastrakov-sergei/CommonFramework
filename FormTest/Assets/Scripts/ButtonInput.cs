using System;

namespace Assets.Scripts
{
    [Serializable]
    public abstract class ButtonInput : Input
    {                   
        public abstract bool Value { get; }
    }
}