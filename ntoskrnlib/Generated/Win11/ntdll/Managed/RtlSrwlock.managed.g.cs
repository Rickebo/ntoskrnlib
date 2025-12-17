using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_RTL_SRWLOCK")]
    public sealed class RtlSrwlock : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Locked { get => ReadHere<ulong>(nameof(Locked)); set => WriteHere(nameof(Locked), value); }

        [Offset(0UL)]
        public ulong Waiting { get => ReadHere<ulong>(nameof(Waiting)); set => WriteHere(nameof(Waiting), value); }

        [Offset(0UL)]
        public ulong Waking { get => ReadHere<ulong>(nameof(Waking)); set => WriteHere(nameof(Waking), value); }

        [Offset(0UL)]
        public ulong MultipleShared { get => ReadHere<ulong>(nameof(MultipleShared)); set => WriteHere(nameof(MultipleShared), value); }

        [Offset(0UL)]
        public ulong Shared { get => ReadHere<ulong>(nameof(Shared)); set => WriteHere(nameof(Shared), value); }

        [Offset(0UL)]
        public ulong Value { get => ReadHere<ulong>(nameof(Value)); set => WriteHere(nameof(Value), value); }

        [Offset(0UL)]
        public IntPtr Ptr { get => ReadHere<IntPtr>(nameof(Ptr)); set => WriteHere(nameof(Ptr), value); }

        public RtlSrwlock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlSrwlock>();
        }
    }
}