namespace Expertsoft5.IntegrationSample.Request
{
    public class WorkResultRequest
    {
        public virtual string? CustomNumber { get; set; }
        public virtual double SuspLeftKgAks0 { get; set; }
        public virtual double SuspRightKgAks0 { get; set; }
        public virtual double SuspLeftKgAks1 { get; set; }
        public virtual double SuspRightKgAks1 { get; set; }
        public virtual double SuspLeftEfficiencyAks0 { get; set; }
        public virtual double SuspRightEfficiencyAks0 { get; set; }
        public virtual double SuspLeftEfficiencyAks1 { get; set; }
        public virtual double SuspRightEfficiencyAks1 { get; set; }

        public virtual string? SuspFrontLeftGraph0 { get; set; } //Png_Base64
        public virtual string? SuspFrontRightGraph0 { get; set; } //Png_Base64
        public virtual string? SuspFrontLeftGraph1 { get; set; } //Png_Base64
        public virtual string? SuspFrontRightGraph1 { get; set; } //Png_Base64

        //BRAKE

        public virtual double BrakeLeftKnAks0 { get; set; }
        public virtual double BrakeRightKnAks0 { get; set; }
        public virtual double BrakeLeftPerAks0 { get; set; }
        public virtual double BrakeRightPerAks0 { get; set; }
        public virtual double BrakeDeflectAks0 { get; set; }
        public virtual double BrakeLeftKnAks1 { get; set; }
        public virtual double BrakeRightKnAks1 { get; set; }
        public virtual double BrakeLeftPerAks1 { get; set; }
        public virtual double BrakeRightPerAks1 { get; set; }
        public virtual double BrakeDeflectAks1 { get; set; }
        public virtual double BrakeLeftKnAks2 { get; set; }
        public virtual double BrakeRightKnAks2 { get; set; }
        public virtual double BrakeLeftPerAks2 { get; set; }
        public virtual double BrakeRightPerAks2 { get; set; }
        public virtual double BrakeDeflectAks2 { get; set; }

        public virtual string? BrakeFrontLeftGraph0 { get; set; } //Png_Base64
        public virtual string? BrakeFrontRightGraph0 { get; set; } //Png_Base64
        public virtual string? BrakeFrontLeftGraph1 { get; set; } //Png_Base64
        public virtual string? BrakeFrontRightGraph1 { get; set; } //Png_Base64
        public virtual string? BrakeFrontLeftGraph2 { get; set; } //Png_Base64
        public virtual string? BrakeFrontRightGraph2 { get; set; } //Png_Base64


        //SHIFT

        public virtual double ShiftFrontMax { get; set; }
        public virtual double ShiftRearMax { get; set; }
        public virtual string? ShiftFrontPosition { get; set; }
        public virtual string? ShiftRearPosition { get; set; }

        public virtual string? ShiftFrontGraph { get; set; } //Png_Base64
        public virtual string? ShiftRearGraph { get; set; } //Png_Base64

        //DYNO

        public virtual double DynoRatio { get; set; }
        public virtual double DynoFactoryHp { get; set; }
        public virtual double DynoTotalHp { get; set; }
        public virtual double DynoTemprature { get; set; }
        public virtual double DynoPressure { get; set; }
        public virtual double DynoHumidity { get; set; }
        public virtual double DynoMaximumSpeed { get; set; }
        public virtual double DynoMaximumRpm { get; set; }
        public virtual double DynoMaximumHp { get; set; }
        public virtual double DynoMaximumHpRpm { get; set; }
        public virtual double DynoMaximumTorque { get; set; }
        public virtual double DynoMaximumTorqueRpm { get; set; }
        public virtual double DynoMaximumLossHp { get; set; }

        public virtual string? DynoGraph { get; set; } //Png_Base64
        public virtual string? DynoPerformaceGraph { get; set; } //Png_Base64
    }
}
