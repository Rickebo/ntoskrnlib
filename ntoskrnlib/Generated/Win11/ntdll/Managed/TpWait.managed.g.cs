using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_TP_WAIT")]
    public sealed class TpWait : DynamicStructure
    {
        [Offset(0UL)]
        public TpTimer Timer { get => ReadStructure<TpTimer>(nameof(Timer)); set => WriteStructure(nameof(Timer), value); }

        [Offset(360UL)]
        public IntPtr Handle { get => ReadHere<IntPtr>(nameof(Handle)); set => WriteHere(nameof(Handle), value); }

        [Offset(368UL)]
        public IntPtr WaitPkt { get => ReadHere<IntPtr>(nameof(WaitPkt)); set => WriteHere(nameof(WaitPkt), value); }

        [Offset(376UL)]
        public IntPtr NextWaitHandle { get => ReadHere<IntPtr>(nameof(NextWaitHandle)); set => WriteHere(nameof(NextWaitHandle), value); }

        [Offset(384UL)]
        public LargeInteger NextWaitTimeout { get => ReadStructure<LargeInteger>(nameof(NextWaitTimeout)); set => WriteStructure(nameof(NextWaitTimeout), value); }

        [Offset(392UL)]
        public TpDirect Direct { get => ReadStructure<TpDirect>(nameof(Direct)); set => WriteStructure(nameof(Direct), value); }

        [Offset(464UL)]
        public UnnamedTag WaitFlags { get => ReadStructure<UnnamedTag>(nameof(WaitFlags)); set => WriteStructure(nameof(WaitFlags), value); }

        public TpWait(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TpWait>();
        }
    }
}