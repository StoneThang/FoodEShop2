using FoodEShopSolution.ViewModels.Common;
using FoodEShopSolution.ViewModels.System.Languages;
using FoodEShopSolution.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoodEShopSolution.Application.System.Languages
{
    public interface ILanguageService
    {
        Task<ApiResult<List<LanguageVm>>> GetAll();
    }
}