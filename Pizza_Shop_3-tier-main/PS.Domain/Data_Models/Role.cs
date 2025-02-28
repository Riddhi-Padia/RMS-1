using System;
using System.Collections.Generic;

namespace PS.Domain.Data_Models;

public partial class Role
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int CreatedBy { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool? Isdeleted { get; set; }

    public virtual ICollection<City> CityCreatedByNavigations { get; set; } = new List<City>();

    public virtual ICollection<City> CityModifiedByNavigations { get; set; } = new List<City>();

    public virtual ICollection<Country> CountryCreatedByNavigations { get; set; } = new List<Country>();

    public virtual ICollection<Country> CountryModifiedByNavigations { get; set; } = new List<Country>();

    public virtual Role CreatedByNavigation { get; set; } = null!;

    public virtual ICollection<Customer> CustomerCreatedByNavigations { get; set; } = new List<Customer>();

    public virtual ICollection<Customer> CustomerModifiedByNavigations { get; set; } = new List<Customer>();

    public virtual ICollection<Role> InverseCreatedByNavigation { get; set; } = new List<Role>();

    public virtual ICollection<Role> InverseModifiedByNavigation { get; set; } = new List<Role>();

    public virtual ICollection<MappingMenuitemsWithModifier> MappingMenuitemsWithModifierCreatedByNavigations { get; set; } = new List<MappingMenuitemsWithModifier>();

    public virtual ICollection<MappingMenuitemsWithModifier> MappingMenuitemsWithModifierModifiedByNavigations { get; set; } = new List<MappingMenuitemsWithModifier>();

    public virtual ICollection<MappingOrdereditemsWithModifier> MappingOrdereditemsWithModifierCreatedByNavigations { get; set; } = new List<MappingOrdereditemsWithModifier>();

    public virtual ICollection<MappingOrdereditemsWithModifier> MappingOrdereditemsWithModifierModifiedByNavigations { get; set; } = new List<MappingOrdereditemsWithModifier>();

    public virtual ICollection<MappingOrdersWithTable> MappingOrdersWithTableCreatedByNavigations { get; set; } = new List<MappingOrdersWithTable>();

    public virtual ICollection<MappingOrdersWithTable> MappingOrdersWithTableModifiedByNavigations { get; set; } = new List<MappingOrdersWithTable>();

    public virtual ICollection<MappingOrdersWithTax> MappingOrdersWithTaxCreatedByNavigations { get; set; } = new List<MappingOrdersWithTax>();

    public virtual ICollection<MappingOrdersWithTax> MappingOrdersWithTaxModifiedByNavigations { get; set; } = new List<MappingOrdersWithTax>();

    public virtual ICollection<MenuCategory> MenuCategoryCreatedByNavigations { get; set; } = new List<MenuCategory>();

    public virtual ICollection<MenuCategory> MenuCategoryModifiedByNavigations { get; set; } = new List<MenuCategory>();

    public virtual ICollection<MenuItem> MenuItemCreatedByNavigations { get; set; } = new List<MenuItem>();

    public virtual ICollection<MenuItem> MenuItemModifiedByNavigations { get; set; } = new List<MenuItem>();

    public virtual Role? ModifiedByNavigation { get; set; }

    public virtual ICollection<Modifier> ModifierCreatedByNavigations { get; set; } = new List<Modifier>();

    public virtual ICollection<ModifierGroup> ModifierGroupCreatedByNavigations { get; set; } = new List<ModifierGroup>();

    public virtual ICollection<ModifierGroup> ModifierGroupModifiedByNavigations { get; set; } = new List<ModifierGroup>();

    public virtual ICollection<Modifier> ModifierModifiedByNavigations { get; set; } = new List<Modifier>();

    public virtual ICollection<Order> OrderCreatedByNavigations { get; set; } = new List<Order>();

    public virtual ICollection<OrderItem> OrderItemCreatedByNavigations { get; set; } = new List<OrderItem>();

    public virtual ICollection<OrderItem> OrderItemModifiedByNavigations { get; set; } = new List<OrderItem>();

    public virtual ICollection<Order> OrderModifiedByNavigations { get; set; } = new List<Order>();

    public virtual ICollection<Payment> PaymentCreatedByNavigations { get; set; } = new List<Payment>();

    public virtual ICollection<Payment> PaymentModifiedByNavigations { get; set; } = new List<Payment>();

    public virtual ICollection<Permission> PermissionCreatedByNavigations { get; set; } = new List<Permission>();

    public virtual ICollection<Permission> PermissionModifiedByNavigations { get; set; } = new List<Permission>();

    public virtual ICollection<Review> ReviewCreatedByNavigations { get; set; } = new List<Review>();

    public virtual ICollection<Review> ReviewModifiedByNavigations { get; set; } = new List<Review>();

    public virtual ICollection<RolePermission> RolePermissionCreatedByNavigations { get; set; } = new List<RolePermission>();

    public virtual ICollection<RolePermission> RolePermissionModifiedByNavigations { get; set; } = new List<RolePermission>();

    public virtual ICollection<RolePermission> RolePermissionRoles { get; set; } = new List<RolePermission>();

    public virtual ICollection<SeatingTable> SeatingTableCreatedByNavigations { get; set; } = new List<SeatingTable>();

    public virtual ICollection<SeatingTable> SeatingTableModifiedByNavigations { get; set; } = new List<SeatingTable>();

    public virtual ICollection<Section> SectionCreatedByNavigations { get; set; } = new List<Section>();

    public virtual ICollection<Section> SectionModifiedByNavigations { get; set; } = new List<Section>();

    public virtual ICollection<State> StateCreatedByNavigations { get; set; } = new List<State>();

    public virtual ICollection<State> StateModifiedByNavigations { get; set; } = new List<State>();

    public virtual ICollection<TaxAndFee> TaxAndFeeCreatedByNavigations { get; set; } = new List<TaxAndFee>();

    public virtual ICollection<TaxAndFee> TaxAndFeeModifiedByNavigations { get; set; } = new List<TaxAndFee>();

    public virtual ICollection<Unit> UnitCreatedByNavigations { get; set; } = new List<Unit>();

    public virtual ICollection<Unit> UnitModifiedByNavigations { get; set; } = new List<Unit>();

    public virtual ICollection<User> Users { get; set;} = new List<User>();
    
    public virtual ICollection<User> UserCreatedByNavigations { get; set; } = new List<User>();

    public virtual ICollection<User> UserModifiedByNavigations { get; set; } = new List<User>();

    public virtual ICollection<WaitingToken> WaitingTokenCreatedByNavigations { get; set; } = new List<WaitingToken>();

    public virtual ICollection<WaitingToken> WaitingTokenModifiedByNavigations { get; set; } = new List<WaitingToken>();
}
