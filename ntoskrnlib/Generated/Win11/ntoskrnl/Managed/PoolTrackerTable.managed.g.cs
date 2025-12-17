using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POOL_TRACKER_TABLE")]
    public sealed class PoolTrackerTable : DynamicStructure
    {
        [Offset(0UL)]
        public int Key { get => ReadHere<int>(nameof(Key)); set => WriteHere(nameof(Key), value); }

        [Offset(8UL)]
        public ulong NonPagedBytes { get => ReadHere<ulong>(nameof(NonPagedBytes)); set => WriteHere(nameof(NonPagedBytes), value); }

        [Offset(16UL)]
        public ulong NonPagedAllocs { get => ReadHere<ulong>(nameof(NonPagedAllocs)); set => WriteHere(nameof(NonPagedAllocs), value); }

        [Offset(24UL)]
        public ulong NonPagedFrees { get => ReadHere<ulong>(nameof(NonPagedFrees)); set => WriteHere(nameof(NonPagedFrees), value); }

        [Offset(32UL)]
        public ulong PagedBytes { get => ReadHere<ulong>(nameof(PagedBytes)); set => WriteHere(nameof(PagedBytes), value); }

        [Offset(40UL)]
        public ulong PagedAllocs { get => ReadHere<ulong>(nameof(PagedAllocs)); set => WriteHere(nameof(PagedAllocs), value); }

        [Offset(48UL)]
        public ulong PagedFrees { get => ReadHere<ulong>(nameof(PagedFrees)); set => WriteHere(nameof(PagedFrees), value); }

        [Offset(56UL)]
        [Length(2)]
        public DynamicArray AvailableLimit { get => ReadStructure<DynamicArray>(nameof(AvailableLimit)); set => WriteStructure(nameof(AvailableLimit), value); }

        [Offset(72UL)]
        public IntPtr LimitInfo { get => ReadHere<IntPtr>(nameof(LimitInfo)); set => WriteHere(nameof(LimitInfo), value); }

        public PoolTrackerTable(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PoolTrackerTable>();
        }
    }
}