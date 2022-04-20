XmlDocument parser = new XmlDocument();
parser.XmlResolver = new XmlUrlResolver(); // Noncompliant: XmlDocument.XmlResolver configured with XmlUrlResolver that makes it unsafe
parser.LoadXml("xxe.xml");

