using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Gestion_parc
{
    class Themes
    {
        public enum ColorTheme { Standard, Second, Third, Light, Dark };
        public ColorTheme SelectedTheme { get; set; }
        public Color Primary1
        {
            get
            {
                switch (this.SelectedTheme)
                {
                    case ColorTheme.Standard:
                            return Color.FromArgb(245, 139, 0);
                    case ColorTheme.Second:
                            return Color.FromArgb(245, 139, 0);
                    case ColorTheme.Third:
                            return Color.FromArgb(245, 139, 0);
                    case ColorTheme.Light:
                            return Color.FromArgb(245, 139, 0);
                    case ColorTheme.Dark:
                            return Color.FromArgb(245, 139, 0);
                    default:
                            return Color.FromArgb(245, 139, 0);
                }
            }
            set
            {
                this.Primary1 = value;
            }
        }
        public Color Primary2
        {
            get
            {
                switch (this.SelectedTheme)
                {
                    case ColorTheme.Standard:
                        return Color.FromArgb(99, 170, 227);
                    case ColorTheme.Second:
                        return Color.FromArgb(245, 139, 0);
                    case ColorTheme.Third:
                        return Color.FromArgb(245, 139, 0);
                    case ColorTheme.Light:
                        return Color.FromArgb(245, 139, 0);
                    case ColorTheme.Dark:
                        return Color.FromArgb(245, 139, 0);
                    default:
                        return Color.FromArgb(245, 139, 0);
                }
            }
            set
            {
                this.Primary2 = value;
            }
        }
        public Color Secondary
        {
            get
            {
                switch (this.SelectedTheme)
                {
                    case ColorTheme.Standard:
                        return Color.FromArgb(66, 75, 84);
                    case ColorTheme.Second:
                        return Color.FromArgb(245, 139, 0);
                    case ColorTheme.Third:
                        return Color.FromArgb(245, 139, 0);
                    case ColorTheme.Light:
                        return Color.FromArgb(245, 139, 0);
                    case ColorTheme.Dark:
                        return Color.FromArgb(245, 139, 0);
                    default:
                        return Color.FromArgb(66, 75, 84);
                }
            }
            set
            {
                this.Secondary = value;
            }
        }
        public Color Accent1
        {
            get
            {
                switch (this.SelectedTheme)
                {
                    case ColorTheme.Standard:
                        return Color.FromArgb(232, 229, 218);
                    case ColorTheme.Second:
                        return Color.FromArgb(245, 139, 0);
                    case ColorTheme.Third:
                        return Color.FromArgb(245, 139, 0);
                    case ColorTheme.Light:
                        return Color.FromArgb(245, 139, 0);
                    case ColorTheme.Dark:
                        return Color.FromArgb(245, 139, 0);
                    default:
                        return Color.FromArgb(232, 229, 218);
                }
            }
            set
            {
                this.Accent1 = value;
            }
        }
        public Color Accent2
        {
            get
            {
                switch (this.SelectedTheme)
                {
                    case ColorTheme.Standard:
                        return Color.FromArgb(254, 252, 253);
                    case ColorTheme.Second:
                        return Color.FromArgb(245, 139, 0);
                    case ColorTheme.Third:
                        return Color.FromArgb(245, 139, 0);
                    case ColorTheme.Light:
                        return Color.FromArgb(245, 139, 0);
                    case ColorTheme.Dark:
                        return Color.FromArgb(245, 139, 0);
                    default:
                        return Color.FromArgb(254, 252, 253);
                }
            }
            set
            {
                this.Accent2 = value;
            }
        }
        
    }
}
