using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IOP_IRP_EXTENSION")]
    public sealed class _IOP_IRP_EXTENSION : DynamicStructure
    {
        public ushort ExtensionFlags { get; }
        public ushort Allocated { get; }
        public ushort PropagateId { get; }
        public ushort SpareBits { get; }
        public ushort TypesAllocated { get; }
        public byte[] GenericExtension { get; }
        public IntPtr VerifierContext { get; }
        public ulong DiskIoAttributionHandle { get; }
        public _GUID ActivityId { get; }
        public _LARGE_INTEGER Timestamp { get; }
        public uint ZeroingOffset { get; }
        public IntPtr FsTrackOffsetBlob { get; }
        public long FsTrackedOffset { get; }
        public _IO_ADAPTER_CRYPTO_PARAMETERS AdapterCryptoParameters { get; }
        public _unnamed_tag_ DriverFlags { get; }
        public _COPY_INFORMATION CopyInformation { get; }

        public _IOP_IRP_EXTENSION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IOP_IRP_EXTENSION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IOP_IRP_EXTENSION.ExtensionFlags),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOP_IRP_EXTENSION.Allocated),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOP_IRP_EXTENSION.PropagateId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOP_IRP_EXTENSION.SpareBits),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOP_IRP_EXTENSION.TypesAllocated),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_IOP_IRP_EXTENSION.GenericExtension),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_IOP_IRP_EXTENSION.VerifierContext),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_IOP_IRP_EXTENSION.DiskIoAttributionHandle),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_IOP_IRP_EXTENSION.ActivityId),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_IOP_IRP_EXTENSION.Timestamp),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_IOP_IRP_EXTENSION.ZeroingOffset),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_IOP_IRP_EXTENSION.FsTrackOffsetBlob),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_IOP_IRP_EXTENSION.FsTrackedOffset),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_IOP_IRP_EXTENSION.AdapterCryptoParameters),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_IOP_IRP_EXTENSION.DriverFlags),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_IOP_IRP_EXTENSION.CopyInformation),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_IOP_IRP_EXTENSION>((mem, ptr) => new _IOP_IRP_EXTENSION(mem, ptr), offsets);
        }
    }
}