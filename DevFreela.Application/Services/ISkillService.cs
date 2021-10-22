using DevFreela.Application.ViewModels;
using System.Collections.Generic;

namespace DevFreela.Application.Services
{
    public interface ISkillService
    {
        List<SkillViewModel> GetAll();
    }
}
