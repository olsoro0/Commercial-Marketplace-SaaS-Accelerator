﻿using System;

namespace Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities
{
    public partial class ValueTypes
    {
        public int ValueTypeId { get; set; }
        public string ValueType { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Htmltype { get; set; }
    }
}
