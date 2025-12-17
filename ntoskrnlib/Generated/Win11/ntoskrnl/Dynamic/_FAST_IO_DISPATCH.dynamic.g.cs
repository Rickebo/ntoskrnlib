using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_FAST_IO_DISPATCH")]
    public sealed class _FAST_IO_DISPATCH : DynamicStructure
    {
        public uint SizeOfFastIoDispatch { get; }
        public IntPtr FastIoCheckIfPossible { get; }
        public IntPtr FastIoRead { get; }
        public IntPtr FastIoWrite { get; }
        public IntPtr FastIoQueryBasicInfo { get; }
        public IntPtr FastIoQueryStandardInfo { get; }
        public IntPtr FastIoLock { get; }
        public IntPtr FastIoUnlockSingle { get; }
        public IntPtr FastIoUnlockAll { get; }
        public IntPtr FastIoUnlockAllByKey { get; }
        public IntPtr FastIoDeviceControl { get; }
        public IntPtr AcquireFileForNtCreateSection { get; }
        public IntPtr ReleaseFileForNtCreateSection { get; }
        public IntPtr FastIoDetachDevice { get; }
        public IntPtr FastIoQueryNetworkOpenInfo { get; }
        public IntPtr AcquireForModWrite { get; }
        public IntPtr MdlRead { get; }
        public IntPtr MdlReadComplete { get; }
        public IntPtr PrepareMdlWrite { get; }
        public IntPtr MdlWriteComplete { get; }
        public IntPtr FastIoReadCompressed { get; }
        public IntPtr FastIoWriteCompressed { get; }
        public IntPtr MdlReadCompleteCompressed { get; }
        public IntPtr MdlWriteCompleteCompressed { get; }
        public IntPtr FastIoQueryOpen { get; }
        public IntPtr ReleaseForModWrite { get; }
        public IntPtr AcquireForCcFlush { get; }
        public IntPtr ReleaseForCcFlush { get; }

        public _FAST_IO_DISPATCH(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _FAST_IO_DISPATCH()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_FAST_IO_DISPATCH.SizeOfFastIoDispatch),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_FAST_IO_DISPATCH.FastIoCheckIfPossible),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_FAST_IO_DISPATCH.FastIoRead),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_FAST_IO_DISPATCH.FastIoWrite),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_FAST_IO_DISPATCH.FastIoQueryBasicInfo),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_FAST_IO_DISPATCH.FastIoQueryStandardInfo),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_FAST_IO_DISPATCH.FastIoLock),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_FAST_IO_DISPATCH.FastIoUnlockSingle),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_FAST_IO_DISPATCH.FastIoUnlockAll),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_FAST_IO_DISPATCH.FastIoUnlockAllByKey),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_FAST_IO_DISPATCH.FastIoDeviceControl),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_FAST_IO_DISPATCH.AcquireFileForNtCreateSection),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_FAST_IO_DISPATCH.ReleaseFileForNtCreateSection),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_FAST_IO_DISPATCH.FastIoDetachDevice),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_FAST_IO_DISPATCH.FastIoQueryNetworkOpenInfo),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_FAST_IO_DISPATCH.AcquireForModWrite),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_FAST_IO_DISPATCH.MdlRead),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_FAST_IO_DISPATCH.MdlReadComplete),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_FAST_IO_DISPATCH.PrepareMdlWrite),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_FAST_IO_DISPATCH.MdlWriteComplete),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_FAST_IO_DISPATCH.FastIoReadCompressed),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_FAST_IO_DISPATCH.FastIoWriteCompressed),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_FAST_IO_DISPATCH.MdlReadCompleteCompressed),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_FAST_IO_DISPATCH.MdlWriteCompleteCompressed),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_FAST_IO_DISPATCH.FastIoQueryOpen),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_FAST_IO_DISPATCH.ReleaseForModWrite),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_FAST_IO_DISPATCH.AcquireForCcFlush),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_FAST_IO_DISPATCH.ReleaseForCcFlush),
                    new ulong[]
                    {
                        216UL
                    }
                }
            };
            Register<_FAST_IO_DISPATCH>((mem, ptr) => new _FAST_IO_DISPATCH(mem, ptr), offsets);
        }
    }
}