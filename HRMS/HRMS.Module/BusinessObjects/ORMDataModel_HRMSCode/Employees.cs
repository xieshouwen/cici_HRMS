using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace HRMS.Module.BusinessObjects.HRMS
{

    public partial class Employees
    {
        public Employees(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
