using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    private float nextSpawn = 0;
    public Transform EnemyPrefab;
    public Transform BonePrefab;
    public float spawnRate = 1;
    public float randomDelay = 1;
     
	// Use this for initialization
	void Start () {
		
	}
    private int counter = 1;
    // Update is called once per frame

    void Update () {
		if( Time.time > nextSpawn)
        {
            if (counter%5 == 0)
            {
                var newEnemy = Instantiate(EnemyPrefab, transform.position, Quaternion.identity);
                newEnemy.transform.parent = gameObject.transform;
            }
            else
            {
                var newBone = Instantiate(BonePrefab, transform.position, Quaternion.identity);
                newBone.transform.parent = gameObject.transform;
            }
            nextSpawn = Time.time + spawnRate + Random.Range(0, randomDelay);
            counter++;
        }
	}


    void makeArray () { 
    int[] words = new int[4];
        for (int i = 0; i < words.Length; i++){
            int fetchWord = Random.Range(0, 100);
            words[i] = fetchWord;
        }
        
        Debug.Log();
    }



}
