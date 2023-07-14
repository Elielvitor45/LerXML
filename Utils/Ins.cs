using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LeituraXml.Utils
{
    public class Ins
    {
       
        public string Id { get; set; }
        public string CTA { get; set; }
        public string Source { get; set; }
        public string MovedTo { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string File { get; set; }
        public string Folder { get; set; }
        public string Text { get; set; }
        public string Composer { get; set; }
        public string Comment { get; set; } 
        public string Checked { get; set; }
        public string Err { get; set; }
        public string sErr { get; set; }
        public string HoraAudio { get; set; }
        public string HoraPK { get; set; }
        public string IsAudioFile { get; set; }
        public string DurOrig { get; set; }
        public string Dur { get; set; }
        public string Refr { get; set; }
        public string DurRefr { get; set; }
        public string PtVh { get; set; }
        public string PtMx { get; set; }
        public string MxIni { get; set; }
        public string Intro { get; set; }
        public string PtLoc { get; set; }
        public string Vol { get; set; }
        public string Bitrate { get; set; }
        public string Reg { get; set; }
        public string MD5 { get; set; }

    }
}
