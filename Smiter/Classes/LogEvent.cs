using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Smiter.Classes
{
    //List<string> LogEventClass = new List<string> { "Start", "taskkill", "Close" };
    //List<string> LogEventType = new List<string> { "success", "warning", "error", "informative" };
    static class LogEventMisc
    {
        public static string GetEType(int ETypeIndex)
        {
            switch (ETypeIndex)
            {
                default:
                case 0:
                    return "informative";
                case 1:
                    return "success";
                case 2:
                    return "warning";
                case 3:
                    return "error";
            }
        }
        public static Color GetEColour(int ETypeIndex)
        {
            switch (ETypeIndex)
            {
                default:
                case 0:
                    return Color.Blue;
                case 1:
                    return Color.Green;
                case 2:
                    return Color.DarkOrange;
                case 3:
                    return Color.Red;
            }
        }

        public static string GetEClass(int EClassIndex)
        {
            switch (EClassIndex)
            {
                default:
                case 0:
                    return "Start";
                case 1:
                    return "General";
                case 2:
                    return "Close";
                case 3:
                    return "taskkill";
            }
        }
    }
    public class LogEvent
    {
        public int Type { get; set; }

        public string Event { get; set; }

        public int Class { get; set; }

        public DateTime Timestamp { get; set; }

        public LogEvent(int TypeC, string EventC, int ClassC)
        {
            Type = TypeC;
            Event = EventC;
            Class = ClassC;
            Timestamp = DateTime.Now;
        }

        public override string ToString() => string.Format("{0} - {1} - {2}", Timestamp.ToString(), LogEventMisc.GetEClass(Class), Event);
        public Dictionary<string, object> ToFormattedString() => new Dictionary<string, object> { 
            { "Text", string.Format("{0} - {1} - {2}", Timestamp.ToString(), LogEventMisc.GetEClass(Class), Event) }, 
            { "ForeColor", LogEventMisc.GetEColour(Type) }
        };
    }
}
