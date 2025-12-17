using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_OBJECT_HEADER_AUDIT_INFO")]
    public sealed class ObjectHeaderAuditInfo : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr SecurityDescriptor { get => ReadHere<IntPtr>(nameof(SecurityDescriptor)); set => WriteHere(nameof(SecurityDescriptor), value); }

        [Offset(8UL)]
        public ulong Reserved { get => ReadHere<ulong>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        public ObjectHeaderAuditInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ObjectHeaderAuditInfo>();
        }
    }
}