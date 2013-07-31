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
    /// Represents the two dice that the user would have during a normal game of Monopoly.
    /// </summary>
    public class UserDice : IDice
    {

        #region Public Properties

        /// <author>Kyle Maher</author>
        /// <date>2013-07-30</date>
        /// <summary>
        /// The last result of the Dice 1 roll.
        /// </summary>
        public int Dice1Result { get; private set; }
        

        /// <author>Kyle Maher</author>
        /// <date>2013-07-30</date>
        /// <summary>
        /// The last result of the Dice 2 roll.
        /// </summary>
        public int Dice2Result { get; private set; }


        /// <author>Kyle Maher</author>
        /// <date>2013-07-30</date>
        /// <summary>
        /// Gets a value indicating whether the user rolled doubles.
        /// </summary>
        /// <value>
        /// <c>true</c> if the user rolled "doubles";
        /// otherwise, <c>false</c>.
        /// </value>
        public bool IsDoubles
        {
            get
            {
                return Dice1Result != 0
                    && Dice1Result == Dice2Result;
            }
        }


        /// <author>Kyle Maher</author>
        /// <date>2013-07-30</date>
        /// <summary>
        /// The sum total of values showing on the dice.
        /// </summary>
        public int Result
        {
            get { return Dice1Result + Dice2Result; }
        }

        #endregion

        #region Private Fields

        /// <author>Kyle Maher</author>
        /// <date>2013-07-30</date>
        /// <summary>
        /// The first dice
        /// </summary>
        private IDice _dice1;


        /// <author>Kyle Maher</author>
        /// <date>2013-07-30</date>
        /// <summary>
        /// The second dice
        /// </summary>
        private IDice _dice2;

        #endregion

        #region Constructor

        /// <author>Kyle Maher</author>
        /// <date>2013-07-30</date>
        /// <summary>
        /// Constructor
        /// </summary>
        /// <remarks>
        /// Initialize the dice
        /// </remarks>
        public UserDice()
        {
            _dice1 = new StandardDice();
            _dice2 = new StandardDice();
        }

        #endregion

        #region Interface Methods

        /// <author>Kyle Maher</author>
        /// <date>2013-07-30</date>
        /// <summary>
        /// Rolls the two dice.
        /// </summary>
        /// <returns>
        /// The sum total of the dice rolled.
        /// </returns>
        public int Roll()
        {
            Dice1Result = _dice1.Roll();
            Dice2Result = _dice2.Roll();

            return Result;
        }

        #endregion
    }
}

