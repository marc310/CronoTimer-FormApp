using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CTimer
{
    static class Program
    {
        // name é o identificador único da aplicação
        static Mutex _mutex = new Mutex(true, name: "d4709732-f5aa-404f-ba0e-a0a8a4201ff6");

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (_mutex.WaitOne(TimeSpan.Zero, true))
            {
                try
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Dashboard());
                }
                finally
                {
                    _mutex.ReleaseMutex();
                }
            }
            else
            {
                MessageBox.Show("Já existe uma instancia do programa em execução");
            }

        }
    }
}
