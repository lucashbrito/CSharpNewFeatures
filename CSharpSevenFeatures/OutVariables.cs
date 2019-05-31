using System.CodeDom;
using static System.Console;

namespace CSharpSevenFeatures
{
    public class OutVariables
    {
        public OutVariables()
        {
            OldVersion();
            NewVersion();
        }

        public void GetTime(out int hours, out int minutes, out int seconds)
        {
            hours = 1;
            minutes = 34;
            seconds = 35;
        }

        public void OldVersion()
        {
            int x, y, z;

            GetTime(out x, out y, out z);

            Write($"Old Version: hour{x}:minute{y}:seconds{z}");
        }

        public void NewVersion()
        {
            var i = string.Empty;

            GetTime(out var x, out var y, out int z);

            Write($"New Version: hour{x}:minute{y}:seconds{z}");

            if (int.TryParse(i, out int xi))
            {
                Write($"New Version");
            }
            else if (int.TryParse(i, out var xo))
            {
                Write($"New Version");
            }
        }
    }
}
