using FSSCM.Product;
using FSSCM.Product.Dtos;
using FSSCM.Customers;
using FSSCM.Customers.Dtos;
using AutoMapper;

namespace FSSCM
{
    public class FSSCMApplicationAutoMapperProfile : Profile
    {
        public FSSCMApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<GoodsType, GoodsTypeDto>();
            CreateMap<CreateUpdateGoodsTypeDto, GoodsType>(MemberList.Source);
            CreateMap<GoodsUnit, GoodsUnitDto>();
            CreateMap<CreateUpdateGoodsUnitDto, GoodsUnit>(MemberList.Source);
            CreateMap<Customer, CustomerDto>();
            CreateMap<CreateUpdateCustomerDto, Customer>(MemberList.Source);
            CreateMap<CustomerType, CustomerTypeDto>();
            CreateMap<CreateUpdateCustomerTypeDto, CustomerType>(MemberList.Source);
            CreateMap<CustomerTagBTOs, CustomerTagBTOsDto>();
            CreateMap<CreateUpdateCustomerTagBTOsDto, CustomerTagBTOs>(MemberList.Source);
        }
    }
}
