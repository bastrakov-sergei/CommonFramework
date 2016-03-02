using System.Collections.Generic;

namespace Assets.Scripts
{
    public abstract class InputKeys
    {
        public static string[] Array
        {
            get
            {
                return keys.ToArray();
            }
        }

        public static List<string> Keys
        {
            get { return keys; }
        }

        private static List<string> keys = new List<string>();

        static InputKeys()
        {
            IEnumerable<InputKeys> types = ReflectiveEnumerator.GetEnumerableOfType<InputKeys>();

            foreach (InputKeys type in types)
            {
                type.Init();
            }
        }

        protected abstract void Init();
    }
}