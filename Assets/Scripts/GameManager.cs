using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState {
    menu,
    inGame,
    gameOver
}

public class GameManager : MonoBehaviour {

    public GameState currentGameState = GameState.menu;

    public static GameManager sharedInstance;

    private PlayerContraller controller;

    void Awake() {
        if (sharedInstance == null) {
            sharedInstance = this;
        }
    }

    // Start is called before the first frame update
    void Start() {
        controller = GameObject.Find("Player")
        .GetComponent<PlayerContraller>();
        
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetButtonDown("Submit") && currentGameState != GameState.inGame) {
            StartGame();
        }
    }

    public void StartGame() {
        SetGameState(GameState.inGame);
    }

    public void GameOver() {
        SetGameState(GameState.gameOver);
    }

    public void BackToMenu() {
        SetGameState(GameState.menu);
    }

    void SetGameState(GameState newGameState) {
        if (newGameState == GameState.menu) {
            //TODO: colocar la logica del menu
        }else if(newGameState == GameState.inGame){
            //TODO: hay que preparar la escena para jugar
            LevelManager.sharedInstance.RemoveAllLevelBlock();
            Invoke("ReloadLevel", 0.1f);
            
        }else if(newGameState == GameState.gameOver) {
            //TODO: preparar el juego para el Game Over
        }

        this.currentGameState = newGameState;
    }

    void ReloadLevel() {
LevelManager.sharedInstance.GenerateInitialBlock();
            controller.StartGame();
    }


}
