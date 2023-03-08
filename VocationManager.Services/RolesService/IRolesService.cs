﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocationManager.Services.DTOs.Roles;
using VocationManager.Services.DTOs.Users;

namespace VocationManager.Services.RolesService
{
    public interface IRolesService
    {
        Task<string> GetRoleNameByUserId(string userId);

        Task<string?> GetNameById(string id);

        IEnumerable<KeyValuePair<string, string>> GetAllAsKeyValuePairs();

        Task<ICollection<RoleDto>> GetAllAsync();
        //Task<BaseRoleDto> GetPaginatedAndFilteredUsers(int? page, int? pageSize, string keyword);
        Task<RoleDto?> GetByIdAsync(string roleId, bool disableTracking = true);
        Task CreateAsync(BaseRoleDto roleDto);
        Task EditAsync(BaseRoleDto roleDto);
        Task DeleteAsync(string roleId);
        Task<bool> RoleExists(string roleName);
    }
}
