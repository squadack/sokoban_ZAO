using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameController gameController;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2Int moveDirection = new Vector2Int();
        //TODO
        //w zaleznosci od wcisnietych kalawiszy ustaw moveDirection na jedno z (1, 0), (-1, 0), (0, 1), (0, -1)
        //jeżeli jakis ruch chcemy wykonac to informujemy gameController o probie ruchu
        if (gameController.TryMovePlayer(moveDirection)) {
            //udalo sie zrobic ruch 
        }

    }
}
