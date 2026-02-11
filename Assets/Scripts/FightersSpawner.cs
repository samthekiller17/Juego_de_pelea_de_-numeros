using UnityEngine;

public class FightersSpawner : MonoBehaviour
{
    public Transform spawnPlayer;
    public Transform spawnEnemy;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int id = GameManager.instance.personajeElegido;
        Instantiate(GameManager.instance.personajes[id], spawnPlayer.position, spawnPlayer.rotation);

        int rand;
            do {
                  rand = Random.Range(0, GameManager.instance.personajes.Length);

                } while (rand == id);
        Instantiate(GameManager.instance.personajes[rand], spawnEnemy.position, spawnEnemy.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
