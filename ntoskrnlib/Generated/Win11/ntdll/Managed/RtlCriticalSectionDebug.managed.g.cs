using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_RTL_CRITICAL_SECTION_DEBUG")]
    public sealed class RtlCriticalSectionDebug : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Type { get => ReadHere<ushort>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(2UL)]
        public ushort CreatorBackTraceIndex { get => ReadHere<ushort>(nameof(CreatorBackTraceIndex)); set => WriteHere(nameof(CreatorBackTraceIndex), value); }

        [Offset(8UL)]
        public IntPtr CriticalSection { get => ReadHere<IntPtr>(nameof(CriticalSection)); set => WriteHere(nameof(CriticalSection), value); }

        [Offset(16UL)]
        public ListEntry ProcessLocksList { get => ReadStructure<ListEntry>(nameof(ProcessLocksList)); set => WriteStructure(nameof(ProcessLocksList), value); }

        [Offset(32UL)]
        public uint EntryCount { get => ReadHere<uint>(nameof(EntryCount)); set => WriteHere(nameof(EntryCount), value); }

        [Offset(36UL)]
        public uint ContentionCount { get => ReadHere<uint>(nameof(ContentionCount)); set => WriteHere(nameof(ContentionCount), value); }

        [Offset(40UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(44UL)]
        public ushort CreatorBackTraceIndexHigh { get => ReadHere<ushort>(nameof(CreatorBackTraceIndexHigh)); set => WriteHere(nameof(CreatorBackTraceIndexHigh), value); }

        [Offset(46UL)]
        public ushort Identifier { get => ReadHere<ushort>(nameof(Identifier)); set => WriteHere(nameof(Identifier), value); }

        public RtlCriticalSectionDebug(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlCriticalSectionDebug>();
        }
    }
}