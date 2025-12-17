using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KPROCESSOR_DESCRIPTOR_AREA")]
    public sealed class KprocessorDescriptorArea : DynamicStructure
    {
        [Offset(0UL)]
        [Length(256)]
        public DynamicArray Idt { get => ReadStructure<DynamicArray>(nameof(Idt)); set => WriteStructure(nameof(Idt), value); }

        [Offset(4096UL)]
        public KTSS64 Tss { get => ReadStructure<KTSS64>(nameof(Tss)); set => WriteStructure(nameof(Tss), value); }

        [Offset(4200UL)]
        public ulong TssSpare { get => ReadHere<ulong>(nameof(TssSpare)); set => WriteHere(nameof(TssSpare), value); }

        [Offset(4208UL)]
        public IntPtr KernelGsBase { get => ReadHere<IntPtr>(nameof(KernelGsBase)); set => WriteHere(nameof(KernelGsBase), value); }

        [Offset(4216UL)]
        public IntPtr IdleStack { get => ReadHere<IntPtr>(nameof(IdleStack)); set => WriteHere(nameof(IdleStack), value); }

        [Offset(4224UL)]
        [Length(3888)]
        public DynamicArray TssPad { get => ReadStructure<DynamicArray>(nameof(TssPad)); set => WriteStructure(nameof(TssPad), value); }

        [Offset(8112UL)]
        [Length(4096)]
        public DynamicArray GdtPadTemp { get => ReadStructure<DynamicArray>(nameof(GdtPadTemp)); set => WriteStructure(nameof(GdtPadTemp), value); }

        [Offset(12208UL)]
        [Length(5)]
        public DynamicArray Gdt { get => ReadStructure<DynamicArray>(nameof(Gdt)); set => WriteStructure(nameof(Gdt), value); }

        [Offset(12288UL)]
        public Kldtentry GdtCmTebDescriptor { get => ReadStructure<Kldtentry>(nameof(GdtCmTebDescriptor)); set => WriteStructure(nameof(GdtCmTebDescriptor), value); }

        [Offset(12296UL)]
        [Length(4088)]
        public DynamicArray GdtEndPadding { get => ReadStructure<DynamicArray>(nameof(GdtEndPadding)); set => WriteStructure(nameof(GdtEndPadding), value); }

        [Offset(16384UL)]
        [Length(8)]
        public DynamicArray TransitionStack { get => ReadStructure<DynamicArray>(nameof(TransitionStack)); set => WriteStructure(nameof(TransitionStack), value); }

        public KprocessorDescriptorArea(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KprocessorDescriptorArea>();
        }
    }
}