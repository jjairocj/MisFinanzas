using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MisFinanzas.MultiTenancy.Dto;

namespace MisFinanzas.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultDto<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
