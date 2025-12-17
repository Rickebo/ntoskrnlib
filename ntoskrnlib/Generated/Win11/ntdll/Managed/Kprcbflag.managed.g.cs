using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KPRCBFLAG")]
    public sealed class Kprcbflag : DynamicStructure
    {
        [Offset(0UL)]
        public int PrcbFlags { get => ReadHere<int>(nameof(PrcbFlags)); set => WriteHere(nameof(PrcbFlags), value); }

        [Offset(0UL)]
        public uint BamQosLevel { get => ReadHere<uint>(nameof(BamQosLevel)); set => WriteHere(nameof(BamQosLevel), value); }

        [Offset(0UL)]
        public uint PendingQosUpdate { get => ReadHere<uint>(nameof(PendingQosUpdate)); set => WriteHere(nameof(PendingQosUpdate), value); }

        [Offset(0UL)]
        public uint CacheIsolationEnabled { get => ReadHere<uint>(nameof(CacheIsolationEnabled)); set => WriteHere(nameof(CacheIsolationEnabled), value); }

        [Offset(0UL)]
        public uint TracepointActive { get => ReadHere<uint>(nameof(TracepointActive)); set => WriteHere(nameof(TracepointActive), value); }

        [Offset(0UL)]
        public uint LongDpcRunning { get => ReadHere<uint>(nameof(LongDpcRunning)); set => WriteHere(nameof(LongDpcRunning), value); }

        [Offset(0UL)]
        public uint PrcbFlagsReserved { get => ReadHere<uint>(nameof(PrcbFlagsReserved)); set => WriteHere(nameof(PrcbFlagsReserved), value); }

        public Kprcbflag(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Kprcbflag>();
        }
    }
}