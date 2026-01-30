using AutoMapper;
using Prema.ChamaOne.Domain.Models;
using Prema.ChamaOne.Domain.Models.Location;

namespace Prema.ChamaOne.Application.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Gender, GenderDto>();
            CreateMap<GenderDto, Gender>();

            CreateMap<Member, MemberDto>();
            CreateMap<MemberDto, Member>();

            CreateMap<MemberType, MemberTypeDto>();
            CreateMap<MemberTypeDto, MemberType>();

            CreateMap<TransactionStatus, TransactionStatusDto>();
            CreateMap<TransactionStatusDto, TransactionStatus>();

            CreateMap<Contribution, ContributionDto>();
            CreateMap<ContributionDto, Contribution>();

            CreateMap<Loan, LoanDto>();
            CreateMap<LoanDto, Loan>();

            CreateMap<Transaction, TransactionDto>();
            CreateMap<TransactionDto, Transaction>();

            CreateMap<TransactionEntityType, TransactionEntityTypeDto>();
            CreateMap<TransactionEntityTypeDto, TransactionEntityType>();

            CreateMap<TransactionType, TransactionTypeDto>();
            CreateMap<TransactionTypeDto, TransactionType>();

            CreateMap<County, CountyDto>();
            CreateMap<Subcounty, SubcountyDto>();
            CreateMap<Ward, WardDto>();
        }
    }
}
