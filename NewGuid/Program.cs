using System;
using System.Windows.Forms;

namespace NewGuid
{
    internal class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            var guid = Guid.NewGuid();
            var format = args.Length > 0 ? args[0] : "N";

            try
            {
                var formattedGuid = guid.ToString(format);

                Clipboard.SetText(formattedGuid);

                Console.WriteLine($"Guid {formattedGuid} has been copied to clipboard.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed: {e}");
            }
        }
    }
}
