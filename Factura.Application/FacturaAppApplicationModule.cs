﻿using System.Reflection;
using Abp.Authorization;
using Abp.Authorization.Roles;
using Abp.Authorization.Users;
using AutoMapper;
using Abp.Domain.Repositories;
using Abp.Modules;
using FacturaApp.Authorization.Roles;
using FacturaApp.Authorization.Users;
using FacturaApp.Roles.Dto;
using FacturaApp.Users.Dto;

namespace FacturaApp
{
   // [DependsOn(typeof(FacturaAppCoreModule), typeof(AutoMapperModule))]
    public class FacturaAppApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            // TODO: Is there somewhere else to store these, with the dto classes
            
            //Verificar
            //Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            //{
            //    // Role and permission
            //    cfg.CreateMap<Permission, string>().ConvertUsing(r => r.Name);
            //    cfg.CreateMap<RolePermissionSetting, string>().ConvertUsing(r => r.Name);

            //    cfg.CreateMap<CreateRoleDto, Role>().ForMember(x => x.Permissions, opt => opt.Ignore());
            //    cfg.CreateMap<RoleDto, Role>().ForMember(x => x.Permissions, opt => opt.Ignore());
                
            //    cfg.CreateMap<UserDto, User>();
            //    cfg.CreateMap<UserDto, User>().ForMember(x => x.Roles, opt => opt.Ignore());

            //    cfg.CreateMap<CreateUserDto, User>();
            //    cfg.CreateMap<CreateUserDto, User>().ForMember(x => x.Roles, opt => opt.Ignore());
            //});
        }
    }
}
