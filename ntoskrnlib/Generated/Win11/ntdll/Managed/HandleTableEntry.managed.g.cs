using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_HANDLE_TABLE_ENTRY")]
    public sealed class HandleTableEntry : DynamicStructure
    {
        [Offset(0UL)]
        public long VolatileLowValue { get => ReadHere<long>(nameof(VolatileLowValue)); set => WriteHere(nameof(VolatileLowValue), value); }

        [Offset(0UL)]
        public long LowValue { get => ReadHere<long>(nameof(LowValue)); set => WriteHere(nameof(LowValue), value); }

        [Offset(0UL)]
        public IntPtr InfoTable { get => ReadHere<IntPtr>(nameof(InfoTable)); set => WriteHere(nameof(InfoTable), value); }

        [Offset(8UL)]
        public long HighValue { get => ReadHere<long>(nameof(HighValue)); set => WriteHere(nameof(HighValue), value); }

        [Offset(8UL)]
        public IntPtr NextFreeHandleEntry { get => ReadHere<IntPtr>(nameof(NextFreeHandleEntry)); set => WriteHere(nameof(NextFreeHandleEntry), value); }

        [Offset(8UL)]
        public Exhandle LeafHandleValue { get => ReadStructure<Exhandle>(nameof(LeafHandleValue)); set => WriteStructure(nameof(LeafHandleValue), value); }

        [Offset(0UL)]
        public long RefCountField { get => ReadHere<long>(nameof(RefCountField)); set => WriteHere(nameof(RefCountField), value); }

        [Offset(0UL)]
        public ulong Unlocked { get => ReadHere<ulong>(nameof(Unlocked)); set => WriteHere(nameof(Unlocked), value); }

        [Offset(0UL)]
        public ulong RefCnt { get => ReadHere<ulong>(nameof(RefCnt)); set => WriteHere(nameof(RefCnt), value); }

        [Offset(0UL)]
        public ulong Attributes { get => ReadHere<ulong>(nameof(Attributes)); set => WriteHere(nameof(Attributes), value); }

        [Offset(0UL)]
        public ulong ObjectPointerBits { get => ReadHere<ulong>(nameof(ObjectPointerBits)); set => WriteHere(nameof(ObjectPointerBits), value); }

        [Offset(8UL)]
        public uint GrantedAccessBits { get => ReadHere<uint>(nameof(GrantedAccessBits)); set => WriteHere(nameof(GrantedAccessBits), value); }

        [Offset(8UL)]
        public uint NoRightsUpgrade { get => ReadHere<uint>(nameof(NoRightsUpgrade)); set => WriteHere(nameof(NoRightsUpgrade), value); }

        [Offset(8UL)]
        public uint Spare1 { get => ReadHere<uint>(nameof(Spare1)); set => WriteHere(nameof(Spare1), value); }

        [Offset(12UL)]
        public uint Spare2 { get => ReadHere<uint>(nameof(Spare2)); set => WriteHere(nameof(Spare2), value); }

        public HandleTableEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HandleTableEntry>();
        }
    }
}