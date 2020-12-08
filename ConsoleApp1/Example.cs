using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    [Serializable]
    public class Example
    {
        [XmlElement("Content")]
        public Content Content { get; set; }

        [XmlArray("Path")]
        public Segment[] Path { get; set; }
        [XmlElement("Species")]
        public XEnum Species { get; set; }

        public Example()
        {

        }
    }

    //[Serializable]
    public class Content
    {
        [XmlElement("Head")]
        public string Title { get; set; }

        [XmlAttribute("Body")]
        public string Subtitle { get; set; }

        [XmlAttribute("Kill")]
        public int Kill { get; set; }
    }

    public class Segment
    {
        [XmlAttribute("Id")]
        public int Ment { get; set; }
    }

    public enum XEnum
    {
        [XmlEnum(Name = "Xenomorph")]
        Xenomorph = 1,
        [XmlEnum(Name = "Human")]
        Human = 2
    }

    public partial class Partial
    {
        public string Name { get; set; }

        public Partial(string name)
        {
            Name = name;
        }
    }
}
