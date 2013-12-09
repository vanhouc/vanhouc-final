//By: Cameron VanHouzen
//Date: 12/9/2013
//The data repository encapsulates functions to read and write to a database
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using Music.Properties;

namespace Music
{
    /// <summary>
    /// This class encapsulates reading from a database
    /// </summary>
    public class DataRepository
    {
        SqlConnection dbconn = new SqlConnection(Music.Properties.Settings.Default.orchestraConnection);
        SqlCommand dbcomm;
        SqlDataReader dbreader;
        /// <summary>
        /// Gets a list of Instrument objects filtered by a section
        /// </summary>
        /// <param name="selectedSection">A section to filter instruments by</param>
        /// <returns></returns>
        public List<Instrument> GetInstruments(Section selectedSection)
        {
            using (dbconn)
            {
                dbcomm = new SqlCommand("select Instrument, Type from Instruments where Type = " + selectedSection.ToString() + " order by asc", dbconn);
                dbreader = dbcomm.ExecuteReader();
                List<Instrument> instruments = new List<Instrument>();
                while (dbreader.Read())
                {
                    string instrumentName = dbreader["Instrument"].ToString();
                    Section instrumentType;
                    switch (dbreader["Type"].ToString())
                    {
                        case "String":
                            instrumentType = Section.String;
                            break;
                        case "Woodwind":
                            instrumentType = Section.Woodwind;
                            break;
                        case "Brass":
                            instrumentType = Section.Brass;
                            break;
                        case "Percussion":
                            instrumentType = Section.Percussion;
                            break;
                        default:
                            throw new ArgumentException("Invalid type detected: " + dbreader["Type"].ToString());
                    }
                    instruments.Add(new Instrument(instrumentName, instrumentType));
                }
                return instruments;
            }
        }
        /// <summary>
        /// Gets a list of Instrument objects filtered by an array of Sections
        /// </summary>
        /// <param name="selectedSection">An array to filter instruments by</param>
        /// <returns></returns>
        public List<Instrument> GetInstruments(Section[] selectedSection)
        {
            using (dbconn)
            {
                String.Format("({0})", selectedSection.ToString());
                dbcomm = new SqlCommand("select Instrument, Type from Instruments where Type in " + selectedSection.ToString() + " order by asc", dbconn);
                dbreader = dbcomm.ExecuteReader();
                List<Instrument> instruments = new List<Instrument>();
                while (dbreader.Read())
                {
                    string instrumentName = dbreader["Instrument"].ToString();
                    Section instrumentType;
                    switch (dbreader["Type"].ToString())
                    {
                        case "String":
                            instrumentType = Section.String;
                            break;
                        case "Woodwind":
                            instrumentType = Section.Woodwind;
                            break;
                        case "Brass":
                            instrumentType = Section.Brass;
                            break;
                        case "Percussion":
                            instrumentType = Section.Percussion;
                            break;
                        default:
                            throw new ArgumentException("Invalid type detected: " + dbreader["Type"].ToString());
                    }
                    instruments.Add(new Instrument(instrumentName, instrumentType));
                }
                return instruments;
            }
        }
        /// <summary>
        /// Returns a list of Instrument objects representing all the instruments in the database
        /// </summary>
        /// <returns></returns>
        public List<Instrument> GetInstruments()
        {
            dbcomm = new SqlCommand("select Instrument, Type from Instruments order by asc", dbconn);
            dbreader = dbcomm.ExecuteReader();
            List<Instrument> instruments = new List<Instrument>();
            while (dbreader.Read())
            {
                string instrumentName = dbreader["Instrument"].ToString();
                Section instrumentType;
                switch (dbreader["Type"].ToString())
                {
                    case "String":
                        instrumentType = Section.String;
                        break;
                    case "Woodwind":
                        instrumentType = Section.Woodwind;
                        break;
                    case "Brass":
                        instrumentType = Section.Brass;
                        break;
                    case "Percussion":
                        instrumentType = Section.Percussion;
                        break;
                    default:
                        throw new ArgumentException("Invalid type detected: " + dbreader["Type"].ToString());
                }
                instruments.Add(new Instrument(instrumentName, instrumentType));
            }
            return instruments;
        }
    }
}
