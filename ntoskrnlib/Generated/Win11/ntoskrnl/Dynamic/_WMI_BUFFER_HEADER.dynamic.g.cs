using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WMI_BUFFER_HEADER")]
    public sealed class _WMI_BUFFER_HEADER : DynamicStructure
    {
        public uint BufferSize { get; }
        public uint SavedOffset { get; }
        public uint CurrentOffset { get; }
        public int ReferenceCount { get; }
        public _LARGE_INTEGER TimeStamp { get; }
        public long SequenceNumber { get; }
        public ulong ClockType { get; }
        public ulong Frequency { get; }
        public _SINGLE_LIST_ENTRY SlistEntry { get; }
        public IntPtr NextBuffer { get; }
        public _ETW_BUFFER_CONTEXT ClientContext { get; }
        public uint State { get; }
        public uint Offset { get; }
        public ushort BufferFlag { get; }
        public ushort BufferType { get; }
        public uint[] Padding1 { get; }
        public _ETW_REF_CLOCK ReferenceTime { get; }
        public _LIST_ENTRY GlobalEntry { get; }
        public IntPtr Pointer0 { get; }
        public IntPtr Pointer1 { get; }

        public _WMI_BUFFER_HEADER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WMI_BUFFER_HEADER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WMI_BUFFER_HEADER.BufferSize),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WMI_BUFFER_HEADER.SavedOffset),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_WMI_BUFFER_HEADER.CurrentOffset),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_WMI_BUFFER_HEADER.ReferenceCount),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_WMI_BUFFER_HEADER.TimeStamp),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_WMI_BUFFER_HEADER.SequenceNumber),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_WMI_BUFFER_HEADER.ClockType),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_WMI_BUFFER_HEADER.Frequency),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_WMI_BUFFER_HEADER.SlistEntry),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_WMI_BUFFER_HEADER.NextBuffer),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_WMI_BUFFER_HEADER.ClientContext),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_WMI_BUFFER_HEADER.State),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_WMI_BUFFER_HEADER.Offset),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_WMI_BUFFER_HEADER.BufferFlag),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_WMI_BUFFER_HEADER.BufferType),
                    new ulong[]
                    {
                        54UL
                    }
                },
                {
                    nameof(_WMI_BUFFER_HEADER.Padding1),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_WMI_BUFFER_HEADER.ReferenceTime),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_WMI_BUFFER_HEADER.GlobalEntry),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_WMI_BUFFER_HEADER.Pointer0),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_WMI_BUFFER_HEADER.Pointer1),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_WMI_BUFFER_HEADER>((mem, ptr) => new _WMI_BUFFER_HEADER(mem, ptr), offsets);
        }
    }
}