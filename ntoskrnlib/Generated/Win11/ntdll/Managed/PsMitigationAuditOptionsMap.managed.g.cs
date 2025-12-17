using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_PS_MITIGATION_AUDIT_OPTIONS_MAP")]
    public sealed class PsMitigationAuditOptionsMap : DynamicStructure
    {
        [Offset(0UL)]
        [Length(3)]
        public DynamicArray Map { get => ReadStructure<DynamicArray>(nameof(Map)); set => WriteStructure(nameof(Map), value); }

        public PsMitigationAuditOptionsMap(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PsMitigationAuditOptionsMap>();
        }
    }
}