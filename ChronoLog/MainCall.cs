using System;
using System.Windows.Forms;

namespace ChronoLog {
    internal static class MainCall {

        [STAThread]
        static void Main() {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new LogInGUI());
        }
    }
}

