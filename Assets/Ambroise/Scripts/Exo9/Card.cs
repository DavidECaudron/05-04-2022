using UnityEngine;

namespace Exo9
{
    [CreateAssetMenu(fileName = "Card", menuName = "ScriptableObjects/Card", order = 1)]
    public class Card : ScriptableObject
    {
        [SerializeField] private eCardType cardType;
        [SerializeField] private Sprite picture;

        [SerializeField] private string title;
        [SerializeField] private string description;

        public void Print()
        {
            Debug.Log(
                cardType + "; " +

                title + "; " +
                description
            );
        }

        public eCardType CardType
        {
            get { return cardType; }
            set { cardType = value; }
        }
        public Sprite Picture
        {
            get { return picture; }
            set { picture = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
