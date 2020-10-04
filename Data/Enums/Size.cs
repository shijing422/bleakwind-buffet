/*
 * Author: Shijing Zhang
 * Class name: Size.cs
 * Purpose: Class used to represent sizes through an enumeration
 */
using System.ComponentModel;
namespace BleakwindBuffet.Data.Enums
{
    /// <summary>
    /// Provides available sizes
    /// </summary>
    public enum Size
    {
        [Description("Small")]
        Small,
        [Description("Medium")]
        Medium,
        [Description("Large")]
        Large
    }
}