using UnityEngine;

public class DeathZoner : MonoBehaviour
{
    public GameObject player;

    private void OnCollisionEnter2D(Collision2D targetObj)
    {
        if (targetObj.gameObject != player) return;
        player.GetComponent<Respawnn>().Respawn();
    }
}