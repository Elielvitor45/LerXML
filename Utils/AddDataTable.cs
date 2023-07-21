using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeituraXml.Utils
{
    internal class AddDataTable
    {
        public DataTable GetDataTableColumnsIns()
        {
            DataTable mainDataTable = new DataTable();
            string[] attributeNames = {"NameB", "Ins", "Changed", "Locked", "Filetime", "Filetime2", "Time", "Type", "Id", "Id_Edited", "Fixo", "Descarte", "Net", "Dur", "Slots", "Orig","Inserções" };
            foreach (string attribute in attributeNames)
            {
                mainDataTable.Columns.Add(attribute);
            }
            return mainDataTable;
        }
        public DataTable getValueDataTableBreak(List<Break> abreak)
        {
            DataTable mainDataTable = GetDataTableColumnsIns();

            foreach (Break breakItem in abreak)
            {
                DataRow newRow = mainDataTable.NewRow();

                newRow["NameB"] = breakItem.NameB;
                newRow["Ins"] = breakItem.Ins;
                newRow["Changed"] = breakItem.Changed;
                newRow["Locked"] = breakItem.Locked;
                newRow["Filetime"] = breakItem.Filetime;
                newRow["Filetime2"] = breakItem.Filetime2;
                newRow["Time"] = breakItem.Time;
                newRow["Type"] = breakItem.Type;
                newRow["Id"] = breakItem.Id;
                newRow["Id_Edited"] = breakItem.Id_Edited;
                newRow["Fixo"] = breakItem.Fixo;
                newRow["Descarte"] = breakItem.Descarte;
                newRow["Net"] = breakItem.Net;
                newRow["Dur"] = breakItem.Dur;
                newRow["Slots"] = breakItem.Slots;
                newRow["Orig"] = breakItem.Orig;
                DataTable insercoesDataTable = getValueDataTableIns(breakItem.Insercao);
                newRow["Inserções"] = insercoesDataTable;
                mainDataTable.Rows.Add(newRow);
            }
            return mainDataTable;
        }

        public DataTable getDataTableColumnsIns()
        {
            DataTable secondaryDataTable = new DataTable();
            string[] attributeNames = {"NameI", "Id", "CTA", "Source", "MovedTo", "Type", "Title", "File", "Folder", "Text", "Composer", "Comment", "Checked", "Err", "sErr", "HoraAudio", "HoraPK", "IsAudioFile", "DurOrig", "Dur", "Refr", "DurRefr", "PtVh", "PtMx", "MxIni", "Intro", "PtLoc", "Vol", "Bitrate", "Reg", "MD5" };
            foreach (string attribute in attributeNames)
            {
                secondaryDataTable.Columns.Add(attribute);
            }
            return secondaryDataTable;
        }

        public DataTable getValueDataTableIns(List<Ins> ins)
        {
            DataTable secondaryDataTable = getDataTableColumnsIns();

            foreach (Ins inIns in ins)
            {
                secondaryDataTable.Rows.Add(inIns.NameI, inIns.Id, inIns.CTA, inIns.Source, inIns.MovedTo, inIns.Type, inIns.Title, inIns.File, inIns.Folder, inIns.Text, inIns.Composer, inIns.Comment, inIns.Checked, inIns.Err, inIns.sErr, inIns.HoraAudio, inIns.HoraPK, inIns.IsAudioFile, inIns.DurOrig, inIns.Dur, inIns.Refr, inIns.DurRefr, inIns.PtVh, inIns.PtMx, inIns.MxIni, inIns.Intro, inIns.PtLoc, inIns.Vol, inIns.Bitrate, inIns.Reg, inIns.MD5);
            }

            return secondaryDataTable;
        }














    }
}
