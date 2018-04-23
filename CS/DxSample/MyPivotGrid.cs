using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraPivotGrid.Data;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraPivotGrid.ViewInfo;

namespace DxSample {
    public class MyPivotGrid : PivotGridControl {
        public MyPivotGrid() : base() { }
        protected override PivotGridViewInfoData CreateData() {
            return new MyPivotGridViewInfoData(this);
        }
    }

    public class MyPivotGridField : PivotGridField {
        public MyPivotGridField(string fieldName, PivotArea area) : base(fieldName, area) { }
        public MyPivotGridField() : base() { }
        public MyPivotGridField(PivotGridData data) : base(data) { }
        
        protected override bool OnAllowSerializationProperty(DevExpress.Utils.OptionsLayoutBase options, string propertyName, int id) {
            if(propertyName == "Options")
                return false;
            return base.OnAllowSerializationProperty(options, propertyName, id);
        }
    }

    public class MyPivotGridFieldCollection : PivotGridFieldCollection {
        public MyPivotGridFieldCollection(PivotGridData data) : base(data) { }
        protected override PivotGridField CreateFieldCore(string fieldName, PivotArea area) {
            return new MyPivotGridField(fieldName, area);
        }
    }

    public class MyPivotGridViewInfoData : PivotGridViewInfoData {
        public MyPivotGridViewInfoData(IViewInfoControl control) : base(control) { }
        public MyPivotGridViewInfoData() : this(null) { }

        protected override PivotGridFieldCollectionBase CreateFieldCollection() {
            return new MyPivotGridFieldCollection(this);
        }
    }
}
