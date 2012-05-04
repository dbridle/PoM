using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Intermediate;

namespace PoMLibrary
{
    public class GlobalFunctions
    {

        static Random rnd = new Random();

        public static short GetRandomNumber(DieType die)
        {
            return (short)rnd.Next(1, (int)die + 1);
        }

        public static int GetRandomNumber(int min, int max)
        {
            return rnd.Next(min, max + 1);
        }

        public static int GetRangeAmount(String amount)
        {
            String min, max;

            min = amount.Substring(0, amount.IndexOf("-"));
            max = amount.Substring(amount.IndexOf("-") + 1);

            return GetRandomNumber(Convert.ToInt32(min), Convert.ToInt32(max));
        }

        public static int GetRandomHPDieTotal(int level, DieType type)
        {
            int total = 0;

            for (int i = 1; i <= level; i++)
                total += GetRandomNumber(type);

            return total;
        }

        public static bool IsNumeric(object Expression)
        {
            bool isNum;

            // Define variable to collect out parameter of the TryParse method. If the conversion fails, the out parameter is zero.
            double retNum;

            // The TryParse method converts a string in a specified style and culture-specific format to its double-precision floating point number equivalent.
            // The TryParse method does not generate an exception if the conversion fails. If the conversion passes, True is returned. If it does not, False is returned.
            isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }

        public static Stat LoadStat(string filename)
        {
            try
            {
                XmlReader reader = XmlReader.Create(new FileStream(filename, FileMode.Open));

                Stat stat = IntermediateSerializer.Deserialize<Stat>(reader, null);

                reader.Close();
                return stat;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static Race LoadRace(string filename)
        {
            try
            {
                XmlReader reader = XmlReader.Create(new FileStream(filename, FileMode.Open));

                Race race = IntermediateSerializer.Deserialize<Race>(reader, null);

                reader.Close();
                return race;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static Entity LoadEntity(string filename)
        {
            try
            {
                XmlReaderSettings settings = new XmlReaderSettings();

                settings.CloseInput = true;

                XmlReader reader = XmlReader.Create(new FileStream(filename, FileMode.Open), settings);

                Entity entity = IntermediateSerializer.Deserialize<Entity>(reader, null);

                reader.Close();

                return entity;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static EntityClass LoadClass(string filename)
        {
            try
            {
                XmlReaderSettings settings = new XmlReaderSettings();

                settings.CloseInput = true;

                XmlReader reader = XmlReader.Create(new FileStream(filename, FileMode.Open), settings);

                EntityClass entityclass = IntermediateSerializer.Deserialize<EntityClass>(reader, null);

                reader.Close();

                return entityclass;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static Skill LoadSkill(string filename)
        {
            try
            {
                XmlReaderSettings settings = new XmlReaderSettings();

                settings.CloseInput = true;

                XmlReader reader = XmlReader.Create(new FileStream(filename, FileMode.Open), settings);

                Skill skill = IntermediateSerializer.Deserialize<Skill>(reader, null);

                reader.Close();

                return skill;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static int GetSPForStat(int statValue)
        {
            int ret = 0;

            //TODO: placeholder for now
            ret = (int)(statValue / 20);

            return ret;
        }

        public static int CalculateSkillBonus(int levels)
        {
            int ret = 0;

            //graduated value for levels
            if (levels <= 5)
                ret = levels * 5;
            else if (levels <= 10)
                ret = 25 + ((levels - 5) * 3);
            else if (levels <= 15)
                ret = 40 + ((levels - 10) * 2);
            else
                ret = 50 + (levels - 15);

            return ret;
        }
    }
    
    public class GlobalData
    {
        public static Dictionary<int, Skill> Skills;
    }
}
