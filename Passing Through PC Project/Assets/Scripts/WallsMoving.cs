using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsMoving : MonoBehaviour
{
    SpawningWallsScript spawningWallsScriptRefrance;

    public float wallSpeed;

    private void Awake(){
        spawningWallsScriptRefrance = GetComponent<SpawningWallsScript>();
    }

    void Update(){

        transform.position += -transform.forward * wallSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Player"){
            GameManager.instance.IncrementScore();
        }
    }
}
