using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Exo8
{
    public class Pikachu : Pokemon
    {
        [SerializeField]
        protected IsNear isNear;
        public override void OnSpawn()
        {
            base.OnSpawn();
            for (int i = 0; i < 3; i++)
            {
                float angle = 0.33f * 2 * Mathf.PI * i;
                Vector3 direction = new Vector3(Mathf.Cos(angle), Mathf.Sin(angle), 0);
                MissileSpawner.instance.Spawn(new SpawnInformationMissile(transform.position, direction, Color.yellow, 0.3f, 4));

            }
        }

        public override bool TryCatch()
        {
            return isNear.GetTimer() >= 3;
        }

        public override void Attack(GameObject target)
        {
            transform.localScale *= 0.8f;
        }
    }
}
