using System.Net;
using System.Web.Http;
using models.Cards;
using models.CardSets;
using webapi.Nodes.Cards.Repository;
using webapi.Nodes.CardSets.Input;
using webapi.Nodes.CardSets.Repository;

namespace webapi.Nodes.CardSets.Service;

public class CardSetService
{
    private readonly CardSetRepository _cardSetRepository;
    private readonly CardRepository _cardRepository;

    public CardSetService(CardSetRepository cardSetRepository, CardRepository cardRepository)
    {
        _cardSetRepository = cardSetRepository;
        _cardRepository = cardRepository;
    }

    public List<CardSet> ReadAllCardSet()
    {
        return _cardSetRepository.ReadAllCardSet();
    }

    public List<Card> ReadCardsFromCardSet(ReadCardsFromCardSetInput input)
    {
        CardSet? cardSet = _cardSetRepository.ReadCardSet(input.CardSetId);

        if(_cardSetRepository.ReadCardSet(input.CardSetId) is null)
            throw new HttpResponseException(HttpStatusCode.Unauthorized);

        return _cardRepository.ReadAllCardsFromCardSet(new(input.CardSetId));
    }
}