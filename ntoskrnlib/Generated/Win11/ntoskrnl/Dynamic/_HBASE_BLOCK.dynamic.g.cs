using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HBASE_BLOCK")]
    public sealed class _HBASE_BLOCK : DynamicStructure
    {
        public uint Signature { get; }
        public uint Sequence1 { get; }
        public uint Sequence2 { get; }
        public _LARGE_INTEGER TimeStamp { get; }
        public uint Major { get; }
        public uint Minor { get; }
        public uint Type { get; }
        public uint Format { get; }
        public uint RootCell { get; }
        public uint Length { get; }
        public uint Cluster { get; }
        public byte[] FileName { get; }
        public _GUID RmId { get; }
        public _GUID LogId { get; }
        public uint Flags { get; }
        public _GUID TmId { get; }
        public uint GuidSignature { get; }
        public ulong LastReorganizeTime { get; }
        public uint[] Reserved1 { get; }
        public uint CheckSum { get; }
        public uint[] Reserved2 { get; }
        public _GUID ThawTmId { get; }
        public _GUID ThawRmId { get; }
        public _GUID ThawLogId { get; }
        public uint BootType { get; }
        public uint BootRecover { get; }

        public _HBASE_BLOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HBASE_BLOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HBASE_BLOCK.Signature),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HBASE_BLOCK.Sequence1),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_HBASE_BLOCK.Sequence2),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HBASE_BLOCK.TimeStamp),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HBASE_BLOCK.Major),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_HBASE_BLOCK.Minor),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_HBASE_BLOCK.Type),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_HBASE_BLOCK.Format),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_HBASE_BLOCK.RootCell),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_HBASE_BLOCK.Length),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_HBASE_BLOCK.Cluster),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_HBASE_BLOCK.FileName),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_HBASE_BLOCK.RmId),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_HBASE_BLOCK.LogId),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_HBASE_BLOCK.Flags),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_HBASE_BLOCK.TmId),
                    new ulong[]
                    {
                        148UL
                    }
                },
                {
                    nameof(_HBASE_BLOCK.GuidSignature),
                    new ulong[]
                    {
                        164UL
                    }
                },
                {
                    nameof(_HBASE_BLOCK.LastReorganizeTime),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_HBASE_BLOCK.Reserved1),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_HBASE_BLOCK.CheckSum),
                    new ulong[]
                    {
                        508UL
                    }
                },
                {
                    nameof(_HBASE_BLOCK.Reserved2),
                    new ulong[]
                    {
                        512UL
                    }
                },
                {
                    nameof(_HBASE_BLOCK.ThawTmId),
                    new ulong[]
                    {
                        4040UL
                    }
                },
                {
                    nameof(_HBASE_BLOCK.ThawRmId),
                    new ulong[]
                    {
                        4056UL
                    }
                },
                {
                    nameof(_HBASE_BLOCK.ThawLogId),
                    new ulong[]
                    {
                        4072UL
                    }
                },
                {
                    nameof(_HBASE_BLOCK.BootType),
                    new ulong[]
                    {
                        4088UL
                    }
                },
                {
                    nameof(_HBASE_BLOCK.BootRecover),
                    new ulong[]
                    {
                        4092UL
                    }
                }
            };
            Register<_HBASE_BLOCK>((mem, ptr) => new _HBASE_BLOCK(mem, ptr), offsets);
        }
    }
}