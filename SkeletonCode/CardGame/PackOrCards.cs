using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkeletonCode.CardGame
{
    public class PackOrCards : List<ICard>, IPackOfCards
    {

        public void Shuffle()
        {
            int n = base.Count;
            var array = base.ToArray();
            Random rng = new Random();

            while (n > 1)
            {
                int k = rng.Next(n--);
                var temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }

        public ICard TakeCardFromTopOfPack()
        {
            ICard card = this[0];

            base.RemoveAt(0);

            return card;
            
        }
    }
}
