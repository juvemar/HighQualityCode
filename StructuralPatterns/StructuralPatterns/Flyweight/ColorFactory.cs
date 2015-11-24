namespace Flyweight
{
    using System.Collections.Generic;

    public class ColorFactory
    {
        private readonly Dictionary<string, Color> colors = new Dictionary<string, Color>();

        public int NumberOfObjects
        {
            get
            {
                return this.colors.Count;
            }
        }

        public Color GetColor(string colorName)
        {
            Color color = null;
            if (this.colors.ContainsKey(colorName))
            {
                color = this.colors[colorName];
            }
            else
            {
                switch (colorName)
                {
                    case "red":
                        color = new RedColor();
                        break;
                    case "blue":
                        color = new BlueColor();
                        break;
                }

                this.colors.Add(colorName, color);
            }

            return color;
        }
    }
}
