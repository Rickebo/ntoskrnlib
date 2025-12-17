using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_HEAP_LFH_COMMIT_UNIT_INFO")]
    public sealed class HeapLfhCommitUnitInfo : DynamicStructure
    {
        [Offset(0UL)]
        public byte CommitUnitShift { get => ReadHere<byte>(nameof(CommitUnitShift)); set => WriteHere(nameof(CommitUnitShift), value); }

        [Offset(1UL)]
        public byte CommitUnitCount { get => ReadHere<byte>(nameof(CommitUnitCount)); set => WriteHere(nameof(CommitUnitCount), value); }

        [Offset(0UL)]
        public ushort UShort { get => ReadHere<ushort>(nameof(UShort)); set => WriteHere(nameof(UShort), value); }

        public HeapLfhCommitUnitInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapLfhCommitUnitInfo>();
        }
    }
}