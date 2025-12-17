using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_TXN_PARAMETER_BLOCK")]
    public sealed class TxnParameterBlock : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Length { get => ReadHere<ushort>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(2UL)]
        public ushort TxFsContext { get => ReadHere<ushort>(nameof(TxFsContext)); set => WriteHere(nameof(TxFsContext), value); }

        [Offset(8UL)]
        public IntPtr TransactionObject { get => ReadHere<IntPtr>(nameof(TransactionObject)); set => WriteHere(nameof(TransactionObject), value); }

        public TxnParameterBlock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TxnParameterBlock>();
        }
    }
}