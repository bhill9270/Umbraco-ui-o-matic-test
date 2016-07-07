using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Magic.App.Interfaces
{
    public enum CardType
    {
        Soft = 0,
        Hard = 1,
        Glam = 2
    }
    public interface IMagicService
    {
        string GetMagic(CardType type);
    }
}