using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_SEP_CACHED_HANDLES_ENTRY_DESCRIPTOR")]
    public sealed class SepCachedHandlesEntryDescriptor : DynamicStructure
    {
        [Offset(0UL)]
        public uint DescriptorType { get => ReadHere<uint>(nameof(DescriptorType)); set => WriteHere(nameof(DescriptorType), value); }

        [Offset(8UL)]
        public IntPtr PackageSid { get => ReadHere<IntPtr>(nameof(PackageSid)); set => WriteHere(nameof(PackageSid), value); }

        [Offset(8UL)]
        public UnicodeString IsolationPrefix { get => ReadStructure<UnicodeString>(nameof(IsolationPrefix)); set => WriteStructure(nameof(IsolationPrefix), value); }

        public SepCachedHandlesEntryDescriptor(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SepCachedHandlesEntryDescriptor>();
        }
    }
}