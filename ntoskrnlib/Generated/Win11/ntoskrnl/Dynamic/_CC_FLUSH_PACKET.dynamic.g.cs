using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CC_FLUSH_PACKET")]
    public sealed class _CC_FLUSH_PACKET : DynamicStructure
    {
        public IntPtr Partition { get; }
        public IntPtr PrivateVolumeCacheMap { get; }
        public IntPtr SharedCacheMap { get; }
        public IntPtr SectionObjectPointer { get; }
        public _LARGE_INTEGER TargetOffset { get; }
        public _LARGE_INTEGER NextFileOffset { get; }
        public uint NextLength { get; }
        public uint BytesWritten { get; }
        public uint MmFlushFlags { get; }
        public uint HotSpot { get; }
        public uint VerifyRequired { get; }
        public IntPtr FlushEvent { get; }
        public _LARGE_INTEGER FlushLargestLsn { get; }
        public IntPtr LargestLsn { get; }
        public IntPtr CallersFileOffset { get; }
        public uint CallersLength { get; }
        public byte MarkWritethrough { get; }
        public IntPtr CallersIoStatus { get; }
        public IntPtr FirstBcb { get; }
        public int FirstFailureStatus { get; }
        public byte IsLazyWriter { get; }
        public byte FastLazyWrite { get; }
        public byte ForceFullFlush { get; }
        public byte PerformedFlushForMemMapped { get; }
        public byte TeardownFlagBeforeFlush { get; }
        public byte ShouldRetryTeardown { get; }
        public byte FlushForImageSection { get; }
        public byte ForceSynchronousLazyWrite { get; }
        public uint AcquireForLazyWriteOutFlags { get; }
        public byte FlushDontTrustHints { get; }
        public _LARGE_INTEGER StartTick { get; }
        public _LARGE_INTEGER EndTick { get; }
        public IntPtr FsContext { get; }
        public IntPtr WorkEntry { get; }
        public IntPtr DeferredWritesList { get; }
        public IntPtr CoalescingState { get; }
        public byte DoSinglePassFlush { get; }
        public byte RecordedSinglePassStartOffset { get; }
        public _LARGE_INTEGER SinglePassStartOffset { get; }
        public ulong DirtyPagesAtStart { get; }
        public ulong TotalBytesWritten { get; }
        public _LARGE_INTEGER LwFlushStart { get; }
        public _LARGE_INTEGER LwFlushEnd { get; }
        public uint TotalPagesFlushed { get; }
        public uint PagesToWrite { get; }
        public uint RequeueToHeadCount { get; }
        public IntPtr WorkQueueEntry { get; }

        public _CC_FLUSH_PACKET(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CC_FLUSH_PACKET()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CC_FLUSH_PACKET.Partition),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.PrivateVolumeCacheMap),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.SharedCacheMap),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.SectionObjectPointer),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.TargetOffset),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.NextFileOffset),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.NextLength),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.BytesWritten),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.MmFlushFlags),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.HotSpot),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.VerifyRequired),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.FlushEvent),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.FlushLargestLsn),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.LargestLsn),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.CallersFileOffset),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.CallersLength),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.MarkWritethrough),
                    new ulong[]
                    {
                        108UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.CallersIoStatus),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.FirstBcb),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.FirstFailureStatus),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.IsLazyWriter),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.FastLazyWrite),
                    new ulong[]
                    {
                        133UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.ForceFullFlush),
                    new ulong[]
                    {
                        134UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.PerformedFlushForMemMapped),
                    new ulong[]
                    {
                        135UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.TeardownFlagBeforeFlush),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.ShouldRetryTeardown),
                    new ulong[]
                    {
                        137UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.FlushForImageSection),
                    new ulong[]
                    {
                        138UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.ForceSynchronousLazyWrite),
                    new ulong[]
                    {
                        139UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.AcquireForLazyWriteOutFlags),
                    new ulong[]
                    {
                        140UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.FlushDontTrustHints),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.StartTick),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.EndTick),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.FsContext),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.WorkEntry),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.DeferredWritesList),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.CoalescingState),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.DoSinglePassFlush),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.RecordedSinglePassStartOffset),
                    new ulong[]
                    {
                        201UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.SinglePassStartOffset),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.DirtyPagesAtStart),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.TotalBytesWritten),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.LwFlushStart),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.LwFlushEnd),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.TotalPagesFlushed),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.PagesToWrite),
                    new ulong[]
                    {
                        252UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.RequeueToHeadCount),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_CC_FLUSH_PACKET.WorkQueueEntry),
                    new ulong[]
                    {
                        264UL
                    }
                }
            };
            Register<_CC_FLUSH_PACKET>((mem, ptr) => new _CC_FLUSH_PACKET(mem, ptr), offsets);
        }
    }
}