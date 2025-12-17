using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_SECURITY_DESCRIPTOR_RELATIVE")]
    public sealed class SecurityDescriptorRelative : DynamicStructure
    {
        [Offset(0UL)]
        public byte Revision { get => ReadHere<byte>(nameof(Revision)); set => WriteHere(nameof(Revision), value); }

        [Offset(1UL)]
        public byte Sbz1 { get => ReadHere<byte>(nameof(Sbz1)); set => WriteHere(nameof(Sbz1), value); }

        [Offset(2UL)]
        public ushort Control { get => ReadHere<ushort>(nameof(Control)); set => WriteHere(nameof(Control), value); }

        [Offset(4UL)]
        public uint Owner { get => ReadHere<uint>(nameof(Owner)); set => WriteHere(nameof(Owner), value); }

        [Offset(8UL)]
        public uint Group { get => ReadHere<uint>(nameof(Group)); set => WriteHere(nameof(Group), value); }

        [Offset(12UL)]
        public uint Sacl { get => ReadHere<uint>(nameof(Sacl)); set => WriteHere(nameof(Sacl), value); }

        [Offset(16UL)]
        public uint Dacl { get => ReadHere<uint>(nameof(Dacl)); set => WriteHere(nameof(Dacl), value); }

        public SecurityDescriptorRelative(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SecurityDescriptorRelative>();
        }
    }
}