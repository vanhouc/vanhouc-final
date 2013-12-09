//By: Cameron VanHouzen
//Date: 12/9/2013
//The Instrument class represents an Instrument: Name and Category
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Music
{
    /// <summary>
    /// A Class representing an Instrument
    /// </summary>
    class Instrument
    {
        TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
        Regex reg = new Regex("[A-Z]+\\w*");
        private string _name;
        /// <summary>
        /// The Name of the Instrument
        /// </summary>
        public string Name
        {
            get 
            {
                return _name; 
            }
            set
            {
                if (reg.IsMatch(value))
                    _name = myTI.ToTitleCase(value.Trim());
                else
                    throw new ArgumentException("You done screwed up: "+ value);
            }
        }
        /// <summary>
        /// The Musical Category of the instrument, represented as a Music.Section Enum
        /// </summary>
        public Section Category { get; set; }
        /// <summary>
        /// Default Constructor for Instrument returns Unnamed Brass instrument
        /// </summary>
        public Instrument()
        {
            Name = "Unnamed";
            Category = Section.Brass;
        }
        /// <summary>
        /// Constructor that takes the name and category of an instrument
        /// </summary>
        /// <param name="name">The name of the Instrument</param>
        /// <param name="category">The category of the instrument, represented as a Music.Section Enum</param>
        public Instrument(string name, Section category)
        {
            Name = name;
            Category = category;
        }
        /// <summary>
        /// Returns Instrument info on a single line
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("Name: {0} Category: {1}", Name, Category);
        }
    }
}
