using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DBGKD_MANIPULATE_STATE32")]
    public sealed class DbgkdManipulateSTATE32 : DynamicStructure
    {
        [Offset(0UL)]
        public uint ApiNumber { get => ReadHere<uint>(nameof(ApiNumber)); set => WriteHere(nameof(ApiNumber), value); }

        [Offset(4UL)]
        public ushort ProcessorLevel { get => ReadHere<ushort>(nameof(ProcessorLevel)); set => WriteHere(nameof(ProcessorLevel), value); }

        [Offset(6UL)]
        public ushort Processor { get => ReadHere<ushort>(nameof(Processor)); set => WriteHere(nameof(Processor), value); }

        [Offset(8UL)]
        public int ReturnStatus { get => ReadHere<int>(nameof(ReturnStatus)); set => WriteHere(nameof(ReturnStatus), value); }

        [Offset(12UL)]
        public UnnamedTag u { get => ReadStructure<UnnamedTag>(nameof(u)); set => WriteStructure(nameof(u), value); }

        public DbgkdManipulateSTATE32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DbgkdManipulateSTATE32>();
        }
    }
}