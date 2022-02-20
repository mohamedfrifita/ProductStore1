using System;
using System.Collections.Generic;
using System.Text;
using MF.Domain;


namespace MF.Service
{
  public static  class ProductExtension
    {
        public static void UpperName(this ProductManage ProductManage)
        {
            foreach (var item in ProductManage.products)
            {
                item.Name = item.Name.ToUpper();
            }
            
        }
        public static Boolean InCategory(this ProductManage ProductManage,string category)
        {
            foreach (var item in ProductManage.products)
            {
               if(item.MyCategory.Name.Equals(category))
                {
                    return true;
                }
                   
            }
            return false;
        }
    }
}
