using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MMMOD_WRITER_MDL_ENTRY")]
    public sealed class _MMMOD_WRITER_MDL_ENTRY : DynamicStructure
    {
        public _LIST_ENTRY Links { get; }
        public IntPtr Irp { get; }
        public _IO_STATUS_BLOCK IoStatus { get; }
        public _MODWRITER_FLAGS u1 { get; }
        public uint ByteCount { get; }
        public uint ChargedPages { get; }
        public IntPtr Partition { get; }
        public _unnamed_tag_ Pf { get; }
        public _unnamed_tag_ Fs { get; }
        public _LARGE_INTEGER WriteOffset { get; }
        public IntPtr PointerMdl { get; }
        public _MDL Mdl { get; }
        public ulong[] Page { get; }

        public _MMMOD_WRITER_MDL_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMMOD_WRITER_MDL_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MMMOD_WRITER_MDL_ENTRY.Links),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMMOD_WRITER_MDL_ENTRY.Irp),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MMMOD_WRITER_MDL_ENTRY.IoStatus),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MMMOD_WRITER_MDL_ENTRY.u1),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_MMMOD_WRITER_MDL_ENTRY.ByteCount),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_MMMOD_WRITER_MDL_ENTRY.ChargedPages),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_MMMOD_WRITER_MDL_ENTRY.Partition),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_MMMOD_WRITER_MDL_ENTRY.Pf),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_MMMOD_WRITER_MDL_ENTRY.Fs),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_MMMOD_WRITER_MDL_ENTRY.WriteOffset),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_MMMOD_WRITER_MDL_ENTRY.PointerMdl),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_MMMOD_WRITER_MDL_ENTRY.Mdl),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_MMMOD_WRITER_MDL_ENTRY.Page),
                    new ulong[]
                    {
                        152UL
                    }
                }
            };
            Register<_MMMOD_WRITER_MDL_ENTRY>((mem, ptr) => new _MMMOD_WRITER_MDL_ENTRY(mem, ptr), offsets);
        }
    }
}