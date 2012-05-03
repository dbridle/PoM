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


    }
}
