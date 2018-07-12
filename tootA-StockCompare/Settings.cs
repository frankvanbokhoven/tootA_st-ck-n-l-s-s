using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace ChampionCharts
{
    [Serializable]
    public class Settings
    {
        int _numDays = 90;
        int _movingAverageDays = 20;
        int _exponentialMovingAverageDays = 0;
        ChartType _chartType = ChartType.Line;
        Color _guidelineColor = Color.DarkGray;
        Color _foregroundColor = Color.Blue;
        Color _backgroundColor = Color.White;
        Color _indicatorColor = Color.DarkGreen;
        Boolean _showVolume = true;
        Boolean _hideWeekends = true;
        Boolean _roundScaling = true;
        Boolean _antiAliasing = true;
        Boolean _showDividends = true;
        Boolean _showSplits = true;

        public int NumDays
        {
            get { return _numDays; }
            set { _numDays = value; }
        }

        public int MovingAverageDays
        {
            get { return _movingAverageDays; }
            set { _movingAverageDays = value; }
        }

        public int ExponentialMovingAverageDays
        {
            get { return _exponentialMovingAverageDays; }
            set { _exponentialMovingAverageDays = value;}
        }

        [XmlIgnore]
        public Color GuidelineColor
        {
            get { return _guidelineColor; }
            set { _guidelineColor = value; }
        }

        [XmlIgnore]
        public Color ForegroundColor
        {
            get { return _foregroundColor; }
            set { _foregroundColor = value; }
        }

        [XmlIgnore]
        public Color BackgroundColor
        {
            get { return _backgroundColor; }
            set { _backgroundColor = value;}
        }

        [XmlIgnore]
        public Color IndicatorColor
        {
            get { return _indicatorColor; }
            set { _indicatorColor = value;  }
        }

        [XmlElement("GuidelineColor")]
        public string GuidelineColorHtml
        {
            get { return ColorTranslator.ToHtml(_guidelineColor); }
            set { _guidelineColor = ColorTranslator.FromHtml(value); }
        }

        [XmlElement("ForegroundColor")]
        public string ForegroundColorHtml
        {
            get { return ColorTranslator.ToHtml(_foregroundColor); }
            set { _foregroundColor = ColorTranslator.FromHtml(value); }
        }

        [XmlElement("BackgroundColor")]
        public string BackgroundColorHtml
        {
            get { return ColorTranslator.ToHtml(_backgroundColor); }
            set { _backgroundColor = ColorTranslator.FromHtml(value); }
        }

        [XmlElement("IndicatorColor")]
        public string IndicatorColorHtml
        {
            get { return ColorTranslator.ToHtml(_indicatorColor); }
            set { _indicatorColor = ColorTranslator.FromHtml(value); }
        }

        public ChartType ChartTypeSetting
        {
            get { return _chartType; }
            set { _chartType = value; }
        }

        public Boolean ShowVolume
        {
            get { return _showVolume; }
            set { _showVolume = value; }
        }

        public Boolean ShowDividends
        {
            get { return _showDividends; }
            set { _showDividends = value; }
        }

        public Boolean ShowSplits
        {
            get { return _showSplits; }
            set { _showSplits = value; }
        }

        public Boolean AntiAliasing
        {
            get { return _antiAliasing; }
            set { _antiAliasing = value; }
        }

        public Boolean HideWeekends
        {
            get { return _hideWeekends; }
            set { _hideWeekends = value;}
        }

        public Boolean RoundScaling
        {
            get { return _roundScaling; }
            set { _roundScaling = value; }
        }

        public void Save()
        {
            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\ChampionCharts");
            StreamWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\ChampionCharts\\settings.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(Settings));
            serializer.Serialize(writer, this);
            writer.Flush();
            writer.Close();
        }

        public static Settings Load()
        {
            try
            {
                StreamReader reader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\ChampionCharts\\settings.xml");
                XmlSerializer serializer = new XmlSerializer(typeof(Settings));
                Settings settings = (Settings)(serializer.Deserialize(reader));
                reader.Close();
                return settings;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
