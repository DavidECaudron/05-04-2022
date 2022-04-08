using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Exo8
{
    public class Ash : MonoBehaviour, IMovable, ISpawner
    {
        [SerializeField]
        private float speed;
        [SerializeField]
        private float delayShoot;
        [SerializeField]
        private GameObject pokeball;
        [SerializeField]
        private float speedPokeball;
        [SerializeField]
        private GameObject endGame;
        private IEndGame endGameScript;
        private float lastShoot;
        private int pdv = 3;
        public void Move(Vector2 dir)
        {
            transform.position += new Vector3(dir.x, dir.y, 0);
        }

        void Awake()
        {
            endGameScript = endGame.GetComponent<IEndGame>();
        }

        public void Spawn(SpawnInformation toSpawn)
        {
            lastShoot = Time.time;

            GameObject go = Instantiate(pokeball, transform.position, Quaternion.identity);
            go.GetComponent<IMissile>().Initialize(Vector3.left, speedPokeball);
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

            if (Input.GetKeyDown(KeyCode.Space) && Time.time - lastShoot > delayShoot)
            {
                Spawn(new SpawnInformation());
            }
            move = move.normalized;
            Move(move * Time.deltaTime * speed);
        }

        void OnTriggerEnter2D(Collider2D col)
        {
            ProjectilePokemon proj = col.GetComponent<ProjectilePokemon>();
            if (proj != null)
            {
                pdv--;
                Destroy(proj.gameObject);
                if (pdv == 0)
                {
                    endGameScript.EndGame();
                }
            }
        }
    }
}
