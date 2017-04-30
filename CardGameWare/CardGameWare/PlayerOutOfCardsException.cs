using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameWar
{
    class PlayerOutOfCardsException: Exception
    {
        public PlayerOutOfCardsException()
        {
        }

        public PlayerOutOfCardsException(string message)
        : base(message)
        {
        }

        public PlayerOutOfCardsException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
