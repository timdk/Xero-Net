using System;
using System.Runtime.Serialization;
using Xero.Api.Common;
using Xero.Api.Core.Model.Status;

namespace Xero.Api.Core.Model
{
    [DataContract(Namespace = "")]
    public class Asset : CoreData, IHasId
    {
        [DataMember(Name = "AssetID", EmitDefaultValue = false)]
        public Guid Id { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string AssetName { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string AssetNumber { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public DateTime PurchaseDate { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int PurchasePrice { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string SerialNumber { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public DateTime WarrantyExpiryDate { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string AssetTypeId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Description { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int DisposalPrice { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public AssetStatus AssetStatus { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public BookDepreciationSetting bookDepreciationSetting { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public BookDepreciationDetail bookDepreciationDetail { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public bool CanRollback { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int AccountingBookValue { get; set; }

    }
    [DataContract(Namespace = "")]
    public class BookDepreciationSetting
    {
        [DataMember(EmitDefaultValue = false)]
        public string DepreciationMethod { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string AveragingMethod { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int DepreciationRate { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string DepreciationCalculationMethod { get; set; }
    }

    [DataContract(Namespace = "")]
    public class BookDepreciationDetail
    {
        [DataMember(EmitDefaultValue = false)]
        public int CurrentCapitalGain { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int CurrentGainLoss { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public DateTime DepreciationStartDate { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int PriorAccumDepreciationAmount { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int CurrentAccumDepreciationAmount { get; set; }
    }
}