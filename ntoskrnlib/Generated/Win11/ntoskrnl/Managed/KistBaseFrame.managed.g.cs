using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KIST_BASE_FRAME")]
    public sealed class KistBaseFrame : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr KernelGsBase { get => ReadHere<IntPtr>(nameof(KernelGsBase)); set => WriteHere(nameof(KernelGsBase), value); }

        [Offset(8UL)]
        public IntPtr IstStack { get => ReadHere<IntPtr>(nameof(IstStack)); set => WriteHere(nameof(IstStack), value); }

        [Offset(16UL)]
        public ulong PreviousGsBase { get => ReadHere<ulong>(nameof(PreviousGsBase)); set => WriteHere(nameof(PreviousGsBase), value); }

        [Offset(24UL)]
        public ulong PreviousCr3 { get => ReadHere<ulong>(nameof(PreviousCr3)); set => WriteHere(nameof(PreviousCr3), value); }

        [Offset(32UL)]
        public ulong IstPad { get => ReadHere<ulong>(nameof(IstPad)); set => WriteHere(nameof(IstPad), value); }

        [Offset(40UL)]
        public ulong Reserved { get => ReadHere<ulong>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        public KistBaseFrame(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KistBaseFrame>();
        }
    }
}