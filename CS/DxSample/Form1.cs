using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using DevExpress.XtraPivotGrid;
using DevExpress.Utils;

namespace DxSample {
    public partial class Form1 : Form {
        const string LayoutFile = "layout.xml";

        public Form1() {
            InitializeComponent();
            pivotGrid1.DataSource = CreateTable(10);
            pivotGrid1.RetrieveFields();
            for(int i = 0; i < pivotGrid1.Fields.Count; i++) {
                pivotGrid1.Fields[i].Name = "field" + i.ToString();
            }
        }
        private DataTable CreateTable(int RowCount) {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("ID", typeof(int));
            tbl.Columns.Add("Number", typeof(int));
            tbl.Columns.Add("Date", typeof(DateTime));
            for(int i = 0; i < RowCount; i++)
                tbl.Rows.Add(new object[] { String.Format("Name{0}", i), i, 3 - i, DateTime.Now.AddDays(i) });
            return tbl;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if(File.Exists(LayoutFile))
                File.Delete(LayoutFile);
            using(FileStream stream = new FileStream(LayoutFile, FileMode.OpenOrCreate, FileAccess.Write)) {
                pivotGrid1.SaveLayoutToStream(stream);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e) {
            using(FileStream stream = new FileStream(LayoutFile, FileMode.Open, FileAccess.Read)) {
                pivotGrid1.RestoreLayoutFromStream(stream);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            foreach(PivotGridField field in pivotGrid1.Fields) {
                field.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.False;
            }
        }
    }
}