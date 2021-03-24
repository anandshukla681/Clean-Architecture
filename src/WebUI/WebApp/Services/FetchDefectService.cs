using ApplicationApi.Interface;
using ApplicationApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Services
{
    public class FetchDefectService
    {
        private readonly IDefectRepository _defectRepository;

        public FetchDefectService(IDefectRepository defectRepository)
        {
            _defectRepository = defectRepository; 
        }

        public DefectViewModel GetUserDefect()
        {
            return _defectRepository.GetAll();
        }
    }
}
