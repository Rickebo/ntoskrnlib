using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_INTERRUPT_TRACKING_ENTRY")]
    public sealed class InterruptTrackingEntry : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ListEntry { get => ReadStructure<ListEntry>(nameof(ListEntry)); set => WriteStructure(nameof(ListEntry), value); }

        [Offset(16UL)]
        public IntPtr IntTrackRoot { get => ReadHere<IntPtr>(nameof(IntTrackRoot)); set => WriteHere(nameof(IntTrackRoot), value); }

        [Offset(24UL)]
        public uint InterruptObjectCount { get => ReadHere<uint>(nameof(InterruptObjectCount)); set => WriteHere(nameof(InterruptObjectCount), value); }

        [Offset(32UL)]
        public IntPtr InterruptObjectArray { get => ReadHere<IntPtr>(nameof(InterruptObjectArray)); set => WriteHere(nameof(InterruptObjectArray), value); }

        [Offset(40UL)]
        public ulong IsrTime { get => ReadHere<ulong>(nameof(IsrTime)); set => WriteHere(nameof(IsrTime), value); }

        [Offset(48UL)]
        public ulong DpcTime { get => ReadHere<ulong>(nameof(DpcTime)); set => WriteHere(nameof(DpcTime), value); }

        [Offset(56UL)]
        public byte IsPrimaryInterrupt { get => ReadHere<byte>(nameof(IsPrimaryInterrupt)); set => WriteHere(nameof(IsPrimaryInterrupt), value); }

        [Offset(64UL)]
        public InterruptVectorData VectorData { get => ReadStructure<InterruptVectorData>(nameof(VectorData)); set => WriteStructure(nameof(VectorData), value); }

        public InterruptTrackingEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<InterruptTrackingEntry>();
        }
    }
}