using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HARDWARE_PTE")]
    public sealed class HardwarePte : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Valid { get => ReadHere<ulong>(nameof(Valid)); set => WriteHere(nameof(Valid), value); }

        [Offset(0UL)]
        public ulong Write { get => ReadHere<ulong>(nameof(Write)); set => WriteHere(nameof(Write), value); }

        [Offset(0UL)]
        public ulong Owner { get => ReadHere<ulong>(nameof(Owner)); set => WriteHere(nameof(Owner), value); }

        [Offset(0UL)]
        public ulong WriteThrough { get => ReadHere<ulong>(nameof(WriteThrough)); set => WriteHere(nameof(WriteThrough), value); }

        [Offset(0UL)]
        public ulong CacheDisable { get => ReadHere<ulong>(nameof(CacheDisable)); set => WriteHere(nameof(CacheDisable), value); }

        [Offset(0UL)]
        public ulong Accessed { get => ReadHere<ulong>(nameof(Accessed)); set => WriteHere(nameof(Accessed), value); }

        [Offset(0UL)]
        public ulong Dirty { get => ReadHere<ulong>(nameof(Dirty)); set => WriteHere(nameof(Dirty), value); }

        [Offset(0UL)]
        public ulong LargePage { get => ReadHere<ulong>(nameof(LargePage)); set => WriteHere(nameof(LargePage), value); }

        [Offset(0UL)]
        public ulong Global { get => ReadHere<ulong>(nameof(Global)); set => WriteHere(nameof(Global), value); }

        [Offset(0UL)]
        public ulong CopyOnWrite { get => ReadHere<ulong>(nameof(CopyOnWrite)); set => WriteHere(nameof(CopyOnWrite), value); }

        [Offset(0UL)]
        public ulong Prototype { get => ReadHere<ulong>(nameof(Prototype)); set => WriteHere(nameof(Prototype), value); }

        [Offset(0UL)]
        public ulong reserved0 { get => ReadHere<ulong>(nameof(reserved0)); set => WriteHere(nameof(reserved0), value); }

        [Offset(0UL)]
        public ulong PageFrameNumber { get => ReadHere<ulong>(nameof(PageFrameNumber)); set => WriteHere(nameof(PageFrameNumber), value); }

        [Offset(0UL)]
        public ulong SoftwareWsIndex { get => ReadHere<ulong>(nameof(SoftwareWsIndex)); set => WriteHere(nameof(SoftwareWsIndex), value); }

        [Offset(0UL)]
        public ulong NoExecute { get => ReadHere<ulong>(nameof(NoExecute)); set => WriteHere(nameof(NoExecute), value); }

        public HardwarePte(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HardwarePte>();
        }
    }
}