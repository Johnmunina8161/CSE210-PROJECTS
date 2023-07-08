/*
   +--------------+
   |    Address   |
   +--------------+----------+
   | - streetAddress: string |
   | - city: string          |
   | - state: string         |
   | - country: string       |
   +-------------------------+------------------------------------------------------+
   | + Address(streetAddress: string, city: string, state: string, country: string) |
   | + IsInUSA(): bool                                                              |
   | + GetFullAddress(): string                                                     |
   +--------------------------------------------------------------------------------+

           |
           |
           v

   +-------------+
   |   Product   |
   +-------------+----+
   | - name: string   |
   | - productId: int |
   | - price: decimal |
   | - quantity: int  |
   +------------------+-----------------------------------------------------+
   | + Product(name: string, productId: int, price: decimal, quantity: int) |
   | + GetTotalPrice(): decimal                                             |
   | + GetName(): string                                                    |
   | + GetProductId(): int                                                  |
   +------------------------------------------------------------------------+

           |
           |
           v

   +----------+
   |   Order  |
   +----------+----------------+
   | - products: List<Product> |
   | - customer: Customer      |
   +---------------------------+------+
   | + Order(customer: Customer)      |
   | + AddProduct(product: Product)   |
   | + CalculateTotalPrice(): decimal |
   | + GetPackingLabel(): string      |
   | + GetShippingLabel(): string     |
   +----------------------------------+

           |
           |
           v

   +------------+
   |   Program  |
   +------------+-----------+
   | + Main(args: string[]) |
   +------------------------+


*/