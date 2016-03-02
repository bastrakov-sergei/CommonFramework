using HardwareSignalsInterceptor;
using HardwareSignalsLibrary.IO.Hardware;
using UnityEngine;

namespace Assets.Scripts
{
    public class HardwareSignalsTest : MonoBehaviour
    {
        private IHardwareSignals signals;

        void OnEnable()
        {
            signals = HardwareSignalsInterceptorFactory.Create();
            signals.Start();
        }

        void OnDisable()
        {
            signals.Stop();
            signals = null;
        }                 
    }
}
