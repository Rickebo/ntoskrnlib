using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_DPH_BLOCK_INFORMATION")]
    public sealed class DphBlockInformation : DynamicStructure
    {
        [Offset(0UL)]
        public uint StartStamp { get => ReadHere<uint>(nameof(StartStamp)); set => WriteHere(nameof(StartStamp), value); }

        [Offset(8UL)]
        public IntPtr Heap { get => ReadHere<IntPtr>(nameof(Heap)); set => WriteHere(nameof(Heap), value); }

        [Offset(16UL)]
        public ulong RequestedSize { get => ReadHere<ulong>(nameof(RequestedSize)); set => WriteHere(nameof(RequestedSize), value); }

        [Offset(24UL)]
        public ulong ActualSize { get => ReadHere<ulong>(nameof(ActualSize)); set => WriteHere(nameof(ActualSize), value); }

        [Offset(32UL)]
        public ListEntry FreeQueue { get => ReadStructure<ListEntry>(nameof(FreeQueue)); set => WriteStructure(nameof(FreeQueue), value); }

        [Offset(32UL)]
        public SlistEntry FreePushList { get => ReadStructure<SlistEntry>(nameof(FreePushList)); set => WriteStructure(nameof(FreePushList), value); }

        [Offset(32UL)]
        public ushort TraceIndex { get => ReadHere<ushort>(nameof(TraceIndex)); set => WriteHere(nameof(TraceIndex), value); }

        [Offset(48UL)]
        public IntPtr StackTrace { get => ReadHere<IntPtr>(nameof(StackTrace)); set => WriteHere(nameof(StackTrace), value); }

        [Offset(56UL)]
        public uint Padding { get => ReadHere<uint>(nameof(Padding)); set => WriteHere(nameof(Padding), value); }

        [Offset(60UL)]
        public uint EndStamp { get => ReadHere<uint>(nameof(EndStamp)); set => WriteHere(nameof(EndStamp), value); }

        public DphBlockInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DphBlockInformation>();
        }
    }
}