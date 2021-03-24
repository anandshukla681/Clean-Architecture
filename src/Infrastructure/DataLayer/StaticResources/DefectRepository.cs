using ApplicationApi.Interface;
using ApplicationApi.Model;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.StaticResources
{
    public sealed class DefectRepository: IDefectRepository
    {
        public DefectRepository()
        {

        }

        public DefectViewModel GetAll()
        {
            return new DefectViewModel() { DefectList = new List<Defect>() {
                {new Defect(){DefectId=1,Description="Bug in View", Status=0, CreatedBy=123, CreatedOn=DateTime.Now } },
                {new Defect(){DefectId=2,Description="Bug in Defect Creation", Status=0, CreatedBy=123, CreatedOn=DateTime.Now } },
                {new Defect(){DefectId=1,Description="Bug in Defect Remarks Addition", Status=0, CreatedBy=123, CreatedOn=DateTime.Now } }
            } };
        }
    }
}
