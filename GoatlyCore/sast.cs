using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using vulnerable_asp_net_core.Models;
using System.Data.SQLite;
using System.IO;
using System.Net;
using System.Text.Encodings.Web;
using System.Xml;
using System.Xml.Serialization;

XmlDocument parser = new XmlDocument();
parser.XmlResolver = new XmlUrlResolver(); // Noncompliant: XmlDocument.XmlResolver configured with XmlUrlResolver that makes it unsafe
parser.LoadXml("xxe.xml");

