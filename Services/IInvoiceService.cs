public interface IInvoiceService
{
    Task<List<Invoice>> GetInvoices();
    Task<Invoice> GetInvoiceById(int idInvoice);
    Task<Invoice> GetInvoicesByIdClient(int idClient);
    Task CreateNewInvoice(Invoice invoice);
    Task UpdateInvoice(Invoice invoice);
    Task DeleteInvoice(int id);
}