using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWinformControl
{
    class Cakes
    {
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private BakeryType type;

        public BakeryType Type
        {
            get { return type; }
            set { type = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private float ppu;

        public float Ppu
        {
            get { return ppu; }
            set { ppu = value; }
        }

        private List<Batter> batter;

        public List<Batter> Batter
        {
            get { return batter; }
            set { batter = value; }
        }

        private List<Topping> topping;

        public List<Topping> Topping
        {
            get { return topping; }
            set { topping = value; }
        }


    }
}
