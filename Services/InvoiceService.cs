public class InvoiceService : IInvoiceService {
     public async Task<List<Invoice>> GetInvoices()
    {
        return new List<Invoice>{
            new Invoice{
            Id = 1,
            IdClient = 1,
            ItsPaid = true,
            Amount = 200.34
        }
        };
    }
    public async Task<Invoice> GetInvoiceById(int idInvoice)
    {
        return new Invoice{
            Id = idInvoice,
            IdClient = 1,
            ItsPaid = true,
            Amount = 200.34
        };
    }

    public async Task<Invoice> GetInvoicesByIdClient(int idClient)
    {
        return new Invoice{
            Id = 1,
            IdClient = idClient,
            ItsPaid = true,
            Amount = 200.34
        };
    }

    public async Task CreateNewInvoice(Invoice invoice)
    {
        //Crear clientne
    }

    public Task UpdateInvoice(Invoice invoice)
    {
        throw new NotImplementedException();
    }

    public Task DeleteInvoice(int id)
    {
        throw new NotImplementedException();
    }
}
