using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_OPEN_PACKET")]
    public sealed class _OPEN_PACKET : DynamicStructure
    {
        public short Type { get; }
        public short Size { get; }
        public IntPtr FileObject { get; }
        public int FinalStatus { get; }
        public ulong Information { get; }
        public uint ParseCheck { get; }
        public IntPtr RelatedFileObject { get; }
        public IntPtr ReferencedDeviceObject { get; }
        public IntPtr OriginalAttributes { get; }
        public _LARGE_INTEGER AllocationSize { get; }
        public uint CreateOptions { get; }
        public ushort FileAttributes { get; }
        public ushort ShareAccess { get; }
        public IntPtr EaBuffer { get; }
        public uint EaLength { get; }
        public uint Options { get; }
        public uint Disposition { get; }
        public IntPtr BasicInformation { get; }
        public IntPtr NetworkInformation { get; }
        public IntPtr FileInformation { get; }
        public uint CreateFileType { get; }
        public IntPtr MailslotOrPipeParameters { get; }
        public byte Override { get; }
        public byte QueryOnly { get; }
        public byte DeleteOnly { get; }
        public byte FullAttributes { get; }
        public IntPtr LocalFileObject { get; }
        public uint InternalFlags { get; }
        public sbyte AccessMode { get; }
        public _IO_DRIVER_CREATE_CONTEXT DriverCreateContext { get; }
        public uint FileInformationClass { get; }
        public uint FileInformationLength { get; }
        public byte FilterQuery { get; }
        public long ExtendedCreateFlags { get; }

        public _OPEN_PACKET(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _OPEN_PACKET()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_OPEN_PACKET.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_OPEN_PACKET.Size),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_OPEN_PACKET.FileObject),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_OPEN_PACKET.FinalStatus),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_OPEN_PACKET.Information),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_OPEN_PACKET.ParseCheck),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_OPEN_PACKET.RelatedFileObject),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_OPEN_PACKET.ReferencedDeviceObject),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_OPEN_PACKET.OriginalAttributes),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_OPEN_PACKET.AllocationSize),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_OPEN_PACKET.CreateOptions),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_OPEN_PACKET.FileAttributes),
                    new ulong[]
                    {
                        68UL
                    }
                },
                {
                    nameof(_OPEN_PACKET.ShareAccess),
                    new ulong[]
                    {
                        70UL
                    }
                },
                {
                    nameof(_OPEN_PACKET.EaBuffer),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_OPEN_PACKET.EaLength),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_OPEN_PACKET.Options),
                    new ulong[]
                    {
                        84UL
                    }
                },
                {
                    nameof(_OPEN_PACKET.Disposition),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_OPEN_PACKET.BasicInformation),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_OPEN_PACKET.NetworkInformation),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_OPEN_PACKET.FileInformation),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_OPEN_PACKET.CreateFileType),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_OPEN_PACKET.MailslotOrPipeParameters),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_OPEN_PACKET.Override),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_OPEN_PACKET.QueryOnly),
                    new ulong[]
                    {
                        137UL
                    }
                },
                {
                    nameof(_OPEN_PACKET.DeleteOnly),
                    new ulong[]
                    {
                        138UL
                    }
                },
                {
                    nameof(_OPEN_PACKET.FullAttributes),
                    new ulong[]
                    {
                        139UL
                    }
                },
                {
                    nameof(_OPEN_PACKET.LocalFileObject),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_OPEN_PACKET.InternalFlags),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_OPEN_PACKET.AccessMode),
                    new ulong[]
                    {
                        156UL
                    }
                },
                {
                    nameof(_OPEN_PACKET.DriverCreateContext),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_OPEN_PACKET.FileInformationClass),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_OPEN_PACKET.FileInformationLength),
                    new ulong[]
                    {
                        204UL
                    }
                },
                {
                    nameof(_OPEN_PACKET.FilterQuery),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_OPEN_PACKET.ExtendedCreateFlags),
                    new ulong[]
                    {
                        216UL
                    }
                }
            };
            Register<_OPEN_PACKET>((mem, ptr) => new _OPEN_PACKET(mem, ptr), offsets);
        }
    }
}