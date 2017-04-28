using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameWar
{
    class Player
    {
        private string name;

        private string GetName()
        {
            return name;
        }

        private void SetName(string value)
        {
            name = value;
        }

        private List<Card> hand;
    }
}
