using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningWallsScript : MonoBehaviour
{
    public static SpawningWallsScript instance;

    public GameObject Walls;
    
    public int xPosition;
    public int yPosition;
    public int zPosition;

    private void Awake(){
        instance = this;
    }

    void Start(){
        StartSpawningWalls();
    }

    void SpawnWalls(){

        int xPos = Random.Range(-xPosition, xPosition);
        int yPos = Random.Range(-yPosition, yPosition);

        Instantiate(Walls, new Vector3(xPos, yPos, transform.position.z), Quaternion.identity);
    }

    IEnumerator WallsSpawn(){

        yield return new WaitForSeconds(1f);

        while (true){
            
            SpawnWalls();

            yield return new WaitForSeconds(2f);
        }
        
    }

    public void StartSpawningWalls(){
        StartCoroutine("WallsSpawn");
    }

    public void StopSpawningWalls(){
        StopCoroutine("WallsSpawn");
    }
}
