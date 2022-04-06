using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Exo4
{
    public class CubeBehaviour : MonoBehaviour
    {
        [SerializeField] private Material materialRed;
        [SerializeField] private Material materialWhite;

        private BoxCollider boxCollider;
        private MeshRenderer meshRenderer;
        private Rigidbody rigidBody;

        private void Start()
        {
            boxCollider = this.GetComponent<BoxCollider>();
            meshRenderer = this.GetComponent<MeshRenderer>();
            rigidBody = this.GetComponent<Rigidbody>();
        }

        private void Update()
        {
            Movements();
        }

        private void Movements()
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                // this.transform.Translate(new Vector3(0, 0, 0.25f));
                rigidBody.AddForce(new Vector3(0, 0, 0.25f), ForceMode.Impulse);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                // this.transform.Translate(new Vector3(0, 0, -0.25f));
                rigidBody.AddForce(new Vector3(0, 0, -0.25f), ForceMode.Impulse);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                // this.transform.Translate(new Vector3(-0.25f, 0, 0));
                rigidBody.AddForce(new Vector3(-0.25f, 0, 0), ForceMode.Impulse);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                // this.transform.Translate(new Vector3(0.25f, 0, 0));
                rigidBody.AddForce(new Vector3(0.25f, 0, 0), ForceMode.Impulse);
            }
        }

        private void OnCollisionEnter(Collision collision)
        {
            meshRenderer.material = materialRed;
        }

        private void OnCollisionExit(Collision collision)
        {
            meshRenderer.material = materialWhite;
        }
    }
}
