namespace MVCSportStore.Data.DefaultData
{
    public static class SeedData
    {
        public static void EnsurePopulated(WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<StoreDbContext>();
                if (!context.Products.Any())
                {
                    // Kayak;A boat for one person;Watersports;275
                    foreach (var product in DefaultData.Products)
                    {
                        string[] details = product.Split(';');
                        context.Products.Add(new Models.Product(details));
                    }
                    context.SaveChanges();
                }
            }
        }
    }
}
