using System;
using System.Collections.Generic;
using System.Text;
using MF.Domain;
using System.Linq;

namespace MF.Service
{
    public delegate IList<Product> FindProduct1(string firstLettre, IList<Product> products);
    public delegate IList<Product> ScanProduct1(Category category, IList<Product> products);

    public class ProductManage
    {
       public IList<Product> products;

        public ProductManage(IList<Product> products)
        {
            this.products = products;

        }
        //Partie 2 Q4)a/
        public IList<Product>FindProduct2(string c) 
        {
            IList<Product>list=new List<Product>();
            foreach (Product p in products)
            {
                if (p.Name.StartsWith(c)) {
                    list.Add(p);
                }
               
            }
            return list;
        }
        //Partie 2 Q4)b/
        public IList<Product> ScanProduct2(Category category)
        {
            IList<Product> list = new List<Product>();
            foreach (Product p in products)
            {
                if (p.MyCategory.Equals(category))
                {
                    list.Add(p);
                }

            }
            return list.ToList();
        }

        //Partie 2 Q6)

        FindProduct1 fp1 = delegate (string fl, IList<Product> prods)
          {
              var result = from p in prods
                           where p.Name.StartsWith(fl)
                           select p;
              return result.ToList();
          }; 
        
        ScanProduct1 sp1 = delegate (Category category, IList<Product> prods)
        {
            var result = from p in prods
                         where p.MyCategory.Equals(category)
                         select p;
            return result.ToList();
        };

        //Partie 2 Q7/
        public IList<Product>FindProduct(string c)
        {
            return products.Where(p => p.Name.StartsWith(c)).ToList();
        }
        public IList<Product> ScanProduct(Category category)
        {
            return products.Where(p => p.MyCategory.Equals(category)).ToList();
        }
    }
}
