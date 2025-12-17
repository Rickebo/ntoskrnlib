using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WHEAP_ERROR_SOURCE")]
    public sealed class WheapErrorSource : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ListEntry { get => ReadStructure<ListEntry>(nameof(ListEntry)); set => WriteStructure(nameof(ListEntry), value); }

        [Offset(16UL)]
        public uint FailedAllocations { get => ReadHere<uint>(nameof(FailedAllocations)); set => WriteHere(nameof(FailedAllocations), value); }

        [Offset(20UL)]
        public uint PlatformErrorSourceId { get => ReadHere<uint>(nameof(PlatformErrorSourceId)); set => WriteHere(nameof(PlatformErrorSourceId), value); }

        [Offset(24UL)]
        public int ErrorCount { get => ReadHere<int>(nameof(ErrorCount)); set => WriteHere(nameof(ErrorCount), value); }

        [Offset(28UL)]
        public uint RecordCount { get => ReadHere<uint>(nameof(RecordCount)); set => WriteHere(nameof(RecordCount), value); }

        [Offset(32UL)]
        public uint RecordLength { get => ReadHere<uint>(nameof(RecordLength)); set => WriteHere(nameof(RecordLength), value); }

        [Offset(36UL)]
        public uint PoolTag { get => ReadHere<uint>(nameof(PoolTag)); set => WriteHere(nameof(PoolTag), value); }

        [Offset(40UL)]
        public uint Type { get => ReadHere<uint>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(48UL)]
        public IntPtr Records { get => ReadHere<IntPtr>(nameof(Records)); set => WriteHere(nameof(Records), value); }

        [Offset(56UL)]
        public IntPtr Context { get => ReadHere<IntPtr>(nameof(Context)); set => WriteHere(nameof(Context), value); }

        [Offset(64UL)]
        public uint SectionCount { get => ReadHere<uint>(nameof(SectionCount)); set => WriteHere(nameof(SectionCount), value); }

        [Offset(68UL)]
        public uint SectionLength { get => ReadHere<uint>(nameof(SectionLength)); set => WriteHere(nameof(SectionLength), value); }

        [Offset(72UL)]
        public LargeInteger TickCountAtLastError { get => ReadStructure<LargeInteger>(nameof(TickCountAtLastError)); set => WriteStructure(nameof(TickCountAtLastError), value); }

        [Offset(80UL)]
        public uint AccumulatedErrors { get => ReadHere<uint>(nameof(AccumulatedErrors)); set => WriteHere(nameof(AccumulatedErrors), value); }

        [Offset(84UL)]
        public uint TotalErrors { get => ReadHere<uint>(nameof(TotalErrors)); set => WriteHere(nameof(TotalErrors), value); }

        [Offset(88UL)]
        public byte Deferred { get => ReadHere<byte>(nameof(Deferred)); set => WriteHere(nameof(Deferred), value); }

        [Offset(92UL)]
        public int Busy { get => ReadHere<int>(nameof(Busy)); set => WriteHere(nameof(Busy), value); }

        [Offset(96UL)]
        public WheaErrorSourceDescriptor Descriptor { get => ReadStructure<WheaErrorSourceDescriptor>(nameof(Descriptor)); set => WriteStructure(nameof(Descriptor), value); }

        public WheapErrorSource(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheapErrorSource>();
        }
    }
}