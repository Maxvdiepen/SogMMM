using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    //Public Variables
    public GameObject objectToSpawn;
    public Transform spawnPoint;
    //Variables End

    //Initialization
    void Start()
    {
        spawn(objectToSpawn, spawnPoint);
    }

    //Function for spawning
    private void spawn(GameObject Object, Transform dest)
    {
        Object.transform.position = dest.position;
    }
}
