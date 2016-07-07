using System;
using System.Collections.Generic;
using UIOMatic.Attributes;
using UIOMatic.Enums;
using UIOMatic.Interfaces;
using Umbraco.Core.Persistence;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace UmbracoUIOMATIC.Models
{

[UIOMatic("MagicCard", "icon-users", "icon-user",ConnectionStringName="MagicContext", RenderType = UIOMaticRenderType.List)]
[TableName("MagicCard")]
public class Card : IUIOMaticModel
{
    public Card() { }

    [UIOMaticIgnoreField]
    [PrimaryKeyColumn(AutoIncrement = true)]
    public int ID { get; set; }

        [UIOMaticField("CardName","Enter the card name.")]
        public string CardName { get; set; }

        [UIOMaticField("CardText","Enter the card text.")]
        public string CardText { get; set; }

        [UIOMaticField("SetName","Enter the set name.")]
        public string SetName { get; set; }

        public enum Rarity
        {
            Common,
            Uncommon,
            Rare,
            Mythic,
            Promo
        }
        
        //Note the change here to the enum property set in the pure MVC app
        [UIOMaticField("Rarity", "Choose the rarity of the card", View="dropdown")]
        public Rarity CardRarity { get; set; }
        
        //Note the change here to the double property set in the pure MVC app
       // [UIOMaticField("CardPrice","Enter the card price.",View="number")]
       // public int CardPrice { get; set; }

        [UIOMaticField("CardQauntity","Enter the number of cards you want to sell.")]
        public int CardQuantity { get; set; }
    
    public IEnumerable<Exception> Validate()
    {
        var exs = new List<Exception>();

        if (string.IsNullOrEmpty(CardName))
            exs.Add(new Exception("Please provide a value for first name"));

        if (string.IsNullOrEmpty(SetName))
            exs.Add(new Exception("What set is the card from? The field looks blank to me."));

        //if (string.IsNullOrEmpty(Rarity))
           // exs.Add(new Exception("Please provide a value for Rarity"));

        //if (int.IsNull(CardPrice))
        //    exs.Add(new Exception("Please provide a value for last name"));

        // if (int.IsNullOrEmpty(CardQuantity))
        //    exs.Add(new Exception("Please provide a value for last name"));


        return exs;
    }
}


}