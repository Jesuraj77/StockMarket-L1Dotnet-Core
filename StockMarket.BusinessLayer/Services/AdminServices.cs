


using StockMarket.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket.BusinessLayer.Services
{
   public class AdminServices:IAdminServices
    {
       


        public bool AddCompany(List<Company> company)
        {
             return true;
        }


        public bool DeleteCompany(int Id)
        {
            return true;
        }


        public Company EditCompany(int Id)
        {
            Company Company = new Company();
            return Company;
        }


        public Company GetCompanyById(int Id)
        {
            Company Company = new Company();
            return Company;
        }


        public IPODetail GetIPOById(int Id)
        {
            IPODetail IPOdetail = new IPODetail();
            return IPOdetail;
        }


        public bool ImportData(object file)
        {
            return true;
        }


        public IPODetail UpdateIPODetail(int Id)
        {
            IPODetail IPOdetail= new IPODetail();
            return IPOdetail;
        }


        public List<Company> ViewCompany(Company company)
        {
            List<Company> CompanyList = new List<Company>();
            return CompanyList;
        }
    }
}
