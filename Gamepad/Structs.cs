﻿using System;
using System.Runtime.InteropServices;
using __s32 = System.Int32;
using __u16 = System.UInt16;
using __u32 = System.UInt32;

namespace RobocupSSLController.Gamepad
{
    [StructLayout(LayoutKind.Sequential)]
    struct input_event
    {
        public ulong seconds, microseconds;
        public ushort type;
        public ushort code;
        public int value;
    }

    [StructLayout(LayoutKind.Sequential)]
    unsafe struct fd_set
    {
        public int count;
        public fixed int fds [256];
    }

    

    [StructLayout(LayoutKind.Sequential)]
    struct input_absinfo
    {
        public __s32 value;
        public __s32 minimum;
        public __s32 maximum;
        public __s32 fuzz;
        public __s32 flat;
        public __s32 resolution;

    }
}