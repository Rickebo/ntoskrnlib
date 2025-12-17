using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_FILE_OBJECT")]
    public sealed class _FILE_OBJECT : DynamicStructure
    {
        public short Type { get; }
        public short Size { get; }
        public IntPtr DeviceObject { get; }
        public IntPtr Vpb { get; }
        public IntPtr FsContext { get; }
        public IntPtr FsContext2 { get; }
        public IntPtr SectionObjectPointer { get; }
        public IntPtr PrivateCacheMap { get; }
        public int FinalStatus { get; }
        public IntPtr RelatedFileObject { get; }
        public byte LockOperation { get; }
        public byte DeletePending { get; }
        public byte ReadAccess { get; }
        public byte WriteAccess { get; }
        public byte DeleteAccess { get; }
        public byte SharedRead { get; }
        public byte SharedWrite { get; }
        public byte SharedDelete { get; }
        public uint Flags { get; }
        public _UNICODE_STRING FileName { get; }
        public _LARGE_INTEGER CurrentByteOffset { get; }
        public uint Waiters { get; }
        public uint Busy { get; }
        public IntPtr LastLock { get; }
        public _KEVENT Lock { get; }
        public _KEVENT Event { get; }
        public IntPtr CompletionContext { get; }
        public ulong IrpListLock { get; }
        public _LIST_ENTRY IrpList { get; }
        public IntPtr FileObjectExtension { get; }

        public _FILE_OBJECT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _FILE_OBJECT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_FILE_OBJECT.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_FILE_OBJECT.Size),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_FILE_OBJECT.DeviceObject),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_FILE_OBJECT.Vpb),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_FILE_OBJECT.FsContext),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_FILE_OBJECT.FsContext2),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_FILE_OBJECT.SectionObjectPointer),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_FILE_OBJECT.PrivateCacheMap),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_FILE_OBJECT.FinalStatus),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_FILE_OBJECT.RelatedFileObject),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_FILE_OBJECT.LockOperation),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_FILE_OBJECT.DeletePending),
                    new ulong[]
                    {
                        73UL
                    }
                },
                {
                    nameof(_FILE_OBJECT.ReadAccess),
                    new ulong[]
                    {
                        74UL
                    }
                },
                {
                    nameof(_FILE_OBJECT.WriteAccess),
                    new ulong[]
                    {
                        75UL
                    }
                },
                {
                    nameof(_FILE_OBJECT.DeleteAccess),
                    new ulong[]
                    {
                        76UL
                    }
                },
                {
                    nameof(_FILE_OBJECT.SharedRead),
                    new ulong[]
                    {
                        77UL
                    }
                },
                {
                    nameof(_FILE_OBJECT.SharedWrite),
                    new ulong[]
                    {
                        78UL
                    }
                },
                {
                    nameof(_FILE_OBJECT.SharedDelete),
                    new ulong[]
                    {
                        79UL
                    }
                },
                {
                    nameof(_FILE_OBJECT.Flags),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_FILE_OBJECT.FileName),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_FILE_OBJECT.CurrentByteOffset),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_FILE_OBJECT.Waiters),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_FILE_OBJECT.Busy),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_FILE_OBJECT.LastLock),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_FILE_OBJECT.Lock),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_FILE_OBJECT.Event),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_FILE_OBJECT.CompletionContext),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_FILE_OBJECT.IrpListLock),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_FILE_OBJECT.IrpList),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_FILE_OBJECT.FileObjectExtension),
                    new ulong[]
                    {
                        208UL
                    }
                }
            };
            Register<_FILE_OBJECT>((mem, ptr) => new _FILE_OBJECT(mem, ptr), offsets);
        }
    }
}