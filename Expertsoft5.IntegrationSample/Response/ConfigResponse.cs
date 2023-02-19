using Microsoft.VisualBasic;
using System.Numerics;
using System.Runtime.Intrinsics.X86;

namespace Expertsoft5.IntegrationSample.Request
{
    public class ConfigResponse
    {
        public string? BannerImage { get; set; }
        public string? LogoImage { get; set; }
        public bool WorkRestrict { get; set; }
        public bool WorkWarning { get; set; }
        public string? WorkWarningText { get; set; }
        public string? WorkWarningUrl { get; set; }
        public byte QueueeCount { get; set; }
        public bool TSEMode { get; set; }
        public bool FullAccess { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Adress { get; set; }
        public string? TSECode { get; set; }
        public bool AutomaticMeasurementStart { get; set; }
        public bool SoundNotification { get; set; }
        public byte LanguageIndex { get; set; }
        public byte HardwareIndex { get; set; }
    }
}
