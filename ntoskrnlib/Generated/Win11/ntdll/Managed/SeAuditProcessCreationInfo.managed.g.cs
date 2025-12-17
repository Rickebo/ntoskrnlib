using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_SE_AUDIT_PROCESS_CREATION_INFO")]
    public sealed class SeAuditProcessCreationInfo : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr ImageFileName { get => ReadHere<IntPtr>(nameof(ImageFileName)); set => WriteHere(nameof(ImageFileName), value); }

        public SeAuditProcessCreationInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SeAuditProcessCreationInfo>();
        }
    }
}