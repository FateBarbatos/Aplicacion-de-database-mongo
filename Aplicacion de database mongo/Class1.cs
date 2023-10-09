using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_de_database_mongo
{
    public class ArduinoConector
    {
        System.IO.Ports.SerialPort Arduino;

        static void Recuperar_temperatura()
        { 
            var arduino =  new System.IO.Ports.SerialPort();
            arduino.PortName= "COM5";
            arduino.BaudRate = 9600;
            arduino.Open();

            return temperaturaC;
        }
    }
}
