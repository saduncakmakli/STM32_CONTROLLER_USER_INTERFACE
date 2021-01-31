using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Design_Project
{
    public class Controller
    {
        public Uart uart;

        private StepMod mod = StepMod.PASSIVE_MOD;
        private StepPower power = StepPower.STEP_PASSIVE;
        private StepDirection direction = StepDirection.CLOCKWISE;

        private ushort speed = 0; // PULSE/MINUTE
        private ushort speedLimit = 60; //Kalibrasyon ile değiştirilecek.
        private ushort degree = 0;

        public StepMod Mod { get => mod; }
        public StepPower Power { get => power; }
        public StepDirection Direction { get => direction; }

        private ushort Speed
        {
            get => speed;
            set
            {
                if (value > speedLimit) speed = speedLimit;
                else speed = value;
            }
        }

        public ushort GetSpeed() => speed;
        public ushort GetDegree() => degree;

        public Uart CreteUart(string portName, int baundRate, Parity parity, int dataBit)
        {
            uart = new Uart(portName, baundRate, parity, dataBit);
            return uart;
        }

        public bool ToogleDirection()
        {
            return ChangeDirection(Direction == StepDirection.CLOCKWISE ? StepDirection.ANTICLOCKWISE : StepDirection.CLOCKWISE);
        }

        public bool TooglePower()
        {
            return ChangePower(Power == StepPower.STEP_ACTIVE ? StepPower.STEP_PASSIVE : StepPower.STEP_ACTIVE);
        }

        public bool ChangeMod(StepMod stepMod)
        {
            mod = stepMod;
            return SendSerialModeSelectCommand(stepMod);
        }

        public bool ChangeDirection(StepDirection stepDirection)
        {
            direction = stepDirection;
            return uart.SendSerialCommand(command: Static.CommandFromStepDirection(stepDirection));
        }

        public bool ChangePower(StepPower stepPower)
        {
            power = stepPower;
            return uart.SendSerialCommand(command: Static.CommandFromStepPower(stepPower));
        }

        public bool ChangeSpeed(ushort speed)
        {
            Speed = speed;
            return uart.SendSerialCommand(command: CommunicationStrings.SPD, value: speed.ToString("D3"));
        }

        public bool ChangeDegree(ushort degree)
        {
            this.degree = degree;
            return uart.SendSerialCommand(command: CommunicationStrings.DEG, value: degree.ToString("D3"));
        }
        public bool SendManuelCommand(bool pulse)
        {
            return uart.SendSerialCommand(CommunicationStrings.MAN, (Power == StepPower.STEP_ACTIVE ? 1 : 0).ToString() + (Direction == StepDirection.CLOCKWISE ? 1 : 0).ToString() + (pulse ? 1 : 0).ToString());
        }
        private bool SendSerialModeSelectCommand(StepMod stepMod)
        {
            return uart.SendSerialCommand(CommunicationStrings.MOD, Static.CommandFromStepMod(stepMod).ToString());
        }
        
        public bool SendConnectionTestCommand()
        {
            return uart.SendSerialCommand(CommunicationStrings.TST);
        }
    }

}
