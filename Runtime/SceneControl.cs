using UnityEngine;
using UnityEngine.SceneManagement;

namespace Dic.Tools
{   
    /// <summary>
    /// 場景控制
    /// </summary>
    public class SceneControl : MonoBehaviour
    {   
        /// <summary>
        /// 進入場景
        /// </summary>
        /// <param name="sceneName"></param>
        public void LoadScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName);


        }
        /// <summary>
        /// 離開場景
        /// </summary>
        public void QuitGame()
        {
            Application.Quit();
        }
    }
}


