using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WNF_STATE_NAME_REGISTRATION")]
    public sealed class WnfStateNameRegistration : DynamicStructure
    {
        [Offset(0UL)]
        public uint MaxStateSize { get => ReadHere<uint>(nameof(MaxStateSize)); set => WriteHere(nameof(MaxStateSize), value); }

        [Offset(8UL)]
        public IntPtr TypeId { get => ReadHere<IntPtr>(nameof(TypeId)); set => WriteHere(nameof(TypeId), value); }

        [Offset(16UL)]
        public IntPtr SecurityDescriptor { get => ReadHere<IntPtr>(nameof(SecurityDescriptor)); set => WriteHere(nameof(SecurityDescriptor), value); }

        public WnfStateNameRegistration(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WnfStateNameRegistration>();
        }
    }
}