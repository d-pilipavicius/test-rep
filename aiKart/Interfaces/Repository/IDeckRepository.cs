using aiKart.Dtos;
using aiKart.Models;

namespace aiKart.Interfaces;

public interface IDeckRepository
{
    IEnumerable<Deck> GetDecks();
    IEnumerable<Card> GetDeckCards(int deckId);
    Deck GetDeck(int id);
    bool DeckExistsById(int id);
    bool DeckExistsByName(string name);
    bool AddDeck(Deck deck);
    bool DeleteDeck(Deck deck);
    bool UpdateDeck(Deck deck);
    bool Save();
}