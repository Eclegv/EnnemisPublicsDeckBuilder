#pragma warning disable S101 // Types should be named in PascalCase
#pragma warning disable CS8981 // Names should not be lower type only

using System;
using Blueprint41.Core;

namespace DeckBuilder.Generated.Manipulation
{
    internal class Register
    {
        [Obsolete]
        public static void Types()
        {
            if (DeckBuilder.Model.Datastore.Model.TypesRegistered)
                return;

            lock (typeof(Register))
            {
                if (DeckBuilder.Model.Datastore.Model.TypesRegistered)
                    return;

                ((ISetRuntimeType)DeckBuilder.Model.Datastore.Model.Entities["Action"]).SetRuntimeTypes(typeof(Action), typeof(Action));
                ((ISetRuntimeType)DeckBuilder.Model.Datastore.Model.Entities["Allie"]).SetRuntimeTypes(typeof(Allie), typeof(Allie));
                ((ISetRuntimeType)DeckBuilder.Model.Datastore.Model.Entities["Boss"]).SetRuntimeTypes(typeof(Boss), typeof(Boss));
                ((ISetRuntimeType)DeckBuilder.Model.Datastore.Model.Entities["Card"]).SetRuntimeTypes(typeof(ICard), typeof(Card));
                ((ISetRuntimeType)DeckBuilder.Model.Datastore.Model.Entities["CardSet"]).SetRuntimeTypes(typeof(CardSet), typeof(CardSet));
                ((ISetRuntimeType)DeckBuilder.Model.Datastore.Model.Entities["Eclipse"]).SetRuntimeTypes(typeof(Eclipse), typeof(Eclipse));
                ((ISetRuntimeType)DeckBuilder.Model.Datastore.Model.Entities["Reaction"]).SetRuntimeTypes(typeof(Reaction), typeof(Reaction));
                ((ISetRuntimeType)DeckBuilder.Model.Datastore.Model.Entities["Sbire"]).SetRuntimeTypes(typeof(Sbire), typeof(Sbire));
                ((ISetRuntimeType)DeckBuilder.Model.Datastore.Model.Entities["SbireUnique"]).SetRuntimeTypes(typeof(SbireUnique), typeof(SbireUnique));
                ((ISetRuntimeType)DeckBuilder.Model.Datastore.Model.Entities["Token"]).SetRuntimeTypes(typeof(Token), typeof(Token));
                ((ISetRuntimeType)DeckBuilder.Model.Datastore.Model.Entities["Valise"]).SetRuntimeTypes(typeof(Valise), typeof(Valise));
            }
        }
    }
}
