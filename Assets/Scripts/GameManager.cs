using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class GameManager : MonoBehaviour
    {
        Quiz quiz;
        EndScreen endScreen;

        private void Awake()
        {
            quiz = FindObjectOfType<Quiz>();
            endScreen = FindObjectOfType<EndScreen>();
        }

        void Start()
        {
            quiz.gameObject.SetActive(true);
            endScreen.gameObject.SetActive(false);
        }

        void Update()
        {
            if (quiz.isComplete)
            {
                quiz.gameObject.SetActive(false);
                endScreen.gameObject.SetActive(true);
                endScreen.ShowFinalScore();
            }
        }

        public void OnReplayLevel()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
