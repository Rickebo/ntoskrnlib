using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_iobuf")]
    public sealed class _iobuf : DynamicStructure
    {
        public IntPtr _ptr { get; }
        public int _cnt { get; }
        public IntPtr _base { get; }
        public int _flag { get; }
        public int _file { get; }
        public int _charbuf { get; }
        public int _bufsiz { get; }
        public IntPtr _tmpfname { get; }

        public _iobuf(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _iobuf()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_iobuf._ptr),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_iobuf._cnt),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_iobuf._base),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_iobuf._flag),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_iobuf._file),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_iobuf._charbuf),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_iobuf._bufsiz),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_iobuf._tmpfname),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_iobuf>((mem, ptr) => new _iobuf(mem, ptr), offsets);
        }
    }
}