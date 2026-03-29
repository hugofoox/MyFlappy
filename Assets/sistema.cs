using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sistema : MonoBehaviour
{
    public float _time;

    public TMP_Text _textScore;

    public GameObject _telaStart;
    public GameObject _telaPerdeu;

    public int _saveScore;
    public TMP_Text _textSaveScore;

    void Start()
    {
        _saveScore = PlayerPrefs.GetInt("Score", 0);
        _textSaveScore.text = _saveScore.ToString();

        _telaPerdeu.SetActive(false);
        _telaStart.SetActive(true);
        _textScore.enabled = false;
        Time.timeScale = 0f;
    }

    void Update()
    {
        _time += Time.deltaTime;
        _textScore.text = Mathf.FloorToInt(_time).ToString();
    }

    public void SistemaPerdeu()
    {
        if (_time > _saveScore)
        {
            PlayerPrefs.SetInt("Score", Mathf.FloorToInt(_time));
        }

        _telaPerdeu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void _ButtonStart()
    {
        Time.timeScale = 1f;
        _telaStart.SetActive(false);
        _textScore.enabled = true;

    }


    public void _ButtonRestart()
    {
        int cenaAtiva = SceneManager.GetActiveScene().buildIndex;
        Time.timeScale = 1f;
        SceneManager.LoadSceneAsync(cenaAtiva, LoadSceneMode.Single);
    }
}
