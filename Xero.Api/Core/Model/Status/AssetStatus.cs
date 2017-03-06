using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Xero.Api.Core.Model.Status
{
    [DataContract(Namespace = "")]
    public enum AssetStatus
    {
        [EnumMember(Value = "ACTIVE")]
        Draft,
        [EnumMember(Value = "REGISTERED")]
        Registered,
        [EnumMember(Value = "DISPOSED")]
        Disposed
    }
}
