using System.Collections.Generic;
using UnityEngine;

namespace Exo9
{
    public class DeckManager : MonoBehaviour
    {
        [SerializeField] private List<Card> listCard = new List<Card>();

        [SerializeField] private GameObject displayCanvas;
        [SerializeField] private GameObject display;

        [SerializeField] private Sprite picture;

        private void Start()
        {
            DeckGeneration();
            // DeckPrint();
        }

        private void DeckGeneration()
        {
            Card card = ScriptableObject.CreateInstance<Card>();
            Display _display = display.GetComponent<Display>();

            for (int i = 0; i < 4; i += 1)
            {
                for (int j = 1; j <= 10; j += 1)
                {
                    card.CardType += i;

                    switch (card.CardType)
                    {
                        case eCardType.gobelin:
                            card.Title = "Gobelin";
                            card.Description = "gain 1 point for each goblin in your hand";
                            card.Picture = picture;

                            _display.Picture = card.Picture;
                            _display.Title.text = card.Title.ToString();
                            _display.Description.text = card.Description.ToString();
                            _display.Type.text = card.CardType.ToString();
                            break;
                        case eCardType.mermaid:
                            card.Picture = picture;
                            card.Title = "Mermaid";
                            card.Description = "gain 3 points if there is no other mermaid in your hand & can't be played if there is a dragon in your hand";

                            _display.Picture = card.Picture;
                            _display.Title.text = card.Title.ToString();
                            _display.Description.text = card.Description.ToString();
                            _display.Type.text = card.CardType.ToString();
                            break;
                        case eCardType.skeleton:
                            card.Picture = picture;
                            card.Title = "Skeleton";
                            card.Description = "gain 1 point for every skeleton played before this one";

                            _display.Picture = card.Picture;
                            _display.Title.text = card.Title.ToString();
                            _display.Description.text = card.Description.ToString();
                            _display.Type.text = card.CardType.ToString();
                            break;
                        case eCardType.dragon:
                            card.Picture = picture;
                            card.Title = "Dragon";
                            card.Description = "discard your hand & draw 5 cards & loose 1 point for each card in your hand if you draw a dragon";

                            _display.Picture = card.Picture;
                            _display.Title.text = card.Title.ToString();
                            _display.Description.text = card.Description.ToString();
                            _display.Type.text = card.CardType.ToString();
                            break;
                        default:
                            Debug.Log("Failed deck generation");
                            break;
                    }

                    listCard.Add(card);

                    Instantiate(display, displayCanvas.transform);
                    display.transform.position = new Vector3(0, 0, 0);

                    card = ScriptableObject.CreateInstance<Card>();
                }
            }
        }

        private void DeckPrint()
        {
            foreach (Card card in listCard)
            {
                card.Print();
            }
        }
    }
}
