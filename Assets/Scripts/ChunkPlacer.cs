using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkPlacer : MonoBehaviour
{
/*Данный скрипт - основная логика игры, он выбирает случайным образом чанк из списка, и спавнет на конце последнего.
скрипт Chunk.cs связан с этим скриптом прежде всего из-за того, что этот скрипт из него берёт позицию начала, и конца.*/
    public Transform Player; //Здесь мы получаем позицию персонажа.
    public GameObject StartObjects; //Здесь мы получаем те объекты, которые уже существовали на сцене, соответсвенно - не принимают участия в спавне.
    public Chunk[] ChunkPrefabs; //А это тот самый список чанков, который мы заполняем заранее. В список добавляються только те объекты, на которых есть скрипт Chunk.cs
    public Chunk FirstChunk; //Самый первый чанк, обычно ставится вручную.

    private List<Chunk> spawnedCnunks = new List<Chunk>(); //Массив с чанками, которые уже заспавнены
    // Start is called before the first frame update
    void Start()
    {
        spawnedCnunks.Add(FirstChunk); //Добавляем первый чанк в список, чтобы алгоритм уже сам его удалил.
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.transform.position.x < spawnedCnunks[spawnedCnunks.Count - 1].End.position.x + 20)/*Условие, в котором говорится "Если позиция персонажа
        больше позиции последнего чанка увеличеной на 20 юнитов, заспавнить ещё один чанк*/
        {
            Spawn();
        }
    }
    private void Spawn() //Самый главный алгоритм, тут спавнятся чанки, и удаляються не нужные
    {
        Chunk newChunk = Instantiate(ChunkPrefabs[Random.Range(0, ChunkPrefabs.Length)]); //Спавним случайный чанк
        newChunk.transform.position = spawnedCnunks[spawnedCnunks.Count - 1].End.position; //Задаём ему позицию конца предыдущего чанка.
        spawnedCnunks.Add(newChunk);//Добавляем в список

        if (spawnedCnunks.Count >= 8)//Условие прикотором нужно удалять тот чанк, который за камерой
        {
            spawnedCnunks[0].gameObject.SetActive(false);//Вот тут я забыл сделать Destroy
            StartObjects.SetActive(false);//Вот тут я забыл сделать Destroy
            spawnedCnunks.RemoveAt(0); //Удаляем из списка уже удалённый чанк
        }
    }
}
