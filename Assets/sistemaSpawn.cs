using UnityEngine;

public class sistemaSpawn : MonoBehaviour
{
    public Transform _pivot;
    public GameObject _prefabNuvem;

    public int _idSpawn;
    public Transform[] _pontosSpawn;

    public float _tempo;
    public float _intervalo = 3f;
    public float _tDestuir = 10f;

    void Start()
    {
        
    }

    void Update()
    {
        _tempo += Time.deltaTime;

        if (_tempo >= _intervalo)
        {
            Spawnar();
            _tempo = 0;
        }

        transform.position = new Vector3(_pivot.position.x, transform.position.y, transform.position.z);
    }


    void Spawnar()
    {
        _idSpawn = Random.Range(0, _pontosSpawn.Length);
        GameObject temp_nuvem = Instantiate(_prefabNuvem, _pontosSpawn[_idSpawn].position, Quaternion.identity);

        float temp_num = Random.Range(0.2f, 0.6f);
        temp_nuvem.transform.localScale = new Vector3(temp_num, temp_num, temp_num);
        Destroy(temp_nuvem, _tDestuir);

    }
}
