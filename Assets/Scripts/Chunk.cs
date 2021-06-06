using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{
//Данный скрипт должен быть на каждом чанке игры
    public Transform Begin; //Это начало чанка, если посмотришь на сами префабы, поймёшь что куда ставить. Префабы в папке "Chunks"
    public Transform End; //Это соответсвенно конец чанка, к которому спавнится начало следующего чанка
}
