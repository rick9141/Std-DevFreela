﻿using DevFreela.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevFreela.Core.Repositories
{
    public interface IProjectRepository
    {
        Task<List<Project>> GetAllAsync();
        Task<Project> GetByIdAsync(int id);
        Task<Project> GetDetailsByIdAsync(int id);
        Task AddAsync(Project project);
        Task DeleteAsync(Project project);
        Task StartAsync(Project project);
        Task SaveChangesAsync();
        Task AddCommentAsync(ProjectComment projectComment);
    }
}
