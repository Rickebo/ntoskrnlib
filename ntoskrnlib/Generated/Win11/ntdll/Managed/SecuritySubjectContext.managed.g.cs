using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_SECURITY_SUBJECT_CONTEXT")]
    public sealed class SecuritySubjectContext : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr ClientToken { get => ReadHere<IntPtr>(nameof(ClientToken)); set => WriteHere(nameof(ClientToken), value); }

        [Offset(8UL)]
        public uint ImpersonationLevel { get => ReadHere<uint>(nameof(ImpersonationLevel)); set => WriteHere(nameof(ImpersonationLevel), value); }

        [Offset(16UL)]
        public IntPtr PrimaryToken { get => ReadHere<IntPtr>(nameof(PrimaryToken)); set => WriteHere(nameof(PrimaryToken), value); }

        [Offset(24UL)]
        public IntPtr ProcessAuditId { get => ReadHere<IntPtr>(nameof(ProcessAuditId)); set => WriteHere(nameof(ProcessAuditId), value); }

        public SecuritySubjectContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SecuritySubjectContext>();
        }
    }
}