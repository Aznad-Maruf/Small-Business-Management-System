using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using SmallBusinessManagementSystem.Repository;
using SmallBusinessManagementSystem.Model;

namespace SmallBusinessManagementSystem.Manager
{
    class SupplierEntryManager
    {
        
    
        SupplierEntryRepository _supplierEntryRepository = new SupplierEntryRepository();

        public bool IsSaved(SupplierEntry _supplierEntry)
        {
            return _supplierEntryRepository.IsSaved(_supplierEntry);
        }

        public DataTable ShowSuppliers()
        {
            return _supplierEntryRepository.ShowSuppliers();
        }

        public bool IsCodeExist(SupplierEntry _supplierEntry)
        {
            return _supplierEntryRepository.isCodeExist(_supplierEntry);
        }

        public bool IsEmailExist(SupplierEntry _supplierEntry)
        {
            return _supplierEntryRepository.isEmailExist(_supplierEntry);
        }

        public bool IsContactExist(SupplierEntry _supplierEntry)
        {
            return _supplierEntryRepository.isContactExist(_supplierEntry);
        }

        //public DataTable SearchBy(Suppliers _suppliers)
        //{
        //    return _suppliersRepository.SearchBy(_suppliers);
        //}

        public bool IsEditExist(SupplierEntry _supplierEntry)
        {
            return _supplierEntryRepository.isEditExist(_supplierEntry);
        }
        public bool EditData(SupplierEntry _supplierEntry)
        {
            return _supplierEntryRepository.EditData(_supplierEntry);
        }
    }
}

