using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_HANDLE_TRACE_DEBUG_INFO")]
    public sealed class HandleTraceDebugInfo : DynamicStructure
    {
        [Offset(0UL)]
        public int RefCount { get => ReadHere<int>(nameof(RefCount)); set => WriteHere(nameof(RefCount), value); }

        [Offset(4UL)]
        public uint TableSize { get => ReadHere<uint>(nameof(TableSize)); set => WriteHere(nameof(TableSize), value); }

        [Offset(8UL)]
        public uint BitMaskFlags { get => ReadHere<uint>(nameof(BitMaskFlags)); set => WriteHere(nameof(BitMaskFlags), value); }

        [Offset(16UL)]
        public FastMutex CloseCompactionLock { get => ReadStructure<FastMutex>(nameof(CloseCompactionLock)); set => WriteStructure(nameof(CloseCompactionLock), value); }

        [Offset(72UL)]
        public uint CurrentStackIndex { get => ReadHere<uint>(nameof(CurrentStackIndex)); set => WriteHere(nameof(CurrentStackIndex), value); }

        [Offset(80UL)]
        [Length(1)]
        public DynamicArray TraceDb { get => ReadStructure<DynamicArray>(nameof(TraceDb)); set => WriteStructure(nameof(TraceDb), value); }

        public HandleTraceDebugInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HandleTraceDebugInfo>();
        }
    }
}