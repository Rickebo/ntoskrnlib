using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_HANDLE_TABLE_ENTRY_INFO")]
    public sealed class HandleTableEntryInfo : DynamicStructure
    {
        [Offset(0UL)]
        public uint AuditMask { get => ReadHere<uint>(nameof(AuditMask)); set => WriteHere(nameof(AuditMask), value); }

        [Offset(4UL)]
        public uint MaxRelativeAccessMask { get => ReadHere<uint>(nameof(MaxRelativeAccessMask)); set => WriteHere(nameof(MaxRelativeAccessMask), value); }

        public HandleTableEntryInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HandleTableEntryInfo>();
        }
    }
}