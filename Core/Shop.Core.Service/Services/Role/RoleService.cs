using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Shop.Core.Contract.Repositories;
using Shop.Core.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Services.Role
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository roleRepository;
        private readonly IMapper mapper;
        private readonly IUserRoleRepository userRoleRepository;

        public RoleService(IRoleRepository roleRepository,
            IMapper mapper, IUserRoleRepository userRoleRepository)
        {
            this.roleRepository = roleRepository;
            this.mapper = mapper;
            this.userRoleRepository = userRoleRepository;
        }

        public void AddRole(RoleDto roleDto)
        {
            var role = mapper.Map<IdentityRole<Guid>>(roleDto);
            roleRepository.AddRole(role);
        }

        public List<RoleDto> GetAllRole()
        {
            List<RoleDto> roleDtos = new List<RoleDto>();
            var listRole = roleRepository.GetAllRole();
            foreach (var item in listRole)
            {
                var Role = mapper.Map<RoleDto>(item);
                roleDtos.Add(Role);
            }
            return roleDtos;
        }

        public List<RoleDto> GetAllRoleUser(Guid userid)
        {
            List<RoleDto> listrole = new List<RoleDto>();
            var ListRole = userRoleRepository.GetRoleUser(userid);

            foreach (var item in ListRole)
            {
                RoleDto roleDto = new RoleDto();
                var role = roleRepository.GetById(item.RoleId);
                roleDto.RoleName = role.Name;
                roleDto.RoleId = role.Id;
                listrole.Add(roleDto);
            }
            return listrole;


        }

        public IdentityRole<Guid> GetById(Guid roleid)
        {
            var role = roleRepository.GetById(roleid);
            return role;
        }

        public Guid GetByRoleId(string rolename)
        {
            var RoleName = roleRepository.GetByRoleId(rolename);
            return RoleName;
        }

        public Guid GetByRoleName(string rolename)
        {
            var RoleId = roleRepository.GetByRoleName(rolename);
            return RoleId;
        }

        public void RemoveRole(IdentityRole<Guid> identityRole)
        {
            roleRepository.RemoveRole(identityRole);
        }
    }
}
