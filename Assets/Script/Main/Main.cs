namespace Coreficent.Main
{
    using Coreficent.Preset;
    using Coreficent.Shading;
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

        [SerializeField]
        private PostProcessor postProcessor;

        [SerializeField]
        private MeshRenderer floor;

        private bool hullToggled = false;
        private bool sobelToggled = false;

        private Main()
        {

        }

        protected override void Start()
        {
            animeShader.OutlineWidth = 0.0f;
            base.Start();
        }

        protected void OnGUI()
        {
            GUI.Box(new Rect(Screen.width - 110, 110, 100, 180), "Change Shader");

            if (GUI.Button(new Rect(Screen.width - 100, 140, 80, 20), "Unity"))
            {
                unityModel.Body = unityShader.Body;
                unityModel.Hair = unityShader.Hair;
                unityModel.Skin = unityShader.Skin;
                unityModel.Face = unityShader.Face;
                floor.material = unityShader.Floor;
            }
            if (GUI.Button(new Rect(Screen.width - 100, 170, 80, 20), "Standard"))
            {
                unityModel.Body = standardShader.Body;
                unityModel.Hair = standardShader.Hair;
                unityModel.Skin = standardShader.Skin;
                unityModel.Face = standardShader.Face;
                floor.material = standardShader.Floor;
            }
            if (GUI.Button(new Rect(Screen.width - 100, 200, 80, 20), "Anime"))
            {
                unityModel.Body = animeShader.Body;
                unityModel.Hair = animeShader.Hair;
                unityModel.Skin = animeShader.Skin;
                unityModel.Face = animeShader.Face;
                floor.material = animeShader.Floor;
            }

            bool hullToggle = GUI.Toggle(new Rect(Screen.width - 100, 230, 80, 20), hullToggled, " Outline ");

            if (hullToggle != hullToggled)
            {
                hullToggled = hullToggle;

                if (hullToggled)
                {
                    animeShader.OutlineWidth = 0.005f;
                }
                else
                {
                    animeShader.OutlineWidth = 0.0f;
                }
            }

            bool sobelToggle = GUI.Toggle(new Rect(Screen.width - 100, 260, 80, 20), sobelToggled, " Sobel   ");

            if (sobelToggle != sobelToggled)
            {
                sobelToggled = sobelToggle;
                postProcessor.On = sobelToggled;
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

        protected void OnApplicationQuit()
        {
            animeShader.OutlineWidth = 0.0f;
        }
    }
}
