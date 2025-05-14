using UnityEngine;

public class PlayerBallFinish : MonoBehaviour
{
    //Public Variables
    public Collider finishZone;
    public GameObject player;
    //Variables End

    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("collision registered");
        if (collider.gameObject == player)
        {
            Debug.Log("GJ buddy you won");
        }
    }
}
