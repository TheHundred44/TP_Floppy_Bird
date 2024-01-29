using System.Threading.Tasks;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    public GameObject PipePrefab;
    [SerializeField]
    private float _intervalleGeneration = 2f;
    private float _hauteurMin = 0.47f;
    private float _hauteurMax = 1.78f;
    [SerializeField]
    private float _speed = 5f;

    [SerializeField]
    private float _tempsDerniereGeneration;
    [SerializeField]
    private float _rangeDestroy;

    private void Update()
    {
        if (Time.time - _tempsDerniereGeneration > _intervalleGeneration)
        {
            float hauteurAleatoire = Random.Range(_hauteurMin, _hauteurMax);
            Vector3 position = new Vector3(transform.position.x, hauteurAleatoire, 0.029f);
            GameObject _pipePrefab = Instantiate(PipePrefab, position, Quaternion.identity);

            _tempsDerniereGeneration = Time.time;
            DeplacerPrefabs(_pipePrefab);
        }
    }

    private async void DeplacerPrefabs(GameObject _prefabs)
    {
        for (int i = 0; i<_rangeDestroy; i++)
        {
            _prefabs.transform.Translate(Vector2.left * _speed * Time.deltaTime);
            await Task.Delay(5);
        }

        Destroy(_prefabs.gameObject);
    }
}
