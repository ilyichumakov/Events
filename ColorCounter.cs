using System;
using System.Collections.Generic;
using System.Drawing;

namespace Events
{
    public class ColorCounter
    {
        private Dictionary<Color, int> colors;

        public ColorCounter()
        {
            colors = new Dictionary<Color, int>();
        }

        public ColorCounter(Dictionary<Color, int> c)
        {
            colors = new Dictionary<Color, int>(c);
        }

        public void IncrementColor(Color c)
        {
            if (!colors.ContainsKey(c))
                colors.Add(c, 0);
            colors[c]++;
        }

        public string getStats()
        {
            string res = "";
            foreach(KeyValuePair<Color, int> c in colors)
            {
                res += c.Key.Name + " " + c.Value.ToString() + ";   ";
            }
            return res;
        }
    }
}
