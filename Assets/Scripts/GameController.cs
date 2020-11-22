using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject wallPrefab;
    public GameObject floorPrefab;
    public GameObject targetPrefab;
    public GameObject boxPrefab;
    public GameObject playerPrefab;

    List<Level> levels;
    public int currentLevel = 0;

    private GameObject[,] boxes;
    private Vector2Int playerPos;
    private Player playerObject;

    // Start is called before the first frame update
    void Start()
    {
        //wczytac poziomy do listy levels i zaladowac pierwszy
        levels = new List<Level>();
        levels.Add(new Level());
        LoadLevel(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LoadLevel(int idx) {
        currentLevel = idx;
        Level lev = levels[currentLevel];

        boxes = new GameObject[lev.width, lev.height];

        //TODO na podstawie levels[currentLevel] robimy Instantiate odpowiednich prefabów w odp. miejscach
        //jezeli na polu [x, y] znajduje się skrzynia to wynik Instantiate zapisujemy do boxes na wsp. [x, y]
        //jesli na polu jest gracz to wynik Instantiate zapisujemy w playerGameObject i zapamietujemy
        //wspolrzedne gracza w playerPos

        // playerObject = FindObjectOfType<Player>();
        playerObject = GameObject.FindWithTag("Player").GetComponent<Player>();
        playerObject.gameController = this;

        //TODO Wycentrowac Camera.main na srodku poziomu i oddalic (ortographicSize) tak, zeby miescil sie cały na ekranie
    }

    public bool TryMovePlayer(Vector2Int direction) {
        //patrzymy na pole playerPos + direction:
        // jezeli jest tam ściana to nie robimy ruchu
        // jezeli jest tam skrzynia to próbujemy ją przesunąć i jeśli się udało to przesuwamy też gracza
        // aktualizując jego playerPos i pozycję obiektu na ekranie
        return false;
    }

    private bool TryMoveBox(Vector2Int pos, Vector2Int direction) {
        //jezeli na polu pos + direction jest ściana lub pudełko to się nie da przesunąć i zwracamy false;
        return false;
        //w przeciwnym przypadku przesuwamy pudełko aktualizując jego pozycję w tablicy i pozycję na ekranie;
        UpdateCorrectBoxes();
        return true;
    }

    private void UpdateCorrectBoxes() {
        //TODO przeiterowac po wspolrzednych, na których są targety i sprawdzic na ilu z nich jest skrzynia
    }
}


