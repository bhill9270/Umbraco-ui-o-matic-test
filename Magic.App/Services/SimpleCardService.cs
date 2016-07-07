using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Magic.App.Interfaces;

namespace Magic.App.Services
{
    public class SimpleCardService : IMagicService
    {
        public string GetMagic(CardType type)
        {
            var Card = string.Empty;

            switch (type)
            {
                case CardType.Soft:
                    Card = "Common";
                    break;
                case CardType.Glam:
                    Card = "Uncommon";
                    break;
                case CardType.Hard:
                    Card = "Rare";
                    break;
            }

            return Card;
        }
    }
}
 