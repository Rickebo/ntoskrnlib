using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CPU_INFO")]
    public sealed class CpuInfo : DynamicStructure
    {
        [Offset(0UL)]
        [Length(4)]
        public DynamicArray AsUINT32 { get => ReadStructure<DynamicArray>(nameof(AsUINT32)); set => WriteStructure(nameof(AsUINT32), value); }

        [Offset(0UL)]
        public uint Eax { get => ReadHere<uint>(nameof(Eax)); set => WriteHere(nameof(Eax), value); }

        [Offset(4UL)]
        public uint Ebx { get => ReadHere<uint>(nameof(Ebx)); set => WriteHere(nameof(Ebx), value); }

        [Offset(8UL)]
        public uint Ecx { get => ReadHere<uint>(nameof(Ecx)); set => WriteHere(nameof(Ecx), value); }

        [Offset(12UL)]
        public uint Edx { get => ReadHere<uint>(nameof(Edx)); set => WriteHere(nameof(Edx), value); }

        public CpuInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CpuInfo>();
        }
    }
}