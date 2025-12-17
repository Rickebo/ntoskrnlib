using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ACL")]
    public sealed class Acl : DynamicStructure
    {
        [Offset(0UL)]
        public byte AclRevision { get => ReadHere<byte>(nameof(AclRevision)); set => WriteHere(nameof(AclRevision), value); }

        [Offset(1UL)]
        public byte Sbz1 { get => ReadHere<byte>(nameof(Sbz1)); set => WriteHere(nameof(Sbz1), value); }

        [Offset(2UL)]
        public ushort AclSize { get => ReadHere<ushort>(nameof(AclSize)); set => WriteHere(nameof(AclSize), value); }

        [Offset(4UL)]
        public ushort AceCount { get => ReadHere<ushort>(nameof(AceCount)); set => WriteHere(nameof(AceCount), value); }

        [Offset(6UL)]
        public ushort Sbz2 { get => ReadHere<ushort>(nameof(Sbz2)); set => WriteHere(nameof(Sbz2), value); }

        public Acl(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Acl>();
        }
    }
}