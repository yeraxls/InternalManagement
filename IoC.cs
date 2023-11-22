public static class IoC {
    public static IServiceCollection AddDependency(this IServiceCollection services)
    {
        services.AddScoped<IClientService, ClientService>();
        services.AddScoped<IInvoiceService, InvoiceService>();

        return services;
    }
}