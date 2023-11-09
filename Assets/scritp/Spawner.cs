using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Spawner : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject target;
    private float t;
    // Update is called once per frame
    void Update()

    {

        if (t > 3)

        {

            GameObject g = Instantiate(Enemy);

            g.transform.position = new Vector3(Random.Range(-10, 10), 28, Random.Range(-10, 10));

            g.GetComponent<EnemyControl>().target = target.transform;

            t = 0;

        }



        t += Time.deltaTime;

    }

}
