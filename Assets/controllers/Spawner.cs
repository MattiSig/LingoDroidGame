using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    private float nextSpawn = 0;
    public Transform EnemyPrefab;
    public Transform BonePrefab;
    public Transform FencePrefab;
    public float spawnRate = 1;
    public float randomDelay = 1;
    private string[,] fourWords = new string[,]{{"ég", "me", "f"}, {"þú", "you", "t"}, {"þau", "them", "f"}, {"okkur", "us", "f"}};

    // Use this for initialization
    void Start () {
        
	}
    private int counter = 1;
    // Update is called once per frame

    void Update () {
		if( Time.time > nextSpawn)
        {
            int countMod = counter % 5;
            if (counter%5 == 0)
            {
                var newEnemy = Instantiate(EnemyPrefab, transform.position, Quaternion.identity);
                var newEnemyScript = newEnemy.GetComponent<EnemyManager>();
                newEnemyScript.setButtonText(fourWords);                
            }
            else
            {
                var newBone = Instantiate(BonePrefab, transform.position, Quaternion.identity);
                var newBoneScript = newBone.GetComponent<BoneController>();
                newBoneScript.setIslWord(fourWords[countMod-1, 0]);
                newBoneScript.setEngWord(fourWords[countMod-1, 1]);
                Debug.Log(countMod);
            }
            nextSpawn = Time.time + spawnRate + Random.Range(0, randomDelay);
            counter++;
        }

	}
    public void refreshWords()
    {

    }
}
