using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Project
{
    public enum StepMod
    {
        PASSIVE_MOD,
        STANDART_MOD,
        TETIKLEMELI_MOD,
        ACI_SINIRLI_MOD,
        TETIKLEMELI_ACI_SINIRLI_MOD,
        TEK_YONLU_TETIKLEMELI_ACI_SINIRLI_MOD,
        MANUEL_MOD,
        KALIBRASYON_MODU
    }

    public enum StepPower
    {
        STEP_ACTIVE,
        STEP_PASSIVE
    }

    public enum StepDirection
    {
        CLOCKWISE,
        ANTICLOCKWISE
    }

    public enum CommunicationStrings
    {
        /// <summary>
        /// False Command
        /// </summary>
        ERR = 0,
        /// <summary>
        /// Confirm Settings
        /// </summary>
        CFR = 1,
        /// <summary>
        /// Mode Select Command
        /// </summary>
        MOD,
        /// <summary>
        /// Speeed Value
        /// </summary>
        SPD,
        /// <summary>
        /// Degree Value
        /// </summary>
        DEG,
        /// <summary>
        /// Start Signal
        /// </summary>
        RUN,
        /// <summary>
        /// Stop Signal
        /// </summary>
        STP,
        /// <summary>
        /// Direction ClockWise
        /// </summary>
        DCL,
        /// <summary>
        /// Direction Anti-ClockWise
        /// </summary>
        DAC,
        /// <summary>
        /// Standart Mode
        /// </summary>
        STD,
        /// <summary>
        /// Pulse Triggered Standart Mode
        /// </summary>
        PST,
        /// <summary>
        /// Limited Angle Mod
        /// </summary>
        DGR,
        /// <summary>
        /// Pulse Triggered Limited Angle Mod
        /// </summary>
        PDG,
        /// <summary>
        /// One Direction Pulse Triggered Limited Angle Mod
        /// </summary>
        OPD,
        /// <summary>
        /// Manual Mode
        /// </summary>
        MAN,
        /// <summary>
        /// Calibration Mode
        /// </summary>
        CLB,
        /// <summary>
        /// Passive Mode
        /// </summary>
        PSV,
        /// <summary>
        /// Test Connection
        /// </summary>
        TST
    }
}
