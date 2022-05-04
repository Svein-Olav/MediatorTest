public static class DatabaseHelpers
{
    public static int SeedDatabaseIfEmpty(this ApplicationDbContext context)
    {
        var numberOfCustomers = context.Customers.Count();
        if(numberOfCustomers == 0)
        {
            var customer = new  Customer()
            {
                Age = 15,
                FirstName = "Ola",
                LastName = "Svendsen",
                Phonenumber = "12345667"
            };

            context.Customers.Add(customer);
            context.SaveChangesAsync();            
        }

        return context.Customers.Count();
    }
}