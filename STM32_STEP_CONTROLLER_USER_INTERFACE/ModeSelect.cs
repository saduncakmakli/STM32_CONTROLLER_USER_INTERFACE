using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;

namespace Design_Project
{
    public partial class ModeSelect : Form
    {
        Controller controller;

        readonly string portName;
        readonly int baundRate;
        readonly int dataBits;
        readonly Parity parity;

        public ModeSelect(ref Controller controller, string portName, int baundRate, int dataBits, Parity parity)
        {
            InitializeComponent();
            this.controller = controller;
            controller.CreteUart(portName: portName, baundRate: baundRate, parity: parity, dataBit: dataBits);
            controller.uart.serialPort.Open();
            Tmr1000MS.Enabled = true;
            LblSerialPort.Text = "SERIAL PORT: " + controller.uart.serialPort.PortName;
            LblBaundRate.Text = "BAUND RATE: " + controller.uart.serialPort.BaudRate;

            this.portName = portName;
            this.baundRate = baundRate;
            this.dataBits = dataBits;
            this.parity = parity;
        }

        private void ModeSelect_Shown(object sender, EventArgs e)
        {
            ModButtonReChangeFormVisual();
        }

        private void ModeChangeButtons_Click(object sender, EventArgs e)
        {
            StepMod butonMod = Static.ButtonToStepMode((Button)sender);
            controller.ChangePower(StepPower.STEP_PASSIVE);
            controller.ChangeMod( (controller.Mod == butonMod) ? StepMod.PASSIVE_MOD : butonMod );
            ModButtonReChangeFormVisual();
        }

        private void ModButtonReChangeFormVisual()
        {
            StepMod controllerMode = controller.Mod;

            Static.SetBackColorControl(Color.LightSkyBlue, BtnStandartMod, BtnTetiklemeliMod, BtnSinirliAciMod, BtnTetiklemeliSinirliAciMod, BtnTekYonTetiklemeliSinirliAciMod, BtnManuelMod, BtnKalibrasyonMod);
            BtnCalis_ReSetVisual();
            BtnEnable_ReSetVisual();

            if (controllerMode == StepMod.PASSIVE_MOD)
            {
                //PASİF MOD****************************************************
                Static.SetVisibleControl(false, BtnAyarlariUygula, BtnCalis, LblYon, LblYon_, CmbBxYon, LblHiz, LblHiz_, NumUpDwnHiz, LblDerece, LblDrece_, NumUpDwnDerece, BtnEnable, BtnDirection, BtnPulse);
                Size = new Size(379, 551);
                //*************************************************************
            }
            else
            {
                //PASİF DEĞİL**************************************************
                Size = new Size(636, 551);
                BtnReConnect.BackColor = Color.Red;
                //*************************************************************
                if ((controllerMode != StepMod.MANUEL_MOD) && (controllerMode != StepMod.KALIBRASYON_MODU))
                {
                    //PASİF,MANUEL VE KALİBRASYON HARİCİ MODLAR****************
                    Static.SetVisibleControl(true, BtnAyarlariUygula, LblYon, LblYon_, CmbBxYon, LblHiz, LblHiz_, NumUpDwnHiz);
                    Static.SetVisibleControl(false, BtnEnable, BtnDirection, BtnPulse, LblDerece, LblDrece_, NumUpDwnDerece);
                    //*********************************************************
                    if ((controllerMode != StepMod.STANDART_MOD) && (controllerMode != StepMod.TETIKLEMELI_MOD))
                    {
                        //DERECE GEREKTİREN MODLAR*****************************
                        Static.SetVisibleControl(true, LblDerece, LblDrece_, NumUpDwnDerece);
                        //*****************************************************
                    }
                }
                else if (controllerMode == StepMod.MANUEL_MOD)
                {
                    //MANUEL MOD***********************************************
                    Static.SetVisibleControl(true, BtnEnable, BtnDirection, BtnPulse);
                    Static.SetVisibleControl(false, BtnAyarlariUygula, BtnCalis, LblYon, LblYon_, CmbBxYon, LblHiz, LblHiz_, NumUpDwnHiz, LblDerece, LblDrece_, NumUpDwnDerece);
                    //*********************************************************
                }
                else if (controllerMode == StepMod.KALIBRASYON_MODU)
                {
                    //KALİBRASYON MODU******************************************
                    Static.SetVisibleControl(false, BtnAyarlariUygula, BtnCalis, LblYon, LblYon_, CmbBxYon, LblHiz, LblHiz_, NumUpDwnHiz, LblDerece, LblDrece_, NumUpDwnDerece, BtnEnable, BtnDirection, BtnPulse);
                    //**********************************************************
                }
            }
            //TETİKLEMELİ MODLAR************************************************
            if (controllerMode == StepMod.TETIKLEMELI_MOD || controllerMode == StepMod.TETIKLEMELI_ACI_SINIRLI_MOD || controllerMode == StepMod.TEK_YONLU_TETIKLEMELI_ACI_SINIRLI_MOD)
            {
                Static.SetVisibleControl(true, BtnCalis);
            }
            //*******************************************************************
            //TETİKLEMESİZ MODLAR************************************************
            else
            {
                Static.SetVisibleControl(false, BtnCalis);
            }

            ButtonFromStepMod(controllerMode).BackColor = Color.YellowGreen;
        }

