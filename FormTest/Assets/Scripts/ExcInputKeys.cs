namespace Assets.Scripts
{
    public sealed class ExcInputKeys : InputKeys
    {
        public const string Acceleration = "Acceleration";
        public const string Clutch = "Clutch";
        public const string Brake = "Brake";
        public const string Handbrake = "Handbrake";
        public const string Wheel = "Wheel";

        protected override void Init()
        {
            Keys.Add(Acceleration);
            Keys.Add(Clutch);
            Keys.Add(Brake);
            Keys.Add(Handbrake);
            Keys.Add(Wheel);
        }
    }
}