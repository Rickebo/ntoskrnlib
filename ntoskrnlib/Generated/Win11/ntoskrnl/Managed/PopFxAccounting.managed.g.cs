using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_FX_ACCOUNTING")]
    public sealed class PopFxAccounting : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Lock { get => ReadHere<ulong>(nameof(Lock)); set => WriteHere(nameof(Lock), value); }

        [Offset(8UL)]
        public byte Active { get => ReadHere<byte>(nameof(Active)); set => WriteHere(nameof(Active), value); }

        [Offset(12UL)]
        public uint DripsRequiredState { get => ReadHere<uint>(nameof(DripsRequiredState)); set => WriteHere(nameof(DripsRequiredState), value); }

        [Offset(16UL)]
        public uint AccountingMode { get => ReadHere<uint>(nameof(AccountingMode)); set => WriteHere(nameof(AccountingMode), value); }

        [Offset(24UL)]
        public ulong ActiveStamp { get => ReadHere<ulong>(nameof(ActiveStamp)); set => WriteHere(nameof(ActiveStamp), value); }

        [Offset(32UL)]
        public PopFxActiveTimeAccounting CsActiveTimeAccounting { get => ReadStructure<PopFxActiveTimeAccounting>(nameof(CsActiveTimeAccounting)); set => WriteStructure(nameof(CsActiveTimeAccounting), value); }

        [Offset(128UL)]
        public PopFxActiveTimeAccounting CsCriticalActiveTimeAccounting { get => ReadStructure<PopFxActiveTimeAccounting>(nameof(CsCriticalActiveTimeAccounting)); set => WriteStructure(nameof(CsCriticalActiveTimeAccounting), value); }

        public PopFxAccounting(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopFxAccounting>();
        }
    }
}