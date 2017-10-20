using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KurtiKamizOnline.Domain.Entities;
using KurtiKamizOnline.Domain.Concrete;


namespace KurtiKamizOnline.Domain.Abstract
{
    public interface IOrderProcessor
    {
        void ProcessOrder(Cart cart, ShippingDetails shippingDetails);
    }
}
