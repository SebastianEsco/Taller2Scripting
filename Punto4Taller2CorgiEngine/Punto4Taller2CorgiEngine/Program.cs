public class LevelManager : Singleton<LevelManager>
{
    public string[] LevelNames;

    public void LoadLevel(int index)
    {
        StartCoroutine(LoadLevelAsync(LevelNames[index]));
    }

    private IEnumerator LoadLevelAsync(string levelName)
    {
        // Mostrar pantalla de carga

        yield return SceneManager.LoadSceneAsync(levelName);

        // Ocultar pantalla de carga
    }
}


