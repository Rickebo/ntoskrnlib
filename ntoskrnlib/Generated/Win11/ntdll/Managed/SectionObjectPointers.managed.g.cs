using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_SECTION_OBJECT_POINTERS")]
    public sealed class SectionObjectPointers : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr DataSectionObject { get => ReadHere<IntPtr>(nameof(DataSectionObject)); set => WriteHere(nameof(DataSectionObject), value); }

        [Offset(8UL)]
        public IntPtr SharedCacheMap { get => ReadHere<IntPtr>(nameof(SharedCacheMap)); set => WriteHere(nameof(SharedCacheMap), value); }

        [Offset(16UL)]
        public IntPtr ImageSectionObject { get => ReadHere<IntPtr>(nameof(ImageSectionObject)); set => WriteHere(nameof(ImageSectionObject), value); }

        public SectionObjectPointers(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SectionObjectPointers>();
        }
    }
}