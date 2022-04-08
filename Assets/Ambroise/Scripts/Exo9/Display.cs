using UnityEngine;
using UnityEngine.UI;

namespace Exo9
{
    public class Display : MonoBehaviour
    {
        [SerializeField] private Image picture;
        [SerializeField] private Text title;
        [SerializeField] private Text description;
        [SerializeField] private Text type;

        public Sprite Picture
        {
            get { return picture.sprite; }
            set { picture.sprite = value; }
        }
        public Text Title
        {
            get { return title; }
            set { title = value; }
        }
        public Text Description
        {
            get { return description; }
            set { description = value; }
        }
        public Text Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}
