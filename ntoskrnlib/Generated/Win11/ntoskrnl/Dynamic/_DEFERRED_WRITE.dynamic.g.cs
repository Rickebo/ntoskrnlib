using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DEFERRED_WRITE")]
    public sealed class _DEFERRED_WRITE : DynamicStructure
    {
        public short NodeTypeCode { get; }
        public short NodeByteSize { get; }
        public IntPtr FileObject { get; }
        public uint BytesToWrite { get; }
        public _LIST_ENTRY DeferredWriteLinks { get; }
        public IntPtr Event { get; }
        public IntPtr PostRoutine { get; }
        public IntPtr Context1 { get; }
        public IntPtr Context2 { get; }
        public IntPtr Partition { get; }
        public IntPtr PrivateVolumeCacheMap { get; }
        public byte SoftThrottle { get; }
        public _LARGE_INTEGER TimeAdded { get; }

        public _DEFERRED_WRITE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DEFERRED_WRITE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DEFERRED_WRITE.NodeTypeCode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DEFERRED_WRITE.NodeByteSize),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_DEFERRED_WRITE.FileObject),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DEFERRED_WRITE.BytesToWrite),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DEFERRED_WRITE.DeferredWriteLinks),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_DEFERRED_WRITE.Event),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_DEFERRED_WRITE.PostRoutine),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_DEFERRED_WRITE.Context1),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_DEFERRED_WRITE.Context2),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_DEFERRED_WRITE.Partition),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_DEFERRED_WRITE.PrivateVolumeCacheMap),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_DEFERRED_WRITE.SoftThrottle),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_DEFERRED_WRITE.TimeAdded),
                    new ulong[]
                    {
                        96UL
                    }
                }
            };
            Register<_DEFERRED_WRITE>((mem, ptr) => new _DEFERRED_WRITE(mem, ptr), offsets);
        }
    }
}