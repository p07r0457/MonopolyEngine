//
//  Author:
//    Kyle Maher (P07r0457) p07r0457@gmail.com
//
//  Copyright (c) 2013, Kyle Maher
//
//  All rights reserved.
//
//  Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
//
//     * Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in
//       the documentation and/or other materials provided with the distribution.
//     * Neither the name of the [ORGANIZATION] nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.
//
//  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
//  "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
//  LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
//  A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR
//  CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL,
//  EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO,
//  PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR
//  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF
//  LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING
//  NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
//  SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
//
using System;

namespace P07r0457.Monopoly.Engine
{
    /// <author>Kyle Maher</author>
    /// <date>2013-07-30</date>
    /// <summary>
    /// All dice should inherit from this interface.
    /// Define methods that all dice share in common
    /// </summary>
	public interface IDice
	{

        /// <author>Kyle Maher</author>
        /// <date>2013-07-30</date>
        /// <summary>
        /// The result of the last dice roll.
        /// </summary>
        int Result { get; }

		/// <author>Kyle Maher</author>
		/// <date>2013-07-30</date>
		/// <summary>
		/// Roll the dice.
		/// </summary>
		/// <returns>
		/// Returns a zero-based integer that denotes what side of the dice landed up.
		/// </returns>
		int Roll();

	}
}