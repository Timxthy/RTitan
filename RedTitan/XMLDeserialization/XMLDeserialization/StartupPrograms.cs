using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("StartUpPrograms")]
public class StartUpPrograms
{
    [XmlArray("Programs")]
    [XmlArrayItem("Program")]
    public List<XmlProgram> Programs { get; set; }
}

public class XmlProgram
{
    public string Path { get; set; }
    public string Arguments { get; set; }
    public bool AutoStart { get; set; }
    public string MinProductVersion { get; set; }
}
