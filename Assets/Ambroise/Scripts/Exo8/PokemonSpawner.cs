using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonSpawner : MonoBehaviour, ISpawner
{
    [SerializeField]
    List<Pokemon> pokemons;
    [SerializeField]
    Transform min, max;

    void Awake()
    {
        InvokeRepeating(nameof(SpawnPokemon), 1, 5);
    }

    void SpawnPokemon()
    {
        Spawn(new SpawnInformation() { position = new Vector3(UnityEngine.Random.Range(min.transform.position.x, max.transform.position.x),
            UnityEngine.Random.Range(min.transform.position.y, max.transform.position.y), 0)});
    }

    public void Spawn(SpawnInformation toSpawn)
    {

        Pokemon spawned =  Instantiate(pokemons[UnityEngine.Random.Range(0, pokemons.Count)].gameObject, toSpawn.position, Quaternion.identity).GetComponent<Pokemon>();
        spawned.OnSpawn();
    }
}
