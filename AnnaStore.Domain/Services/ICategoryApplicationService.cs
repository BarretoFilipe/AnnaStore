using AnnaStore.Domain.Commands.CategoryCommands;
using AnnaStore.Domain.Entities;
using System;
using System.Collections.Generic;

namespace AnnaStore.Domain.Services
{
    public interface ICategoryApplicationService
    {
        List<Category> Get();
        List<Category> Get(int skip, int take);
        Category Get(int id);
        Category Create(CreateCategoryCommand command);
        Category Update(EditCategoryCommand command);
        Category Delete(int id);
    }
}
