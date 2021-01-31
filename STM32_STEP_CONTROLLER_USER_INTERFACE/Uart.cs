using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;

namespace Design_Project
{
    public class Uart
    {
        public readonly SerialPort serialPort;
        private const bool debug = true;

        public Uart(string portName, int baundRate, Parity parity, int dataBit)
        {
            this.serialPort = new SerialPort(portName: portName, baudRate: baundRate, parity: parity, dataBits: dataBit, stopBits:StopBits.One);
        }

        public bool SerialWrite(string str)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write(str);
                if (debug) Console.Write(str);
                return true;
            }
            else return false;
        }

        public bool SendSerialCommand(CommunicationStrings command, string value)
        {
            return SerialWrite("$" + command.ToString() + "*" + value + "!\n");
        }

        public bool SendSerialCommand(CommunicationStrings command)
        {
            return SerialWrite("$" + command.ToString() + "!----\n");
        }
    }
}
