using System.Threading.Tasks;
using Abp.Application.Services;
using MisFinanzas.Roles.Dto;

namespace MisFinanzas.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
