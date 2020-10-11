using Business.Interfaces;
using DAL.Repositories.DapperRepositories.Interfaces;
using DTO;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RoleManager : Manager<Role> , IRoleService
    {
        private readonly IRoleRepository repository;
        public RoleManager(IRoleRepository _repository):base( _repository)
        {
            repository = _repository;
        }

        public async Task UserAssignRole(List<UsersRoleUpdate> liste)
        {
            await repository.UserAssignRole(liste);
        }
    }
}
