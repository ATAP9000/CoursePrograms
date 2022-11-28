using Entities;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new()
            {
                Name = "queso americano cheez",
                Description = "100% americano",
                CostPrice = 10,
                Margin = 2,
                IVA = 0.12,
                Provider = "lacteos venezuela",
                Category = "lacteos",
                SubCategory = "quesos"
            };
            Provider provider = new()
            {
                Name = "lacteos venezuela",
                CUIT = "12345abcde",
                Contact = "lacteos venezuela",
                Email = "lacteosvenezuela@test.com",
                PhoneNumber = "+582124747475",
                Address = "Candelaria Caracas"
            };
            NaturalClient naturalClient = new()
            {
                Name = "angelo",
                LastName = "tarazona",
                CUIT = "23456bcdef",
                Email = "angelotarazona@test.com",
                PhoneNumber = "+582244134575",
                Address = "Caracas"
            };
            JuridicClient juridicClient = new()
            {
                Name = "lacteos venezuela",
                CUIT = "12345abcde",
                Contact = "lacteos venezuela",
                Email = "lacteosvenezuela@test.com",
                PhoneNumber = "+582124747475",
                Address = "Candelaria Caracas"
            };
            Vendor vendor = new()
            {
                Name = "alfredo",
                LastName = "pernia",
                DNI = "25706748",
                Email = "alfredopernia@test.com",
                PhoneNumber = "+582244131275",
                Address = "Caracas"
            };
            Invoice invoice = new()
            {
                Type = "Ordinaria",
                Number = "123456",
                Date = DateTime.Now,
                Client = "Angelo Tarazona",
                Address = "Caracas",
                IVACondition = "a",
                SaleCondition = "b",
                Detail = "Queso americano (1)",
                Total = product.SellingPrice
            };
            Refer refer = new()
            {
                Number = "234567",
                Date = DateTime.Now,
                Client = "angelo tarazona",
                Address = "caracas",
                IVACondition = "a",
                SaleCondition = "b",
                Detail = "aaa",
                DeliverDate = DateTime.MaxValue,
                Total = 100
            };
            Console.WriteLine("Producto: {0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}", product.Name, product.Description, product.SellingPrice, product.GrossPrice, product.Provider, product.Category, product.SubCategory);
            Console.WriteLine("Proveedor: {0}\nCUIT:{1}\nContacto:{2}\nCorreo:{3}\nTelefono:{4}\nDireccion:{5}", provider.Name, provider.CUIT, provider.Contact, provider.Email, provider.PhoneNumber, provider.Address);
            Console.WriteLine("Cliente: {0}{1}\nCUIT: {2}\nCorreo:{3}\nTelefono:{4}\nDireccion:{5}", naturalClient.Name, naturalClient.LastName, naturalClient.CUIT, naturalClient.Email, naturalClient.PhoneNumber, naturalClient.Address);
            Console.WriteLine("Empresa: {0}\nCUIT: {1}\nContacto:{2}\nCorreo:{3}\nTelefono:{4}\nDireccion:{5}", juridicClient.Name, juridicClient.CUIT, juridicClient.Contact, juridicClient.Email, juridicClient.PhoneNumber, juridicClient.Address);
            Console.WriteLine("Vendedor: {0}{1}\nDNI: {3}\nCorreo:{4}\nTelefono:{5}\nDireccion: {6}", vendor.Name, vendor.LastName, vendor.DNI, vendor.Email, vendor.PhoneNumber, vendor.Address);
            Console.WriteLine("Factura Num: {0}\nTipo: {1}\nFecha: {2}\nCliente: {3}\nDireccion: {4}\nCondicion de IVA: {5}\nCondicion de Venta: {6}\nDetalle de Venta: {7}\nFTotal: {8}", invoice.Type, invoice.Number, invoice.Date, invoice.Client, invoice.Address, invoice.IVACondition, invoice.SaleCondition, invoice.Detail, invoice.Total);
            Console.WriteLine("Referido Num: {0}\nFecha: {1}\nCliente: {2}\nDireccion: {3}\nCondicion de IVA: {4}\nCondicion de Venta: {5}\nDetalle de Venta: {6}\nFecha de Entrega: {7}\nTotal: {8}", refer.Number, refer.Date, refer.Client, refer.Address, refer.IVACondition, refer.SaleCondition, refer.Detail, refer.DeliverDate, refer.Total);
        }
    }
}