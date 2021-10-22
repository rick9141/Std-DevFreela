using DevFreela.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevFreela.Application.Services
{
    public interface ISkillService
    {
        List<SkillViewModel> GetAll();
    }
}
