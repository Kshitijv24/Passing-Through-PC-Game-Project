using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public GameObject Walls;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "WallCol"){
            transform.DetachChildren();
            Destroy(gameObject);
            FindObjectOfType<SpawningWallsScript>().StopSpawningWalls();
            GameManager.instance.gameOver = true;
            GameManager.instance.gameOverCanvas.SetActive(true);
        }
    }
}
