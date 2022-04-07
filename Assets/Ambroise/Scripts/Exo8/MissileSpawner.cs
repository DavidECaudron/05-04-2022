using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileSpawner : MonoBehaviour, ISpawner
{
    public static MissileSpawner instance;
    [SerializeField]
    GameObject missilePrefab;
    void Awake()
    {
        instance = this;
    }

    public void Spawn(SpawnInformation toSpawn)
    {
        SpawnInformationMissile spawnInformationMissile = toSpawn as SpawnInformationMissile;
        GameObject go = Instantiate(missilePrefab, spawnInformationMissile.position, Quaternion.identity);
        go.transform.localScale *= spawnInformationMissile.scale;
        go.GetComponent<SpriteRenderer>().color = spawnInformationMissile.colorMissile;
        go.GetComponent<IMissile>().Initialize(spawnInformationMissile.direction, spawnInformationMissile.speed);

    }
}
