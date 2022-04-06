using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Exo7
{
    public class MovingCharacter : MonoBehaviour
    {
        [SerializeField] private float speed = 10;

        private void Update()
        {
            Movements();
        }

        private void Movements()
        {
            Vector3 move = Vector3.zero;
            if (Input.GetKey(KeyCode.UpArrow))
            {
                move += new Vector3(0, 0, 1);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                move += new Vector3(0, 0, -1);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                move += new Vector3(-1, 0, 0);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                move += new Vector3(1, 0, 0);
            }

            this.transform.position += move.normalized * speed * Time.deltaTime;
        }
    }
}
