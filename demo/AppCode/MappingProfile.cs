using AutoMapper;
using demo.Areas.Administration.Models;
using demo.domain.Models.Administration;

namespace info.awesolutions.AppCode
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Administration
            // CreateMap<Actions, ActionViewModel>();
            // CreateMap<ActionViewModel, Actions>();
            // CreateMap<Page, PageViewModel>();
            // CreateMap<PageViewModel, Page>();
            // CreateMap<Menu, MenuViewModel>();
            // CreateMap<MenuViewModel, Menu>();
            CreateMap<User, UserViewModel>();
            // CreateMap<Role, RoleViewModel>();
            // CreateMap<RoleViewModel, Role>();
            // CreateMap<PageOfRole, PageOfRoleViewModel>();
            // CreateMap<PageOfRoleViewModel, PageOfRole>();
            // CreateMap<UserInRole, UserInRoleViewModel>();
            // CreateMap<UserInRoleViewModel, UserInRole>();

            // CreateMap<Category, CategoryViewModel>();
            // CreateMap<Category, CategoryViewModel>().ReverseMap();
            // CreateMap<CategoryItem, CategoryItemViewModel>();
            // CreateMap<CategoryItem, CategoryItemViewModel>().ReverseMap();
            #endregion

            #region CMS

            // CreateMap<Article, ArticleViewModel>();
            // CreateMap<Article, ArticleViewModel>().ReverseMap();
            // CreateMap<Resource, ResourceViewModel>();
            // CreateMap<Resource, ResourceViewModel>().ReverseMap();
            #endregion

            #region MNG
            // CreateMap<Product, ProductViewModel>();
            // CreateMap<Product, ProductViewModel>().ReverseMap();

            // CreateMap<ProductCategory, ProductCategoryViewModel>();
            // CreateMap<ProductCategory, ProductCategoryViewModel>().ReverseMap();

            // CreateMap<Supplier, SupplierViewModel>();
            // CreateMap<Supplier, SupplierViewModel>().ReverseMap();
            
            // CreateMap<Manufacturer, ManufacturerViewModel>();
            // CreateMap<Manufacturer, ManufacturerViewModel>().ReverseMap();

            // CreateMap<ProductSpecification, ProductSpecificationViewModel>();
            // CreateMap<ProductSpecification, ProductSpecificationViewModel>().ReverseMap();

            // CreateMap<ProductSpecificationValue, ProductSpecificationValueViewModel>();
            // CreateMap<ProductSpecificationValue, ProductSpecificationValueViewModel>().ReverseMap();

            // CreateMap<ProductPrice, ProductPriceViewModel>();
            // CreateMap<ProductPrice, ProductPriceViewModel>().ReverseMap();
            
            // CreateMap<Warehouse, WarehouseViewModel>();
            // CreateMap<Warehouse, WarehouseViewModel>().ReverseMap();
            
            // CreateMap<Property, PropertyViewModel>();
            // CreateMap<Property, PropertyViewModel>().ReverseMap();
            
            // CreateMap<Inventory, InventoryViewModel>();
            // CreateMap<Inventory, InventoryViewModel>().ReverseMap();
            
            // CreateMap<WarehouseOperation, WarehouseOperationViewModel>();
            // CreateMap<WarehouseOperation, WarehouseOperationViewModel>().ReverseMap();

            // CreateMap<WarehouseOperationDetail, WarehouseOperationDetailViewModel>();
            // CreateMap<WarehouseOperationDetail, WarehouseOperationDetailViewModel>().ReverseMap();
            #endregion
        }
    }
}