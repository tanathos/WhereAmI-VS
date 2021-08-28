using System.ComponentModel;

namespace WhereAmI
{
    /// <summary>
    /// Available positions for the adornment layer
    /// </summary>
    public enum AdornmentPositions
    {
        [Description("Top-right corner")]
        /// <summary>
        /// Top-right corner of the view
        /// </summary>
        TopRight,

        [Description("Bottom-right corner")]
        /// <summary>
        /// Bottom-right corner of the view
        /// </summary>
        BottomRight,

        [Description("Top-left corner")]
        /// <summary>
        /// Top-left corner of the view
        /// </summary>
        TopLeft,

        [Description("Bottom-left corner")]
        /// <summary>
        /// Bottom-left corner of the view
        /// </summary>
        BottomLeft,
    }
}
