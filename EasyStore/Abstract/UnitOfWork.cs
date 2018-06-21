using EasyStore.Entities;
using EasyStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyStore.Abstract
{
    public class UnitOfWork : IDisposable   
    {
        private storeContext context = new storeContext();
        private GenericRepository<User> userRepository;
        private GenericRepository<Product> productRepository;
        private GenericRepository<Entities.Transaction> transactionRepository;
        private GenericRepository<Supply> supplyRepository;
        private GenericRepository<Category> categoryRepository;
        private GenericRepository<Barcode> barcodeRepository;
        private GenericRepository<vw_Transaction> viewTransactionModelRepository;

        public GenericRepository<User> UserRepository
        {
            get
            {
                if(userRepository == null)
                {
                    userRepository = new GenericRepository<User>(context);
                }
                return userRepository;
            }
            
        }

        public GenericRepository<Product> ProductRepository
        {
            get
            {
                if (productRepository == null)
                {
                    productRepository = new GenericRepository<Product>(context);
                }
                return productRepository;
            }

        }

        public GenericRepository<Entities.Transaction> TransactionRepository
        {
            get
            {
                if (transactionRepository == null)
                {
                    transactionRepository = new GenericRepository<Entities.Transaction>(context);
                }
                return transactionRepository;
            }

        }

        public GenericRepository<Supply> SupplyRepository
        {
            get
            {
                if (supplyRepository == null)
                {
                    supplyRepository = new GenericRepository<Supply>(context);
                }
                return supplyRepository;
            }

        }

        public GenericRepository<Category> CategoryRepository
        {
            get
            {
                if (categoryRepository == null)
                {
                    categoryRepository = new GenericRepository<Category>(context);
                }
                return categoryRepository;
            }

        }

        public GenericRepository<Barcode> BarcodeRepository
        {
            get
            {
                if (barcodeRepository == null)
                {
                    barcodeRepository = new GenericRepository<Barcode>(context);
                }
                return barcodeRepository;
            }

        }

        public GenericRepository<vw_Transaction> ViewTransactionModelRepository
        {
            get
            {
                if (viewTransactionModelRepository == null)
                {
                    viewTransactionModelRepository = new GenericRepository<vw_Transaction>(context);
                }
                return viewTransactionModelRepository;
            }

        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                context.Dispose();
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
