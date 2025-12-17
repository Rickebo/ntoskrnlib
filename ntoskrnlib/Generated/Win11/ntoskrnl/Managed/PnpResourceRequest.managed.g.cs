using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PNP_RESOURCE_REQUEST")]
    public sealed class PnpResourceRequest : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr PhysicalDevice { get => ReadHere<IntPtr>(nameof(PhysicalDevice)); set => WriteHere(nameof(PhysicalDevice), value); }

        [Offset(8UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(12UL)]
        public uint AllocationType { get => ReadHere<uint>(nameof(AllocationType)); set => WriteHere(nameof(AllocationType), value); }

        [Offset(16UL)]
        public uint Priority { get => ReadHere<uint>(nameof(Priority)); set => WriteHere(nameof(Priority), value); }

        [Offset(20UL)]
        public uint Position { get => ReadHere<uint>(nameof(Position)); set => WriteHere(nameof(Position), value); }

        [Offset(24UL)]
        public IntPtr ResourceRequirements { get => ReadHere<IntPtr>(nameof(ResourceRequirements)); set => WriteHere(nameof(ResourceRequirements), value); }

        [Offset(32UL)]
        public IntPtr ReqList { get => ReadHere<IntPtr>(nameof(ReqList)); set => WriteHere(nameof(ReqList), value); }

        [Offset(40UL)]
        public IntPtr ResourceAssignment { get => ReadHere<IntPtr>(nameof(ResourceAssignment)); set => WriteHere(nameof(ResourceAssignment), value); }

        [Offset(48UL)]
        public IntPtr TranslatedResourceAssignment { get => ReadHere<IntPtr>(nameof(TranslatedResourceAssignment)); set => WriteHere(nameof(TranslatedResourceAssignment), value); }

        [Offset(56UL)]
        public int Status { get => ReadHere<int>(nameof(Status)); set => WriteHere(nameof(Status), value); }

        public PnpResourceRequest(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PnpResourceRequest>();
        }
    }
}