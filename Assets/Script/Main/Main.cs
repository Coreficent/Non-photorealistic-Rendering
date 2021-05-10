namespace Coreficent.Main
{
    using Coreficent.Preset;
    using Coreficent.Utility;
    using UnityEngine;

    public class Main : Script
    {
        [SerializeField]
        private PresetBase standardShader;

        [SerializeField]
        private PresetBase unityShader;

        [SerializeField]
        private PresetBase animeShader;

        [SerializeField]
        private UnityModel unityModel;

        private bool hullToggleD = false;
        private bool sobelToggleD = false;

        private Main()
        {

        }

        protected void OnGUI()
        {
            GUI.Box(new Rect(Screen.width - 110, 110, 100, 180), "Change Shader");

            if (GUI.Button(new Rect(Screen.width - 100, 140, 80, 20), "Standard"))
            {
                Test.Debug("Standard shader");
            }
            if (GUI.Button(new Rect(Screen.width - 100, 170, 80, 20), "Unity"))
            {
                Test.Debug("Unity shader");
            }
            if (GUI.Button(new Rect(Screen.width - 100, 200, 80, 20), "Coreficent"))
            {
                Test.Debug("Coreficent shader");
            }

            bool hullToggle = GUI.Toggle(new Rect(Screen.width - 100, 230, 80, 20), hullToggleD, "hullToggleD");

            if (hullToggle != hullToggleD)
            {
                hullToggleD = hullToggle;
                Test.Debug("toggle", hullToggleD);
            }

            bool sobelToggle = GUI.Toggle(new Rect(Screen.width - 100, 260, 80, 20), sobelToggleD, "sobelToggle");

            if (sobelToggle != sobelToggleD)
            {
                sobelToggleD = sobelToggle;
                Test.Debug("toggle", sobelToggleD);
            }
        }

        protected void Update()
        {
            if (Input.GetKey(KeyCode.Alpha1))
            {
                unityModel.Body = unityShader.Body;
                unityModel.Hair = unityShader.Hair;
                unityModel.Skin = unityShader.Skin;
                unityModel.Face = unityShader.Face;
            }
            else if (Input.GetKey(KeyCode.Alpha2))
            {
                unityModel.Body = standardShader.Body;
                unityModel.Hair = standardShader.Hair;
                unityModel.Skin = standardShader.Skin;
                unityModel.Face = standardShader.Face;
            }
            else if (Input.GetKey(KeyCode.Alpha3))
            {
                unityModel.Body = animeShader.Body;
                unityModel.Hair = animeShader.Hair;
                unityModel.Skin = animeShader.Skin;
                unityModel.Face = animeShader.Face;
            }
        }
    }
}
