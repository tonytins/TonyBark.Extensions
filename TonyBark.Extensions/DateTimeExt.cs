// This project is licensed under the MIT license.
// See the LICENSE file in the project root for more information.
using System;

namespace TonyBark.Extensions
{
    public static class DateTimeOffsetTxt
    {
        /// <summary>
        /// The Holocene year adds exactly 10,000 years to
        /// the currently dominant (AD/BC or CE/BCE) numbering scheme.
        /// </summary>
        /// <returns>Holocene Year</returns>
        public static int GetHoloceneYear(this DateTimeOffset dt) => dt.Year + 10000;
    }

    public static class DateTimeExt
    {
        /// <summary>
        /// The Holocene year adds exactly 10,000 years to
        /// the currently dominant (AD/BC or CE/BCE) numbering scheme.
        /// </summary>
        /// <returns>Holocene Year</returns>
        public static int GetHoloceneYear(this DateTime dt) => dt.Year + 10000;
    }
}
