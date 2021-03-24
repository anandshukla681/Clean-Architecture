using ApplicationApi.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationApi.Interface
{
    public interface IDefectRepository
    {
        DefectViewModel GetAll();
    }
}
