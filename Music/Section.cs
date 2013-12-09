//By: Cameron VanHouzen
//Date: 12/9/2013
//The Section Enum is used to identify the type of an instrument, eh /canadian>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    /// <summary>
    /// This enum contains definititions for types of instruments
    /// </summary>
    public enum Section
    {
        /// <summary>
        /// A String Instrument
        /// </summary>
        String,
        /// <summary>
        /// A Woodwind Instrument
        /// </summary>
        Woodwind,
        /// <summary>
        /// A Brass Instrument
        /// </summary>
        Brass,
        /// <summary>
        /// A Percussion Instrument
        /// </summary>
        Percussion
    }
}
