namespace DO;

public record Product
    (
  
    int ProductId,
    string? ProductName,
    Category? Category,
    double Price,
    int Amount
    )
{
   public Product():this(0,null,null,0,0)
    {
      
    }

}
