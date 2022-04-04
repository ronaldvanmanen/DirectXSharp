// DirectXSharp
//
// Copyright (C) 2021 Ronald van Manen <rvanmanen@gmail.com>
//
// MIT License
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System;
using System.Runtime.InteropServices;
using Xunit;

namespace DirectXSharp.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D3DAUTHENTICATEDCHANNEL_CONFIGURESHAREDRESOURCE" /> struct.</summary>
    public static unsafe partial class D3DAUTHENTICATEDCHANNEL_CONFIGURESHAREDRESOURCETests
    {
        /// <summary>Validates that the <see cref="D3DAUTHENTICATEDCHANNEL_CONFIGURESHAREDRESOURCE" /> struct is blittable.</summary>
        [Fact]
        public static void IsBlittableTest()
        {
            Assert.Equal(sizeof(D3DAUTHENTICATEDCHANNEL_CONFIGURESHAREDRESOURCE), Marshal.SizeOf<D3DAUTHENTICATEDCHANNEL_CONFIGURESHAREDRESOURCE>());
        }

        /// <summary>Validates that the <see cref="D3DAUTHENTICATEDCHANNEL_CONFIGURESHAREDRESOURCE" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Fact]
        public static void IsLayoutSequentialTest()
        {
            Assert.True(typeof(D3DAUTHENTICATEDCHANNEL_CONFIGURESHAREDRESOURCE).IsLayoutSequential);
        }

        /// <summary>Validates that the <see cref="D3DAUTHENTICATEDCHANNEL_CONFIGURESHAREDRESOURCE" /> struct has the correct size.</summary>
        [Fact]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.Equal(72, sizeof(D3DAUTHENTICATEDCHANNEL_CONFIGURESHAREDRESOURCE));
            }
            else
            {
                Assert.Equal(52, sizeof(D3DAUTHENTICATEDCHANNEL_CONFIGURESHAREDRESOURCE));
            }
        }
    }
}