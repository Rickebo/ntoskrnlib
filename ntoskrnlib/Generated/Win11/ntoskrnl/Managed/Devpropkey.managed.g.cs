using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DEVPROPKEY")]
    public sealed class Devpropkey : DynamicStructure
    {
        [Offset(0UL)]
        public Guid fmtid { get => ReadStructure<Guid>(nameof(fmtid)); set => WriteStructure(nameof(fmtid), value); }

        [Offset(16UL)]
        public uint pid { get => ReadHere<uint>(nameof(pid)); set => WriteHere(nameof(pid), value); }

        public Devpropkey(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Devpropkey>();
        }
    }
}