using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PALPC_PORT_REFERENCE_WAIT_BLOCK")]
    public sealed class PalpcPortReferenceWaitBlock : DynamicStructure
    {
        [Offset(0UL)]
        public Kevent DesiredReferenceNoEvent { get => ReadStructure<Kevent>(nameof(DesiredReferenceNoEvent)); set => WriteStructure(nameof(DesiredReferenceNoEvent), value); }

        [Offset(24UL)]
        public int DesiredReferenceNo { get => ReadHere<int>(nameof(DesiredReferenceNo)); set => WriteHere(nameof(DesiredReferenceNo), value); }

        public PalpcPortReferenceWaitBlock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PalpcPortReferenceWaitBlock>();
        }
    }
}