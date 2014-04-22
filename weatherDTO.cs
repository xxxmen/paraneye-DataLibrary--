
#region WeatherDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: WeatherDTO.cs
// Author: 
// Date: July-22-11
// Time: 3:11:08 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class WeatherDTO : DTOBase
    {
        public int WeatherID { get; set; }
        public int CityLUID { get; set; }
        public string CityName { get; set; }
        public DateTime WeatherDate { get; set; }
        [XmlElement(IsNullable = true)]
        public string DataQuality { get; set; }
        public decimal MaxTempC { get; set; }
        [XmlElement(IsNullable = true)]
        public string MaxTempFlag { get; set; }
        public decimal MinTemp { get; set; }
        [XmlElement(IsNullable = true)]
        public string MinTempFlag { get; set; }
        public decimal MeanTempC { get; set; }
        [XmlElement(IsNullable = true)]
        public string MeanTempFlag { get; set; }
        public decimal HeatDegDaysC { get; set; }
        [XmlElement(IsNullable = true)]
        public string HeatDegDaysFlag { get; set; }
        public decimal CoolDegDaysC { get; set; }
        [XmlElement(IsNullable = true)]
        public string CoolDegDaysFlag { get; set; }
        public decimal TotalRainmm { get; set; }
        [XmlElement(IsNullable = true)]
        public string TotalRainFlag { get; set; }
        public decimal TotalSnowcm { get; set; }
        [XmlElement(IsNullable = true)]
        public string TotalSnowFlag { get; set; }
        public decimal TotalPrecipmm { get; set; }
        [XmlElement(IsNullable = true)]
        public string TotalPrecipFlag { get; set; }
        public decimal SnowonGrndcm { get; set; }
        [XmlElement(IsNullable = true)]
        public string SnowonGrndFlag { get; set; }
        [XmlElement(IsNullable = true)]
        public string DirofMaxGust10sdeg { get; set; }
        [XmlElement(IsNullable = true)]
        public string DirofMaxGustFlag { get; set; }        
        public decimal SpdofMaxGustkmh { get; set; }
        [XmlElement(IsNullable = true)]
        public string SpdofMaxGustFlag { get; set; }
        

        // Constructor
        public WeatherDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
