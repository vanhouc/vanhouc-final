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
        SqlConnection dbconn;
        SqlCommand dbcomm;
        SqlDataReader dbreader;
        /// <summary>
        /// Gets a list of Instrument objects filtered by a section
        /// </summary>
        /// <param name="selectedSection">A section to filter instruments by</param>
        /// <returns></returns>
        //public List<Instrument> GetInstruments(Section selectedSection)
        //{
        //    using (dbconn = new SqlConnection(Music.Properties.Settings.Default.orchestraConnection))
        //    {
        //        dbconn.Open();
        //        dbcomm = new SqlCommand(String.Format("select Instrument, Type from Instruments where Type = '{0}' order by Type asc",selectedSection.ToString()), dbconn);
        //        dbreader = dbcomm.ExecuteReader();
        //        List<Instrument> instruments = new List<Instrument>();
        //        while (dbreader.Read())
        //        {
        //            string instrumentName = dbreader["Instrument"].ToString();
        //            Section instrumentType;
        //            if (Enum.TryParse<Section>(dbreader["Type"].ToString(), true, out instrumentType))
        //                instruments.Add(new Instrument(instrumentName, instrumentType));
        //            else
        //                instruments.Add(new Instrument());
        //        }
        //        dbconn.Close();
        //        return instruments;
        //    }
        //}
        /// <summary>
        /// Gets a list of Instrument objects filtered by an array of Sections
        /// </summary>
        /// <param name="selectedSection">An array to filter instruments by</param>
        /// <returns></returns>
        public List<Instrument> GetInstruments(Section[] selectedSection)
        {
            using (dbconn = new SqlConnection(Music.Properties.Settings.Default.orchestraConnection))
            {
                dbconn.Open();
                //This command creates a sql string that checks for instruments of a type contained in the parameter list which is created by using a string join and some string formats
                dbcomm = new SqlCommand(String.Format("select Instrument, Type from Instruments where Type in({0}) order by Instrument asc", String.Join(",",selectedSection.Select(x => String.Format("'{0}'",x.ToString())).ToArray())), dbconn);
                dbreader = dbcomm.ExecuteReader();
                List<Instrument> instruments = new List<Instrument>();
                while (dbreader.Read())
                {
                    string instrumentName = dbreader["Instrument"].ToString();
                    Section instrumentType;
                    //This sneaky little section tries to parse the instrument value of the instrument by using the Enum.TryParse which returns a bool, if false there is a bad type and a default instrument replaces it
                    if (Enum.TryParse<Section>(dbreader["Type"].ToString(), true, out instrumentType))
                        instruments.Add(new Instrument(instrumentName, instrumentType));
                    else
                        instruments.Add(new Instrument());
                }
                return instruments;
            }
        }
        /// <summary>
        /// Returns a list of Instrument objects representing all the instruments in the database
        /// </summary>
        /// <returns></returns>
        //public List<Instrument> GetInstruments()
        //{
        //    using (dbconn = new SqlConnection(Music.Properties.Settings.Default.orchestraConnection))
        //    {
        //        dbconn.Open();
        //        dbcomm = new SqlCommand(String.Format("select Instrument, Type from Instruments order by Type asc"), dbconn);
        //        dbreader = dbcomm.ExecuteReader();
        //        List<Instrument> instruments = new List<Instrument>();
        //        while (dbreader.Read())
        //        {
        //            string instrumentName = dbreader["Instrument"].ToString();
        //            Section instrumentType;
        //            if (Enum.TryParse<Section>(dbreader["Type"].ToString(), true, out instrumentType))
        //                instruments.Add(new Instrument(instrumentName, instrumentType));
        //            else
        //                instruments.Add(new Instrument());
        //        }
        //        dbconn.Close();
        //        return instruments;
        //    }
        //}
    }
}
