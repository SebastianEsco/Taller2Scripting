using UnityEngine;

public class GameManager: MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            // evita que el objeto se destruya al cargar una nueva escena
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // Si ya existe una instancia destruye la nueva instancia
            Destroy(gameObject);
        }
    }
}
    


