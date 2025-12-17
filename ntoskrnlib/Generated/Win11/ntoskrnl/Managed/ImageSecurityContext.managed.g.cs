using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IMAGE_SECURITY_CONTEXT")]
    public sealed class ImageSecurityContext : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr PageHashes { get => ReadHere<IntPtr>(nameof(PageHashes)); set => WriteHere(nameof(PageHashes), value); }

        [Offset(0UL)]
        public ulong Value { get => ReadHere<ulong>(nameof(Value)); set => WriteHere(nameof(Value), value); }

        [Offset(0UL)]
        public ulong SecurityBeingCreated { get => ReadHere<ulong>(nameof(SecurityBeingCreated)); set => WriteHere(nameof(SecurityBeingCreated), value); }

        [Offset(0UL)]
        public ulong SecurityMandatory { get => ReadHere<ulong>(nameof(SecurityMandatory)); set => WriteHere(nameof(SecurityMandatory), value); }

        [Offset(0UL)]
        public ulong PageHashPointer { get => ReadHere<ulong>(nameof(PageHashPointer)); set => WriteHere(nameof(PageHashPointer), value); }

        public ImageSecurityContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ImageSecurityContext>();
        }
    }
}