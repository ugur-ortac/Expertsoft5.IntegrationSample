﻿namespace Expertsoft5.IntegrationSample.Request
{
    public class WorkResponse
    {
        public virtual string? CustomNumber { get; set; } //Required (Work Result Will Return Same Number)
        public virtual string? PackageName { get; set; }
        public virtual string? PackageContent { get; set; }
        public virtual float PackagePay { get; set; }
        public virtual float Plate { get; set; } //Required
        public virtual string? Image1 { get; set; }
        public virtual string? Image2 { get; set; }
        public virtual string? Brand { get; set; }
        public virtual string? Model { get; set; }
        public virtual string? ChassisNumber { get; set; }
        public virtual int Year { get; set; }
        public virtual string? CarType { get; set; } //Required Dyno
        public virtual string? TransmissionType { get; set; } //Required Dyno
        public virtual string? EngineNumber { get; set; }
        public virtual string? FuelType { get; set; } //Required Dyno
        public virtual int CarKm { get; set; }
        public virtual string? CarCase { get; set; } //Required Paint
        public virtual int EngineHP { get; set; } //Required Dyno
        public virtual string? ParentName { get; set; }
        public virtual string? ParentPhone { get; set; }
        public virtual string? ParentCompany { get; set; }
        public virtual string? SellerName { get; set; }
        public virtual string? SellerPhone { get; set; }
        public virtual string? SellerCompany { get; set; }
        public virtual string? RecipientName { get; set; }
        public virtual string? RecipientPhone { get; set; }
        public virtual string? RecipientCompany { get; set; }
    }
}
