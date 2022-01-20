using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;


namespace Proyecto
{
    static class Program
    {

        static Sistema S;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            
            if (File.Exists("Sistema.bin"))
            {
                Stream flujo2 = File.OpenRead("Sistema.bin");
                BinaryFormatter deserializador = new BinaryFormatter();
                S = (Sistema)deserializador.Deserialize(flujo2);
                flujo2.Close();
            }
            else
                S = new Sistema();
                 

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FRMlogin());


            Stream flujo = File.Create("Sistema.bin");
            BinaryFormatter  serializer = new BinaryFormatter();
            serializer.Serialize(flujo, S);
            flujo.Close();
                       
        }

         public static Sistema getSistema()
        { 
        
        return S;

        }
    }
}
