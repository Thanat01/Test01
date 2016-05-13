﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OStore.Data.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OStoreDBEntities : OStore.Data.EF.Base.ContextBase
    {
        public OStoreDBEntities(int userId = 0)
            : base(userId)
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AddressType> AddressTypes { get; set; }
        public virtual DbSet<AuthorizeExternalSystemUser> AuthorizeExternalSystemUsers { get; set; }
        public virtual DbSet<AuthorizeGroup> AuthorizeGroups { get; set; }
        public virtual DbSet<AuthorizeGroupMapRole> AuthorizeGroupMapRoles { get; set; }
        public virtual DbSet<AuthorizeRole> AuthorizeRoles { get; set; }
        public virtual DbSet<AuthorizeRoleMapMenu> AuthorizeRoleMapMenus { get; set; }
        public virtual DbSet<AuthorizeUser> AuthorizeUsers { get; set; }
        public virtual DbSet<AuthorizeUserMapGroup> AuthorizeUserMapGroups { get; set; }
        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<ExternalSystem> ExternalSystems { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<OrderStatu> OrderStatus { get; set; }
        public virtual DbSet<PaymentChannel> PaymentChannels { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<PersonAddress> PersonAddresses { get; set; }
        public virtual DbSet<PersonMapType> PersonMapTypes { get; set; }
        public virtual DbSet<PersonOrder> PersonOrders { get; set; }
        public virtual DbSet<PersonOrderDetail> PersonOrderDetails { get; set; }
        public virtual DbSet<PersonType> PersonTypes { get; set; }
        public virtual DbSet<PostalCode> PostalCodes { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<ProductImage> ProductImages { get; set; }
        public virtual DbSet<ProductItem> ProductItems { get; set; }
        public virtual DbSet<ProductItemMapVariant> ProductItemMapVariants { get; set; }
        public virtual DbSet<ProductMapCategory> ProductMapCategories { get; set; }
        public virtual DbSet<ProductMapProduct> ProductMapProducts { get; set; }
        public virtual DbSet<ProductMapVariant> ProductMapVariants { get; set; }
        public virtual DbSet<ProductMapVariantDetail> ProductMapVariantDetails { get; set; }
        public virtual DbSet<ProductRelationType> ProductRelationTypes { get; set; }
        public virtual DbSet<ProductReview> ProductReviews { get; set; }
        public virtual DbSet<ProductVariant> ProductVariants { get; set; }
        public virtual DbSet<ProductVariantDetail> ProductVariantDetails { get; set; }
        public virtual DbSet<Promotion> Promotions { get; set; }
        public virtual DbSet<PromotionMapCategory> PromotionMapCategories { get; set; }
        public virtual DbSet<PromotionMapProduct> PromotionMapProducts { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<ReviewStatu> ReviewStatus { get; set; }
        public virtual DbSet<SaleChannel> SaleChannels { get; set; }
        public virtual DbSet<Shop> Shops { get; set; }
        public virtual DbSet<ShopingCard> ShopingCards { get; set; }
        public virtual DbSet<ShopingCardDetail> ShopingCardDetails { get; set; }
        public virtual DbSet<ShopMapPaymentChannel> ShopMapPaymentChannels { get; set; }
        public virtual DbSet<ShopPaymentAccount> ShopPaymentAccounts { get; set; }
        public virtual DbSet<SubDistrict> SubDistricts { get; set; }
        public virtual DbSet<TimeZone> TimeZones { get; set; }
    }
}
