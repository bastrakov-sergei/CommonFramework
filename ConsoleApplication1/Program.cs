using HardwareSignalsLibrary.IO;
using HardwareSignalsLibrary.IO.Hardware;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (IHardwareSignals signals = new EmptyHardwareSignals(2, 2, 2, 2, 2))
            {
                signals.Start();
                HardwareInputOutput hardwareInputOutput = new HardwareInputOutput(new HardwareInputConfiguration {Signals = signals});

                IInputOutputSystem inputOutputSystem = new InputOutputSystem
                {
                    In = hardwareInputOutput,
                    Out = hardwareInputOutput
                };

                IInputReader inputReader = inputOutputSystem.In;
                IOutputWriter outputWriter = inputOutputSystem.Out;

                float acceleration = inputReader.ReadAnalogInput("Acceleration");

                float speed = acceleration;

                outputWriter.WriteAnalogOuput("Speed", speed);
            }
        }
    }
}
