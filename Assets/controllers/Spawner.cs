using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    private float nextSpawn = 0;
    public Transform EnemyPrefab;
    public Transform BonePrefab;
    public Transform FencePrefab;
    public float spawnRate = 4;
    public float randomDelay = 4;
    private string[,] fourWords = new string[,]{{"ég", "me", "f"}, {"þú", "you", "t"}, {"þau", "them", "f"}, {"okkur", "us", "f"}};
    private int randomNum;

    // Use this for initialization
    void Start () {
        refreshWords();
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
                Debug.Log("hraðari");       
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

            if (countMod == 1)
            {
                refreshWords();
                if (counter > 1 && randomDelay > 0.3)
                {
                    double letItFloat = 0.3;
                    spawnRate -= (float)letItFloat;
                    randomDelay -= (float)letItFloat;
                    Debug.Log(spawnRate);
                    Debug.Log(randomDelay);
                }
                
            }

            counter++;

        }



    }

   // köllum i´Db og veljum orð sem fer á vonda kall
    public void refreshWords()
    {
       
        // fourWords = kall á Arnor 
        randomNum = Random.Range(0, 3);
        for(int i=0; i < 4; i++)
        {
            fourWords[i, 2] = "f";
        }
        fourWords[randomNum, 2] = "t";
    }

}