        private Button ButtonFromStepMod (StepMod stepMod)
        {
            switch (stepMod)
            {
                case StepMod.STANDART_MOD: return BtnStandartMod;

                case StepMod.TETIKLEMELI_MOD: return BtnTetiklemeliMod;

                case StepMod.ACI_SINIRLI_MOD: return BtnSinirliAciMod;

                case StepMod.TETIKLEMELI_ACI_SINIRLI_MOD: return BtnTetiklemeliSinirliAciMod;

                case StepMod.TEK_YONLU_TETIKLEMELI_ACI_SINIRLI_MOD: return BtnTekYonTetiklemeliSinirliAciMod;

                case StepMod.MANUEL_MOD: return BtnManuelMod;

                case StepMod.KALIBRASYON_MODU: return BtnKalibrasyonMod;

                case StepMod.PASSIVE_MOD:
                default:
                    return BtnReConnect;
            }
        }
   

        private void BtnCalisPBox_MouseEnter(object sender, EventArgs e)
        {
            if (controller.Power == StepPower.STEP_ACTIVE)
                ((PictureBox)sender).Image = STM32_STEP_CONTROLLER_USER_INTERFACE.Properties.Resources.stopbutton_active;
            else
                ((PictureBox)sender).Image = STM32_STEP_CONTROLLER_USER_INTERFACE.Properties.Resources.playbutton_active;
        }

        private void BtnCalisPBox_MouseLeave(object sender, EventArgs e)
        {
            if (controller.Power == StepPower.STEP_ACTIVE)
                ((PictureBox)sender).Image = STM32_STEP_CONTROLLER_USER_INTERFACE.Properties.Resources.stopbutton_passive;
            else
                ((PictureBox)sender).Image = STM32_STEP_CONTROLLER_USER_INTERFACE.Properties.Resources.playbutton_passive;
        }

        private void BtnCalis_Click(object sender, EventArgs e)
        {
            controller.TooglePower();
            BtnCalis_ReSetVisual();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnExitPBox_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).Image = STM32_STEP_CONTROLLER_USER_INTERFACE.Properties.Resources.exitred;
        }

        private void BtnExitPBox_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).Image = STM32_STEP_CONTROLLER_USER_INTERFACE.Properties.Resources.exitblue;
        }

        private void BtnDirection_Click(object sender, EventArgs e)
        {
            controller.ToogleDirection();
            ((Button)sender).BackgroundImage = controller.Direction == StepDirection.CLOCKWISE ? STM32_STEP_CONTROLLER_USER_INTERFACE.Properties.Resources.clockwise : STM32_STEP_CONTROLLER_USER_INTERFACE.Properties.Resources.anticlockwise;
            //controller.SendManuelCommand(pulse: false);
        }

        private void BtnEnable_Click(object sender, EventArgs e)
        {
            controller.TooglePower();
            BtnEnable_ReSetVisual();
            //controller.SendManuelCommand(pulse: false);
        }

        private void BtnCalis_ReSetVisual()
        {
            BtnCalis.Image = controller.Power == StepPower.STEP_ACTIVE ? STM32_STEP_CONTROLLER_USER_INTERFACE.Properties.Resources.stopbutton_passive : BtnCalis.Image = STM32_STEP_CONTROLLER_USER_INTERFACE.Properties.Resources.playbutton_passive;
        }

        private void BtnEnable_ReSetVisual()
        {
            BtnEnable.BackColor = controller.Power == StepPower.STEP_ACTIVE ? Color.YellowGreen : Color.DarkGray;
        }

        private void BtnPulse_Click(object sender, EventArgs e)
        {
            controller.SendManuelCommand(pulse:true);
        }

        private void BtnAyarlariUygula_Click(object sender, EventArgs e)
        {
            controller.ChangeDirection(CmbBxYon.SelectedIndex == 0 ? StepDirection.CLOCKWISE : StepDirection.ANTICLOCKWISE);
            controller.ChangeSpeed((ushort)NumUpDwnHiz.Value);
            controller.ChangeDegree((ushort)NumUpDwnDerece.Value);
            controller.uart.SendSerialCommand(command: CommunicationStrings.CFR);

            LblYon.Text = controller.Direction.ToString();
            LblHiz.Text = controller.GetSpeed().ToString();
            LblDerece.Text = controller.GetDegree().ToString();
        }

        private void ModeSelect_Load(object sender, EventArgs e)
        {
            CmbBxYon.SelectedIndex = 0;
        }

        private void ModeSelect_FormClosing(object sender, FormClosingEventArgs e)
        {
            controller.ChangeMod(StepMod.PASSIVE_MOD);
            controller.uart.serialPort.Close();
        }

        private void Tmr1000MS_Tick(object sender, EventArgs e)
        {
            controller.SendConnectionTestCommand();
        }

        private void BtnPassiveMod_Click(object sender, EventArgs e)
        {
            controller.uart.serialPort.Close();

            controller.CreteUart(portName: portName, baundRate: baundRate, parity: parity, dataBit: dataBits);
            controller.uart.serialPort.Open();

            controller.ChangeMod(StepMod.PASSIVE_MOD);
            ModButtonReChangeFormVisual();
        }

        private void BtnNewSerial_Click(object sender, EventArgs e)
        {
            //SelectPortProperties spp = new SelectPortProperties();
            //spp.Show();

            string ProgramPath = @"C:\Program Files\SADUN\Design Project.exe";
            System.Diagnostics.Process newMirrorProgram = new System.Diagnostics.Process();
            newMirrorProgram.StartInfo.FileName = ProgramPath;
            newMirrorProgram.Start();
        }
    }
}
