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
using System.Collections.Generic;

namespace P07r0457.Monopoly.Engine
{
    public class GameBoard
    {

        /// <summary>
        /// Collection of board spaces
        /// </summary>
        public IList<BoardSpace> BoardSpaces;


        public GameBoard()
        {
            BoardSpaces = BuildBoardSpaces();
        }


        /// <author>Kyle Maher</author>e
        /// Return a colletion
        /// Resul
        /// <summary>
        /// Build the board.
        /// </summary>
        /// <returns>The board spaces.</returns>
        private static IList<BoardSpace> BuildBoardSpaces()
        {
            var results = new List<BoardSpace>();

            results.Add(new BoardSpace(BoardSpace.SpecialSpaces.Go));
            results.Add(new BoardSpace(BoardSpace.Groups.DarkBlue, "Mediterranean Avenue", 60));
            results.Add(new BoardSpace(BoardSpace.SpecialSpaces.CommunityChest));
            results.Add(new BoardSpace(BoardSpace.Groups.DarkBlue, "Mediterranean Avenue", 60));
            results.Add(new BoardSpace(BoardSpace.SpecialSpaces.IncomeTax));
            results.Add(new BoardSpace(BoardSpace.Groups.RailRoad, "Reading Railroad", 200));
            results.Add(new BoardSpace(BoardSpace.Groups.LightBlue, "Oriental Avenue", 100));
            results.Add(new BoardSpace(BoardSpace.SpecialSpaces.Chance));
            results.Add(new BoardSpace(BoardSpace.Groups.LightBlue, "Vermont Avenue", 100));
            results.Add(new BoardSpace(BoardSpace.Groups.LightBlue, "Connecticut Avenue", 120));

            results.Add(new BoardSpace(BoardSpace.SpecialSpaces.Jail));
            results.Add(new BoardSpace(BoardSpace.Groups.Purple, "St. Charles Place", 140));
            results.Add(new BoardSpace(BoardSpace.Groups.Utilities, "Electric Company", 150));
            results.Add(new BoardSpace(BoardSpace.Groups.Purple, "States Avenue", 140));
            results.Add(new BoardSpace(BoardSpace.Groups.Purple, "Virginia Avenue", 160));
            results.Add(new BoardSpace(BoardSpace.Groups.RailRoad, "Pennsylvania Railroad", 200));
            results.Add(new BoardSpace(BoardSpace.Groups.Orange, "St. James Place", 180));
            results.Add(new BoardSpace(BoardSpace.SpecialSpaces.CommunityChest));
            results.Add(new BoardSpace(BoardSpace.Groups.Orange, "Tennessee Avenue", 180));
            results.Add(new BoardSpace(BoardSpace.Groups.Orange, "New York Avenue", 200));

            results.Add(new BoardSpace(BoardSpace.SpecialSpaces.FreeParking));
            results.Add(new BoardSpace(BoardSpace.Groups.Red, "Kentucky Avenue", 220));
            results.Add(new BoardSpace(BoardSpace.SpecialSpaces.Chance));
            results.Add(new BoardSpace(BoardSpace.Groups.Red, "Indiana Avenue", 220));
            results.Add(new BoardSpace(BoardSpace.Groups.Red, "Illinois Avenue", 240));
            results.Add(new BoardSpace(BoardSpace.Groups.RailRoad, "B. & O. Railroad", 200));
            results.Add(new BoardSpace(BoardSpace.Groups.Yellow, "Atlantic Avenue", 260));
            results.Add(new BoardSpace(BoardSpace.Groups.Yellow, "Ventnor Avenue", 260));
            results.Add(new BoardSpace(BoardSpace.Groups.Utilities, "Water Works", 150));
            results.Add(new BoardSpace(BoardSpace.Groups.Yellow, "Marvin Gardens", 280));

            results.Add(new BoardSpace(BoardSpace.SpecialSpaces.GoToJail));
            results.Add(new BoardSpace(BoardSpace.Groups.Green, "Pacific Avenue", 300));
            results.Add(new BoardSpace(BoardSpace.Groups.Green, "North Carolina Avenue", 300));
            results.Add(new BoardSpace(BoardSpace.SpecialSpaces.CommunityChest));
            results.Add(new BoardSpace(BoardSpace.Groups.Green, "Pennsylvania Avenue", 320));
            results.Add(new BoardSpace(BoardSpace.Groups.RailRoad, "Short Line", 200));
            results.Add(new BoardSpace(BoardSpace.SpecialSpaces.Chance));
            results.Add(new BoardSpace(BoardSpace.Groups.Blue, "Park Place", 350));
            results.Add(new BoardSpace(BoardSpace.SpecialSpaces.LuxuryTax));
            results.Add(new BoardSpace(BoardSpace.Groups.Blue, "Boardwalk", 400));

            return results;
        }
        
    }
}

