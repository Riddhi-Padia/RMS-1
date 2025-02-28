using System;
using System.Collections.Generic;

namespace PS.Domain.Data_Models;

public partial class Order
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public int OrderNo { get; set; }

    public int? Status { get; set; }

    public decimal? Totalamount { get; set; }

    public decimal? Tax { get; set; }

    public decimal? Subtotal { get; set; }

    public decimal? Discount { get; set; }

    public decimal? Paidamount { get; set; }

    public string? Notes { get; set; }

    public bool? Issgstselected { get; set; }

    public int CreatedBy { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool? Isdeleted { get; set; }

    public virtual Role CreatedByNavigation { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<MappingOrdersWithTable> MappingOrdersWithTables { get; set; } = new List<MappingOrdersWithTable>();

    public virtual ICollection<MappingOrdersWithTax> MappingOrdersWithTaxes { get; set; } = new List<MappingOrdersWithTax>();

    public virtual Role? ModifiedByNavigation { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
}
