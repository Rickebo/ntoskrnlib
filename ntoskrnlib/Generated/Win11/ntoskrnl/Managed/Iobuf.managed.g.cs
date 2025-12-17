using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_iobuf")]
    public sealed class Iobuf : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr _ptr { get => ReadHere<IntPtr>(nameof(_ptr)); set => WriteHere(nameof(_ptr), value); }

        [Offset(8UL)]
        public int _cnt { get => ReadHere<int>(nameof(_cnt)); set => WriteHere(nameof(_cnt), value); }

        [Offset(16UL)]
        public IntPtr _base { get => ReadHere<IntPtr>(nameof(_base)); set => WriteHere(nameof(_base), value); }

        [Offset(24UL)]
        public int _flag { get => ReadHere<int>(nameof(_flag)); set => WriteHere(nameof(_flag), value); }

        [Offset(28UL)]
        public int _file { get => ReadHere<int>(nameof(_file)); set => WriteHere(nameof(_file), value); }

        [Offset(32UL)]
        public int _charbuf { get => ReadHere<int>(nameof(_charbuf)); set => WriteHere(nameof(_charbuf), value); }

        [Offset(36UL)]
        public int _bufsiz { get => ReadHere<int>(nameof(_bufsiz)); set => WriteHere(nameof(_bufsiz), value); }

        [Offset(40UL)]
        public IntPtr _tmpfname { get => ReadHere<IntPtr>(nameof(_tmpfname)); set => WriteHere(nameof(_tmpfname), value); }

        public Iobuf(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Iobuf>();
        }
    }
}