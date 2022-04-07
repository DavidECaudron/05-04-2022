using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Exo2
{
    public class RandomBehaviour : MonoBehaviour
    {
        [SerializeField] private Material materialRed;
        [SerializeField] private Material materialWhite;

        private MeshRenderer meshRenderer;

        private float tempSize;
        private float tempColor;

        private bool isEnded = false;

        private void Start()
        {
            meshRenderer = this.GetComponent<MeshRenderer>();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space) && isEnded == false)
            {
                tempSize = Random.Range(0, 6);
                tempColor = Random.Range(0, 50);
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                ResetGame();
            }

            if (tempColor == 1.0f)
            {
                tempColor = -1.0f;
                ColorChange();
            }
            if (tempSize == 1.0f)
            {
                tempSize = -1.0f;
                SizePlus();
            }
            if (tempSize == 2.0f)
            {
                tempSize = -1.0f;
                SizeMinus();
            }
        }

        private void SizePlus()
        {
            this.transform.localScale = new Vector3(this.transform.localScale.x * 2.2f, this.transform.localScale.y * 2.2f, this.transform.localScale.z * 2.2f);
        }

        private void SizeMinus()
        {
            this.transform.localScale = new Vector3(this.transform.localScale.x * 0.5f, this.transform.localScale.y * 0.5f, this.transform.localScale.z * 0.5f);
        }

        private void ColorChange()
        {
            meshRenderer.material = materialRed;
            isEnded = true;
            Debug.Log("Game is over");
        }

        private void ResetGame()
        {
            this.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            meshRenderer.material = materialWhite;
            isEnded = false;
            Debug.Log("Game is reset");
        }
    }
}
