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
    public class BoardSpace
    {

        #region "Enums"

        /// <author>Kyle Maher</author>
        /// <date>2013-08-21</date>
        /// <summary>
        /// Define the types of special spaces that exist on the game board.
        /// </summary>
        public enum SpecialSpaces
        {
            None,
            Go,
            CommunityChest,
            IncomeTax,
            Chance,
            Jail,
            FreeParking,
            GoToJail,
            LuxuryTax
        }


        /// <author>Kyle Maher</author>
        /// <date>2013-08-21</date>
        /// <summary>
        /// Define the groups that a space may belong to.
        /// </summary>
        public enum Groups
        {
            DarkBlue,
            LightBlue,
            Purple,
            Orange,
            Red,
            Yellow,
            Green,
            Blue,
            RailRoad,
            Utilities,
            Other
        }

        #endregion

        #region "Public Properties"

        /// <author>Kyle Maher</author>
        /// <date>2013-08-21</date>
        /// <summary>
        /// Define whether this is a special space, or not.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is special space;
        /// otherwise, <c>false</c>.
        /// </value>
        public bool IsSpecialSpace { get; private set; }


        /// <author>Kyle Maher</author>
        /// <date>2013-08-21</date>
        /// <summary>
        /// Define the specific special type of this space
        /// </summary>
        public SpecialSpaces SpecialSpaceType { get; private set; }


        /// <author>Kyle Maher</author>
        /// <date>2013-08-21</date>
        /// <summary>
        /// Define the group that this space belongs to.
        /// </summary>
        public Groups Group { get; private set; }

        public String Name { get; set;}

        public Decimal Price { get; private set; }

        #endregion

        #region "Constructor"

        /// <author>Kylddddddddde Maher</author>
        /// <date>2013-08-21</date>
        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <remarks>
        /// Set reasonable default values for public properties.
        /// </remarks>
        public BoardSpace()
        {
            SpecialSpaceType = SpecialSpaces.None;
            Group = Groups.Other;
        }


        /// <summary>
        /// SpecialSpace constructor
        /// Create a new special space.
        /// </summary>
        public BoardSpace(SpecialSpaces specialSpaceType)
        {
            if (specialSpaceType != SpecialSpaces.None)
                IsSpecialSpace = true;

            SpecialSpaceType = specialSpaceType;
        }


        /// <author>Kyle Maher</author>
        /// <Date>2013-08-10</DateTime>
        /// <summary>
        /// Normal Space constructor.
        /// </summary>
        public BoardSpace(Groups group, string name, decimal price)
        {
            Group = group;
            Name = name;
            Price = price;

        }

        #endregion

    }
}

