using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_STORAGE_SECURITY_COMPLIANCE_BITMASK")]
    public sealed class StorageSecurityComplianceBitmask : DynamicStructure
    {
        [Offset(0UL)]
        public byte FIPS { get => ReadHere<byte>(nameof(FIPS)); set => WriteHere(nameof(FIPS), value); }

        [Offset(0UL)]
        public byte Reserved { get => ReadHere<byte>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(0UL)]
        public byte AsUchar { get => ReadHere<byte>(nameof(AsUchar)); set => WriteHere(nameof(AsUchar), value); }

        public StorageSecurityComplianceBitmask(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<StorageSecurityComplianceBitmask>();
        }
    }
}