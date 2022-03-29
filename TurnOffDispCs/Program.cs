using System.Runtime.InteropServices;

class Win32API
{
    [DllImport("user32.dll")]
    public static extern bool PostMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
    [DllImport("user32.dll")]
    public static extern IntPtr GetForegroundWindow();
}


namespace TurnOffDisp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Trying turn off screens...");
                Task.Delay(1000).Wait();
                Win32API.PostMessage(Win32API.GetForegroundWindow(), 274, 61808, 2);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
                Console.ReadKey();
            }

        }
    }
}