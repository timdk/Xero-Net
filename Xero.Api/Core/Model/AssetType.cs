using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Xero.Api.Common;

namespace Xero.Api.Core.Model
{
    public class AssetType : CoreData
    {

        [DataMember(EmitDefaultValue = false)]
        public Guid AssetTypeId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string AssetTypeName { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string FixedAssetAccountId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string DepreciationExpenseAccountId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string AccumulatedDepreciationAccountId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public BookDepreciationSetting BookDepreciationSetting { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int Locks { get; set; }
        


    }
}
