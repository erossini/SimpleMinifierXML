using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLMinimizer
{
    /// <summary>
    /// Config object for the XML minifier.
    /// </summary>
    public class XMLMinifierSettings
    {
        public bool RemoveEmptyLines { get; set; }
        public bool RemoveWhitespaceBetweenElements { get; set; }
        public bool CloseEmptyTags { get; set; }
        public bool RemoveComments { get; set; }

        public static XMLMinifierSettings Aggressive
        {
            get
            {
                return new XMLMinifierSettings
                {
                    RemoveEmptyLines = true,
                    RemoveWhitespaceBetweenElements = true,
                    CloseEmptyTags = true,
                    RemoveComments = true
                };
            }
        }

        public static XMLMinifierSettings NoMinification
        {
            get
            {
                return new XMLMinifierSettings
                {
                    RemoveEmptyLines = false,
                    RemoveWhitespaceBetweenElements = false,
                    CloseEmptyTags = false,
                    RemoveComments = false
                };
            }
        }
    }
}
