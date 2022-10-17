using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public  static LevelManager sharedInstance;

    public List<LevelBlock> allTheLevelBlocks = new List<LevelBlock>();

    public List<LevelBlock> currentLevelBlocks = new List<LevelBlock>();

    public Transform levelStartPosition;

    void Awake() {

        if ( sharedInstance == null ){
            sharedInstance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        GenerateInitialBlock();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddLevelBlock(){

    }

    public void RemoveLevelBlock(){

    }

    public void RemoveAllLevelBlock() {

    }

    public void GenerateInitialBlock() {

        for (int i = 0; i < 2; i++)
   {
            AddLevelBlock();
        }
    }
}
