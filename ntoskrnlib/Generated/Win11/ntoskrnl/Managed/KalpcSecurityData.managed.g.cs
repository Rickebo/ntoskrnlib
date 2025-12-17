using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KALPC_SECURITY_DATA")]
    public sealed class KalpcSecurityData : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr HandleTable { get => ReadHere<IntPtr>(nameof(HandleTable)); set => WriteHere(nameof(HandleTable), value); }

        [Offset(8UL)]
        public IntPtr ContextHandle { get => ReadHere<IntPtr>(nameof(ContextHandle)); set => WriteHere(nameof(ContextHandle), value); }

        [Offset(16UL)]
        public IntPtr OwningProcess { get => ReadHere<IntPtr>(nameof(OwningProcess)); set => WriteHere(nameof(OwningProcess), value); }

        [Offset(24UL)]
        public IntPtr OwnerPort { get => ReadHere<IntPtr>(nameof(OwnerPort)); set => WriteHere(nameof(OwnerPort), value); }

        [Offset(32UL)]
        public SecurityClientContext DynamicSecurity { get => ReadStructure<SecurityClientContext>(nameof(DynamicSecurity)); set => WriteStructure(nameof(DynamicSecurity), value); }

        [Offset(104UL)]
        public UnnamedTag u1 { get => ReadStructure<UnnamedTag>(nameof(u1)); set => WriteStructure(nameof(u1), value); }

        public KalpcSecurityData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KalpcSecurityData>();
        }
    }
}