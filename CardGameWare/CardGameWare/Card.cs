using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameWar
{
    // <summary>
    // Representation of a playing card in the game.
    // </summary>
    class Card
    {
        private int id;

        public int GetId()
        {
            return id;
        }

        public void SetId(int value)
        {
            id = value;
        }

        private int value;

        public int GetValue()
        {
            return value;
        }

        public void SetValue(int value)
        {
            this.value = value;
        }

        private string suit;

        public string GetSuit()
        {
            return suit;
        }

        public void SetSuit(string value)
        {
            suit = value;
        }

        private string name;

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }

        private string img;

        public string GetImg()
        {
            return img;
        }

        public void SetImg(string value)
        {
            img = value;
        }
    }
}
