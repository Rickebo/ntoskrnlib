using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_STACK_TABLE")]
    public sealed class StackTable : DynamicStructure
    {
        [Offset(0UL)]
        public ushort NumStackTraces { get => ReadHere<ushort>(nameof(NumStackTraces)); set => WriteHere(nameof(NumStackTraces), value); }

        [Offset(2UL)]
        public ushort TraceCapacity { get => ReadHere<ushort>(nameof(TraceCapacity)); set => WriteHere(nameof(TraceCapacity), value); }

        [Offset(8UL)]
        [Length(16)]
        public DynamicArray StackTrace { get => ReadStructure<DynamicArray>(nameof(StackTrace)); set => WriteStructure(nameof(StackTrace), value); }

        [Offset(136UL)]
        [Length(16381)]
        public DynamicArray StackTableHash { get => ReadStructure<DynamicArray>(nameof(StackTableHash)); set => WriteStructure(nameof(StackTableHash), value); }

        public StackTable(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<StackTable>();
        }
    }
}