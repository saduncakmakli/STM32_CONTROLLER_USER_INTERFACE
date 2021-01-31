using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Design_Project
{
    public static class Static
    {
        //C# 9.0
        //public static StepMod ButtonToStepModee(Button button) =>
        //            switch (button.Name)
        //    {
        //        "BtnStandartMod" => StepMod.STANDART_MOD,
        //        "BtnTetiklemeliMod" => StepMod.TETIKLEMELI_MOD,
        //        "BtnManuelMod" => StepMod.MANUEL_MOD,
        //        "BtnSinirliAciMod" => StepMod.ACI_SINIRLI_MOD,
        //        "BtnTetiklemeliSinirliAciMod" => StepMod.TETIKLEMELI_ACI_SINIRLI_MOD,
        //        "BtnTekYonTetiklemeliSinirliAciMod" => StepMod.TEK_YONLU_TETIKLEMELI_ACI_SINIRLI_MOD,
        //        "BtnKalibrasyonMod" => StepMod.KALIBRASYON_MODU
        //    };


        public static StepMod ButtonToStepMode(Button button)
        {
            switch (button.Name)
            {
                case "BtnStandartMod":
                    return StepMod.STANDART_MOD;
                case "BtnTetiklemeliMod":
                    return StepMod.TETIKLEMELI_MOD;
                case "BtnManuelMod":
                    return StepMod.MANUEL_MOD;
                case "BtnSinirliAciMod":
                    return StepMod.ACI_SINIRLI_MOD;
                case "BtnTetiklemeliSinirliAciMod":
                    return StepMod.TETIKLEMELI_ACI_SINIRLI_MOD;
                case "BtnTekYonTetiklemeliSinirliAciMod":
                    return StepMod.TEK_YONLU_TETIKLEMELI_ACI_SINIRLI_MOD;
                case "BtnKalibrasyonMod":
                    return StepMod.KALIBRASYON_MODU;
            }
            return StepMod.PASSIVE_MOD;
        }

        public static void SetVisibleControl(bool visible, params Control[] control)
        {
            foreach (Control c in control)
            {
                c.Visible = visible;
            }
        }

        public static void SetBackColorControl(Color color, params Control[] control)
        {
            foreach (Control c in control)
            {
                c.BackColor = color;
            }
        }

        public static Parity StringToParity(string parity)
        {
            switch (parity)
            {
                case "None":
                    return Parity.None;
                case "Even":
                    return Parity.Even;
                case "Odd":
                    return Parity.Odd;
                case "Mark":
                    return Parity.Mark;
                case "Space":
                    return Parity.Space;
                default:
                    return Parity.None;
            }
        }

        public static CommunicationStrings CommandFromStepMod(StepMod stepMod)
        {
            switch (stepMod)
            {
                case StepMod.PASSIVE_MOD:
                    return CommunicationStrings.PSV;
                case StepMod.STANDART_MOD:
                    return CommunicationStrings.STD;
                case StepMod.TETIKLEMELI_MOD:
                    return CommunicationStrings.PST;
                case StepMod.ACI_SINIRLI_MOD:
                    return CommunicationStrings.DGR;
                case StepMod.TETIKLEMELI_ACI_SINIRLI_MOD:
                    return CommunicationStrings.PDG;
                case StepMod.TEK_YONLU_TETIKLEMELI_ACI_SINIRLI_MOD:
                    return CommunicationStrings.OPD;
                case StepMod.KALIBRASYON_MODU:
                    return CommunicationStrings.CLB;
                case StepMod.MANUEL_MOD:
                    return CommunicationStrings.MAN;
                default: return CommunicationStrings.ERR;
            }
        }

        public static CommunicationStrings CommandFromStepDirection(StepDirection stepDirection)
        {
            switch (stepDirection)
            {
                case StepDirection.CLOCKWISE:
                    return CommunicationStrings.DCL;
                case StepDirection.ANTICLOCKWISE:
                    return CommunicationStrings.DAC;
                default: return CommunicationStrings.ERR;
            }
        }

        public static CommunicationStrings CommandFromStepPower(StepPower stepPower)
        {
            switch (stepPower)
            {
                case StepPower.STEP_ACTIVE:
                    return CommunicationStrings.RUN;
                case StepPower.STEP_PASSIVE:
                    return CommunicationStrings.STP;
                default: return CommunicationStrings.ERR;
            }
        }
    }
}
