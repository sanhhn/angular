using blazordemo.Data;
using System.Collections.Generic;
using System.Linq;

namespace blazordemo.Logics
{
    public class GadgetLogic: IGadgetLogic
    {
        public readonly datadbcontext _dbcontext;

        public GadgetLogic(datadbcontext _indbcontext)
        {
            _dbcontext = _indbcontext;
        }

        public Gadget AddGadget(Gadget gadget)
        {
            _dbcontext.Gadgets.Add(gadget);
            _dbcontext.SaveChanges();

            return gadget;
        }

        public IList<Gadget> GetAll()
        {
            IList<Gadget> gadgets = _dbcontext.Gadgets.ToList();
            return gadgets;
        }

        public Gadget UpdateGadget(Gadget gadget)
        {
            _dbcontext.Gadgets.Update(gadget);
            _dbcontext.SaveChanges();
            return gadget;
        }
        public void Delete(Gadget gadget)
        {
            _dbcontext.Gadgets.Remove(gadget);
            _dbcontext.SaveChanges();
        }
    }
}