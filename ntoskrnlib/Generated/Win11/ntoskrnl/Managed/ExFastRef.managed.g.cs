using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EX_FAST_REF")]
    public sealed class ExFastRef : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Object { get => ReadHere<IntPtr>(nameof(Object)); set => WriteHere(nameof(Object), value); }

        [Offset(0UL)]
        public ulong RefCnt { get => ReadHere<ulong>(nameof(RefCnt)); set => WriteHere(nameof(RefCnt), value); }

        [Offset(0UL)]
        public ulong Value { get => ReadHere<ulong>(nameof(Value)); set => WriteHere(nameof(Value), value); }

        public ExFastRef(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ExFastRef>();
        }
    }
}