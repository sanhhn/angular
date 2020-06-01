using blazordemo.Data;
using System.Collections.Generic;

namespace blazordemo.Logics
{
    public interface IGadgetLogic
    {
         IList<Gadget> GetAll();
         Gadget AddGadget(Gadget gadget);
         Gadget UpdateGadget(Gadget gadget);         
         void Delete(Gadget gadget);
    }
}