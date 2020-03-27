﻿using System;
using System.Collections.Generic;
using System.Text;
using Uno.Players;

namespace Uno.EventsComponents
{
    class EventArgsPlayer
    {
        Player mPlayer;

        public EventArgsPlayer(Player pPlayer)
        {
            mPlayer = pPlayer;
        }

        public Player ChosenPlayer
        {
            get { return this.mPlayer; }
        }
    }
}
