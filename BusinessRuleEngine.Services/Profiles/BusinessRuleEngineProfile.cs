using System;

using BusinessRuleEngine.DAL.ResultObjects;
using BusinessRuleEngine.Enums;
using BusinessRuleEngine.Services.Bos.Agents;
using BusinessRuleEngine.Services.Bos.Customers;
using BusinessRuleEngine.Services.Bos.Departments;
using BusinessRuleEngine.Services.Bos.Memberships;
using BusinessRuleEngine.Services.Bos.Payments;
using BusinessRuleEngine.Services.Bos.Slips;
using BusinessRuleEngine.Services.Dtos.Agents;
using BusinessRuleEngine.Services.Dtos.Customers;
using BusinessRuleEngine.Services.Dtos.Departments;
using BusinessRuleEngine.Services.Dtos.Memberships;
using BusinessRuleEngine.Services.Dtos.Payments;
using BusinessRuleEngine.Services.Dtos.Shared;
using BusinessRuleEngine.Services.Dtos.Slips;

using AutoMapper;

using Entities = BusinessRuleEngine.DAL.Entities;

namespace BusinessRuleEngine.Services.Profiles
{
    public class BusinessRuleEngineProfile : Profile
    {
        public BusinessRuleEngineProfile()
        {
            CreateMap<AgentDto, AgentBo>(); 
            CreateMap<CustomerDto, CustomerBo>();
            CreateMap<DepartmentDto, DepartmentBo>();
            CreateMap<MembershipDto, MembershipBo>();
            CreateMap<PaymentDto, PaymentBo>();
            CreateMap<PackagingSlipDto, PackagingSlipBo>();

            CreateMap<Entities.Membership, MembershipBo>()
                .ForMember(d => d.MembershipType, opt => opt.MapFrom(src => Enum.Parse(typeof(MembershipType), src.Type)));

            CreateMap<MembershipBo, MembershipDto>();

            CreateMap<AgentTotalCommissionBo, AgentTotalCommissionDto>();
        }
    }
}
