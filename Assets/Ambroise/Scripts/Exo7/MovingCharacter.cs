using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Exo7
{
    public class MovingCharacter : MonoBehaviour
    {
        #region Serialized Fields
        [SerializeField]
        float speed;
        bool bouclier;
        #endregion

        #region Unity Functions
        void OnTriggerEnter(Collider other)
        {
            IEatable otherEatable = other.GetComponent<IEatable>();
            if (otherEatable != null)
            {
                otherEatable.EatMe(gameObject);
                Destroy((otherEatable as MonoBehaviour).gameObject);
            }
            IEnnemy otherEnnemy = other.GetComponent<IEnnemy>();
            if (otherEnnemy != null && !bouclier)
            {
                otherEnnemy.Attack(gameObject);
            }
        }

        void Update()
        {
            Vector3 move = Vector3.zero;
            if (Input.GetKey(KeyCode.DownArrow))
                move += Vector3.down;
            if (Input.GetKey(KeyCode.UpArrow))
                move += Vector3.up;
            if (Input.GetKey(KeyCode.LeftArrow))
                move += Vector3.left;
            if (Input.GetKey(KeyCode.RightArrow))
                move += Vector3.right;

            bouclier = Input.GetKey(KeyCode.Space);
            move = move.normalized;
            transform.position += move * Time.deltaTime * speed;
        }
        #endregion
    }
}
