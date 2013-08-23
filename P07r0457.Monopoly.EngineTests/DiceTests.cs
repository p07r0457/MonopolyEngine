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
using NUnit.Framework;
using P07r0457.Monopoly.Engine;

namespace P07r0457.Monopoly.EngineTests
{
    [TestFixture()]
    public class DiceTests
    {

        /// <author>Kyle Maher</author>
        /// <date>2013-08-21</date>
        /// <summary>
        /// Test one million dice rolls.
        /// Ensures that each result falls within the expected range.
        /// </summary>
        [Test()]
        public void DiceResultsWithinExpectedBounds()
        {
            var dice = new StandardDice();

            for (int i = 0; i < 1000000; i++)
            {
                dice.Roll();

                Assert.That(dice.Result >= 1,
                            "Result fell below the lower bound of [1].");
                Assert.That(dice.Result <= 6,
                            "Result was above the upper bound of [6].");
            }
        }

    }
}

