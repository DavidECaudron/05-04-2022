using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Exo4
{
    public class CubeBehaviour : MonoBehaviour
    {
        [SerializeField] private float speed = 10;

        // private BoxCollider boxCollider;
        // private Rigidbody rigidBody;

        private void Start()
        {
            // boxCollider = this.GetComponent<BoxCollider>();
            // rigidBody = this.GetComponent<Rigidbody>();
        }

        private void Update()
        {
            Movements();
        }

        private void Movements()
        {
            Vector3 move = Vector3.zero;
            if (Input.GetKey(KeyCode.UpArrow))
            {
                // this.transform.Translate(new Vector3(0, 0, 0.25f));
                // rigidBody.AddForce(new Vector3(0, 0, 0.25f) * speed, ForceMode.Impulse);
                move += new Vector3(0, 0, 1);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                // this.transform.Translate(new Vector3(0, 0, -0.25f));
                // rigidBody.AddForce(new Vector3(0, 0, -0.25f) * speed, ForceMode.Impulse);
                move += new Vector3(0 ,0 ,-1);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                // this.transform.Translate(new Vector3(-0.25f, 0, 0));
                // rigidBody.AddForce(new Vector3(-0.25f, 0, 0) * speed, ForceMode.Impulse);
                move += new Vector3(-1, 0, 0);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                // this.transform.Translate(new Vector3(0.25f, 0, 0));
                // rigidBody.AddForce(new Vector3(0.25f, 0, 0) * speed, ForceMode.Impulse);
                move += new Vector3(1, 0, 0);
            }

            this.transform.position += move.normalized * speed * Time.deltaTime;
        }
    }
}
