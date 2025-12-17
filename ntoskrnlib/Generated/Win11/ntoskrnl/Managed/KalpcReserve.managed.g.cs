using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KALPC_RESERVE")]
    public sealed class KalpcReserve : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr OwnerPort { get => ReadHere<IntPtr>(nameof(OwnerPort)); set => WriteHere(nameof(OwnerPort), value); }

        [Offset(8UL)]
        public IntPtr HandleTable { get => ReadHere<IntPtr>(nameof(HandleTable)); set => WriteHere(nameof(HandleTable), value); }

        [Offset(16UL)]
        public IntPtr Handle { get => ReadHere<IntPtr>(nameof(Handle)); set => WriteHere(nameof(Handle), value); }

        [Offset(24UL)]
        public IntPtr Message { get => ReadHere<IntPtr>(nameof(Message)); set => WriteHere(nameof(Message), value); }

        [Offset(32UL)]
        public ulong Size { get => ReadHere<ulong>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(40UL)]
        public int Active { get => ReadHere<int>(nameof(Active)); set => WriteHere(nameof(Active), value); }

        public KalpcReserve(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KalpcReserve>();
        }
    }
}