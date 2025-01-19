using System.Windows;

namespace WpfApp1
{
    [System.Runtime.InteropServices.ComVisible(true)]
    public class ScriptHandler
    {
        public void SendMessage(string message)
        {
            MessageBox.Show($"Message from browser: {message}", "Message Received");
        }
    }
}
